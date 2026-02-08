namespace SheetNoProtection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OpenExcelFile_Button = new CuoreUI.Controls.cuiButton();
            SelectWorksheets_Button = new CuoreUI.Controls.cuiButton();
            RemoveProtection_Button = new CuoreUI.Controls.cuiButton();
            ReplaceFile_Switch = new CuoreUI.Controls.cuiCheckbox();
            SourceCode_Link = new LinkLabel();
            RemovalProcess_Pbar = new CuoreUI.Controls.cuiProgressBarHorizontal();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 0;
            label1.Text = "SheetNoProtection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(153, 54);
            label2.Name = "label2";
            label2.Size = new Size(283, 20);
            label2.TabIndex = 1;
            label2.Text = "Excel Worksheet Protection Removal Tool";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 306);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "(C) 2026 b0nn133";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(0, 105);
            label4.Name = "label4";
            label4.Size = new Size(586, 15);
            label4.TabIndex = 4;
            label4.Text = "File not opened";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OpenExcelFile_Button
            // 
            OpenExcelFile_Button.CheckButton = false;
            OpenExcelFile_Button.Checked = false;
            OpenExcelFile_Button.CheckedBackground = Color.FromArgb(255, 106, 0);
            OpenExcelFile_Button.CheckedForeColor = Color.White;
            OpenExcelFile_Button.CheckedImageTint = Color.White;
            OpenExcelFile_Button.CheckedOutline = Color.FromArgb(255, 106, 0);
            OpenExcelFile_Button.Content = "Open an Excel file...";
            OpenExcelFile_Button.DialogResult = DialogResult.None;
            OpenExcelFile_Button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenExcelFile_Button.ForeColor = Color.White;
            OpenExcelFile_Button.HoverBackground = Color.FromArgb(30, 30, 30);
            OpenExcelFile_Button.HoverForeColor = Color.White;
            OpenExcelFile_Button.HoverImageTint = Color.DimGray;
            OpenExcelFile_Button.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            OpenExcelFile_Button.Image = null;
            OpenExcelFile_Button.ImageExpand = new Point(0, 0);
            OpenExcelFile_Button.Location = new Point(214, 123);
            OpenExcelFile_Button.Name = "OpenExcelFile_Button";
            OpenExcelFile_Button.NormalBackground = Color.FromArgb(25, 25, 25);
            OpenExcelFile_Button.NormalForeColor = Color.White;
            OpenExcelFile_Button.NormalImageTint = Color.Black;
            OpenExcelFile_Button.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            OpenExcelFile_Button.OutlineThickness = 1F;
            OpenExcelFile_Button.Padding = new Padding(12);
            OpenExcelFile_Button.PressedBackground = Color.FromArgb(20, 20, 20);
            OpenExcelFile_Button.PressedForeColor = Color.White;
            OpenExcelFile_Button.PressedImageTint = Color.FromArgb(32, 32, 32);
            OpenExcelFile_Button.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            OpenExcelFile_Button.Rounding = new Padding(5);
            OpenExcelFile_Button.Size = new Size(153, 26);
            OpenExcelFile_Button.TabIndex = 8;
            OpenExcelFile_Button.TextAlignment = StringAlignment.Center;
            OpenExcelFile_Button.TextPadding = 12;
            OpenExcelFile_Button.TextSpacing = 2;
            OpenExcelFile_Button.Click += OpenExcelFile_Button_Click;
            // 
            // SelectWorksheets_Button
            // 
            SelectWorksheets_Button.CheckButton = false;
            SelectWorksheets_Button.Checked = false;
            SelectWorksheets_Button.CheckedBackground = Color.FromArgb(255, 106, 0);
            SelectWorksheets_Button.CheckedForeColor = Color.White;
            SelectWorksheets_Button.CheckedImageTint = Color.White;
            SelectWorksheets_Button.CheckedOutline = Color.FromArgb(255, 106, 0);
            SelectWorksheets_Button.Content = "Select worksheets...";
            SelectWorksheets_Button.DialogResult = DialogResult.None;
            SelectWorksheets_Button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectWorksheets_Button.ForeColor = Color.White;
            SelectWorksheets_Button.HoverBackground = Color.FromArgb(30, 30, 30);
            SelectWorksheets_Button.HoverForeColor = Color.White;
            SelectWorksheets_Button.HoverImageTint = Color.DimGray;
            SelectWorksheets_Button.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SelectWorksheets_Button.Image = null;
            SelectWorksheets_Button.ImageExpand = new Point(0, 0);
            SelectWorksheets_Button.Location = new Point(214, 155);
            SelectWorksheets_Button.Name = "SelectWorksheets_Button";
            SelectWorksheets_Button.NormalBackground = Color.FromArgb(25, 25, 25);
            SelectWorksheets_Button.NormalForeColor = Color.White;
            SelectWorksheets_Button.NormalImageTint = Color.Black;
            SelectWorksheets_Button.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SelectWorksheets_Button.OutlineThickness = 1F;
            SelectWorksheets_Button.Padding = new Padding(12);
            SelectWorksheets_Button.PressedBackground = Color.FromArgb(20, 20, 20);
            SelectWorksheets_Button.PressedForeColor = Color.White;
            SelectWorksheets_Button.PressedImageTint = Color.FromArgb(32, 32, 32);
            SelectWorksheets_Button.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SelectWorksheets_Button.Rounding = new Padding(5);
            SelectWorksheets_Button.Size = new Size(153, 26);
            SelectWorksheets_Button.TabIndex = 9;
            SelectWorksheets_Button.TextAlignment = StringAlignment.Center;
            SelectWorksheets_Button.TextPadding = 12;
            SelectWorksheets_Button.TextSpacing = 2;
            SelectWorksheets_Button.Click += SelectWorksheets_Button_Click;
            // 
            // RemoveProtection_Button
            // 
            RemoveProtection_Button.CheckButton = false;
            RemoveProtection_Button.Checked = false;
            RemoveProtection_Button.CheckedBackground = Color.FromArgb(255, 106, 0);
            RemoveProtection_Button.CheckedForeColor = Color.White;
            RemoveProtection_Button.CheckedImageTint = Color.White;
            RemoveProtection_Button.CheckedOutline = Color.FromArgb(255, 106, 0);
            RemoveProtection_Button.Content = "Remove Protection";
            RemoveProtection_Button.DialogResult = DialogResult.None;
            RemoveProtection_Button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveProtection_Button.ForeColor = Color.White;
            RemoveProtection_Button.HoverBackground = Color.FromArgb(30, 30, 30);
            RemoveProtection_Button.HoverForeColor = Color.White;
            RemoveProtection_Button.HoverImageTint = Color.DimGray;
            RemoveProtection_Button.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            RemoveProtection_Button.Image = null;
            RemoveProtection_Button.ImageExpand = new Point(0, 0);
            RemoveProtection_Button.Location = new Point(198, 258);
            RemoveProtection_Button.Name = "RemoveProtection_Button";
            RemoveProtection_Button.NormalBackground = Color.FromArgb(25, 25, 25);
            RemoveProtection_Button.NormalForeColor = Color.White;
            RemoveProtection_Button.NormalImageTint = Color.Black;
            RemoveProtection_Button.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            RemoveProtection_Button.OutlineThickness = 1F;
            RemoveProtection_Button.Padding = new Padding(12);
            RemoveProtection_Button.PressedBackground = Color.FromArgb(20, 20, 20);
            RemoveProtection_Button.PressedForeColor = Color.White;
            RemoveProtection_Button.PressedImageTint = Color.FromArgb(32, 32, 32);
            RemoveProtection_Button.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            RemoveProtection_Button.Rounding = new Padding(5);
            RemoveProtection_Button.Size = new Size(187, 37);
            RemoveProtection_Button.TabIndex = 12;
            RemoveProtection_Button.TextAlignment = StringAlignment.Center;
            RemoveProtection_Button.TextPadding = 12;
            RemoveProtection_Button.TextSpacing = 2;
            RemoveProtection_Button.Click += RemoveProtection_Button_Click;
            // 
            // ReplaceFile_Switch
            // 
            ReplaceFile_Switch.Anchor = AnchorStyles.None;
            ReplaceFile_Switch.Checked = false;
            ReplaceFile_Switch.CheckedForeground = Color.DodgerBlue;
            ReplaceFile_Switch.CheckedOutlineColor = Color.DodgerBlue;
            ReplaceFile_Switch.CheckedSymbolColor = Color.White;
            ReplaceFile_Switch.Content = "Replace the file";
            ReplaceFile_Switch.Location = new Point(236, 187);
            ReplaceFile_Switch.MinimumSize = new Size(16, 16);
            ReplaceFile_Switch.Name = "ReplaceFile_Switch";
            ReplaceFile_Switch.OutlineThickness = 1F;
            ReplaceFile_Switch.Rounding = 4;
            ReplaceFile_Switch.ShowSymbols = true;
            ReplaceFile_Switch.Size = new Size(106, 16);
            ReplaceFile_Switch.TabIndex = 13;
            ReplaceFile_Switch.UncheckedForeground = Color.Empty;
            ReplaceFile_Switch.UncheckedOutlineColor = Color.Gray;
            ReplaceFile_Switch.UncheckedSymbolColor = Color.Empty;
            // 
            // SourceCode_Link
            // 
            SourceCode_Link.AutoSize = true;
            SourceCode_Link.LinkColor = Color.DodgerBlue;
            SourceCode_Link.Location = new Point(303, 306);
            SourceCode_Link.Name = "SourceCode_Link";
            SourceCode_Link.Size = new Size(74, 15);
            SourceCode_Link.TabIndex = 14;
            SourceCode_Link.TabStop = true;
            SourceCode_Link.Text = "Source Code";
            SourceCode_Link.LinkClicked += SourceCode_Link_LinkClicked;
            // 
            // RemovalProcess_Pbar
            // 
            RemovalProcess_Pbar.Background = Color.FromArgb(64, 128, 128, 128);
            RemovalProcess_Pbar.Flipped = false;
            RemovalProcess_Pbar.Foreground = Color.DodgerBlue;
            RemovalProcess_Pbar.Location = new Point(184, 231);
            RemovalProcess_Pbar.MaxValue = 100;
            RemovalProcess_Pbar.Name = "RemovalProcess_Pbar";
            RemovalProcess_Pbar.Rounding = 5;
            RemovalProcess_Pbar.Size = new Size(216, 10);
            RemovalProcess_Pbar.TabIndex = 15;
            RemovalProcess_Pbar.TabStop = false;
            RemovalProcess_Pbar.Value = 0;
            RemovalProcess_Pbar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(583, 330);
            Controls.Add(RemovalProcess_Pbar);
            Controls.Add(SourceCode_Link);
            Controls.Add(ReplaceFile_Switch);
            Controls.Add(RemoveProtection_Button);
            Controls.Add(SelectWorksheets_Button);
            Controls.Add(OpenExcelFile_Button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SheetNoProtection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private CuoreUI.Controls.cuiButton OpenExcelFile_Button;
        private CuoreUI.Controls.cuiButton SelectWorksheets_Button;
        private CuoreUI.Controls.cuiButton RemoveProtection_Button;
        private CuoreUI.Controls.cuiCheckbox ReplaceFile_Switch;
        private LinkLabel SourceCode_Link;
        private CuoreUI.Controls.cuiProgressBarHorizontal RemovalProcess_Pbar;
    }
}
