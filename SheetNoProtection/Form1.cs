/*
 *                             SheetNoProtection
 *                  Excel Worksheet Protection Removal Tool
 *                            (C) 2026 b0nn133
 *               Licensed under GNU General Public License 3.0.
 */          

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;

namespace SheetNoProtection
{
    public partial class Form1 : Form
    {
        private string doc_path = "";
        private string zip_path = "";
        private string file_extension = "";
        private string src_url = "https://github.com/b0nn133/SheetNoProtection";

        private Collection<string> sheets = new Collection<string>();
        private Collection<string> selectedSheets = new Collection<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessExcelXMLFile()
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(doc_path));
            file_extension = Path.GetExtension(doc_path).ToLower();

            if (Directory.Exists(tempFolder))
            {
                Directory.Delete(tempFolder, true);
            }
            Directory.CreateDirectory(tempFolder);

            try
            {
                ZipFile.ExtractToDirectory(doc_path, tempFolder);
                zip_path = tempFolder;

                PopulateSheets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateSheets()
        {
            string worksheetsFolder = Path.Combine(zip_path, "xl", "worksheets");

            if (Directory.Exists(worksheetsFolder))
            {
                sheets.Clear();

                var sheetFiles = Directory.GetFiles(worksheetsFolder, "*.xml");

                foreach (var sheetFile in sheetFiles)
                {
                    string sheetName = Path.GetFileNameWithoutExtension(sheetFile);
                    sheets.Add(sheetName);
                }
            }
            else
            {
                MessageBox.Show("'Worksheets' folder not found.", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectWorksheets_Button_Click(object sender, EventArgs e)
        {
            if (zip_path == "")
            {
                MessageBox.Show("No Excel file was selected.", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (OpenFileDialog sheet_ofd = new OpenFileDialog())
            {
                sheet_ofd.Title = "Select worksheets";
                sheet_ofd.Multiselect = true;
                sheet_ofd.InitialDirectory = Path.Combine(zip_path, "xl", "worksheets");

                sheet_ofd.Filter = "Excel Sheet XML Files|*.xml";

                if (sheet_ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedSheets.Clear();
                    foreach (var selectedFile in sheet_ofd.FileNames)
                    {
                        selectedSheets.Add(selectedFile);
                    }

                    string selectedSheetNames = string.Join(Environment.NewLine, selectedSheets);
                    MessageBox.Show($"Selected worksheets:\n{selectedSheetNames}", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RemoveProtection_Button_Click(object sender, EventArgs e)
        {
            if (selectedSheets.Count == 0)
            {
                MessageBox.Show("No worksheets were selected.", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemovalProcess_Pbar.Visible = true; 

            foreach (var sheetPath in selectedSheets)
            {
                RemoveSheetProtection(sheetPath);
            }


            RemovalProcess_Pbar.Value = 50;

            RezipExcelFile();
        }

        private void RemoveSheetProtection(string sheet)
        {
            try
            {
                string sheetPath = Path.Combine(zip_path, "xl", "worksheets", Path.GetFileName(sheet));

                if (File.Exists(sheetPath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(sheetPath);

                    XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                    nsmgr.AddNamespace("ns", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

                    XmlNode sheetProtectionNode = xmlDoc.SelectSingleNode("//ns:sheetProtection", nsmgr);

                    if (sheetProtectionNode != null)
                    {
                        sheetProtectionNode.ParentNode.RemoveChild(sheetProtectionNode);

                        xmlDoc.Save(sheetPath);
                    }
                }
                else
                {
                    MessageBox.Show($"Worksheet does not exist: {sheet}", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while modifying Worksheet '{sheet}': {ex.Message}", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cleanup()
        {
            zip_path = "";
            doc_path = "";
            RemovalProcess_Pbar.Value = 0;
            RemovalProcess_Pbar.Visible = false;
            sheets.Clear();
            selectedSheets.Clear();
        }

        private void RezipExcelFile()
        {
            try
            {
                string suffix = ReplaceFile_Switch.Checked ? $"{file_extension}" : $"-modified{file_extension}";
                string newDocPath = Path.Combine(Path.GetDirectoryName(doc_path), Path.GetFileNameWithoutExtension(doc_path) + suffix);

                if (File.Exists(newDocPath))
                {
                    File.Delete(newDocPath);
                }

                ZipFile.CreateFromDirectory(zip_path, newDocPath, CompressionLevel.Optimal, false);

                RemovalProcess_Pbar.Value = 100;

                MessageBox.Show($"Modified file was saved to: {newDocPath}", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleanup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while compressing the file: {ex.Message}", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenExcelFile_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xlsm;*.xltx;*.xltm;*.xlam|Excel Workbook (*.xlsx)|*.xlsx|Macro-Enabled (*.xlsm)|*.xlsm|Excel Template (*.xltx)|*.xltx";
                ofd.Title = "Select an Excel file";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    doc_path = ofd.FileName;
                    label4.Text = doc_path;

                    string fileExtension = Path.GetExtension(doc_path).ToLower();

                    if (fileExtension == ".xlsx" || fileExtension == ".xlsm" || fileExtension == ".xltx" || fileExtension == ".xltm" || fileExtension == ".xlam")
                    {
                        ProcessExcelXMLFile();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect file format.", "SheetNoProtection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SourceCode_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(src_url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(src_url, "Source Code Link", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
