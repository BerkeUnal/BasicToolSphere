namespace Osint_Tool
{
    partial class Folder_TXT_Duplicate_Cleaner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            listBoxProcessDetails = new ListBox();
            label1 = new Label();
            listBoxTXTFiles = new ListBox();
            textBoxPath = new TextBox();
            btnRemoveDuplicateLines = new Button();
            btnChoosePath = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(listBoxProcessDetails);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxTXTFiles);
            groupBox1.Controls.Add(textBoxPath);
            groupBox1.Controls.Add(btnRemoveDuplicateLines);
            groupBox1.Controls.Add(btnChoosePath);
            groupBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(875, 677);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " Remove Duplicate Lines from TXT Files in the Directory ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 270);
            label5.Name = "label5";
            label5.Size = new Size(136, 18);
            label5.TabIndex = 10;
            label5.Text = "Process Details:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 37);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 9;
            label6.Text = "TXT Files:";
            // 
            // listBoxProcessDetails
            // 
            listBoxProcessDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxProcessDetails.BackColor = SystemColors.MenuText;
            listBoxProcessDetails.ForeColor = Color.Lime;
            listBoxProcessDetails.FormattingEnabled = true;
            listBoxProcessDetails.HorizontalScrollbar = true;
            listBoxProcessDetails.ItemHeight = 18;
            listBoxProcessDetails.Location = new Point(40, 301);
            listBoxProcessDetails.Name = "listBoxProcessDetails";
            listBoxProcessDetails.Size = new Size(805, 346);
            listBoxProcessDetails.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 8;
            label1.Text = "Path:";
            // 
            // listBoxTXTFiles
            // 
            listBoxTXTFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTXTFiles.BackColor = SystemColors.MenuText;
            listBoxTXTFiles.ForeColor = Color.Lime;
            listBoxTXTFiles.FormattingEnabled = true;
            listBoxTXTFiles.HorizontalScrollbar = true;
            listBoxTXTFiles.ItemHeight = 18;
            listBoxTXTFiles.Location = new Point(454, 66);
            listBoxTXTFiles.Name = "listBoxTXTFiles";
            listBoxTXTFiles.Size = new Size(391, 220);
            listBoxTXTFiles.TabIndex = 5;
            // 
            // textBoxPath
            // 
            textBoxPath.Enabled = false;
            textBoxPath.Location = new Point(87, 39);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(350, 25);
            textBoxPath.TabIndex = 4;
            // 
            // btnRemoveDuplicateLines
            // 
            btnRemoveDuplicateLines.BackColor = Color.FromArgb(24, 22, 34);
            btnRemoveDuplicateLines.Cursor = Cursors.Hand;
            btnRemoveDuplicateLines.FlatAppearance.BorderSize = 0;
            btnRemoveDuplicateLines.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 120, 50);
            btnRemoveDuplicateLines.FlatStyle = FlatStyle.Flat;
            btnRemoveDuplicateLines.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnRemoveDuplicateLines.ForeColor = SystemColors.Control;
            btnRemoveDuplicateLines.Location = new Point(40, 127);
            btnRemoveDuplicateLines.Name = "btnRemoveDuplicateLines";
            btnRemoveDuplicateLines.Size = new Size(395, 37);
            btnRemoveDuplicateLines.TabIndex = 3;
            btnRemoveDuplicateLines.Text = "Remove Duplicate Lines";
            btnRemoveDuplicateLines.UseVisualStyleBackColor = false;
            btnRemoveDuplicateLines.Click += btnRemoveDuplicateLines_Click;
            // 
            // btnChoosePath
            // 
            btnChoosePath.BackColor = Color.FromArgb(24, 22, 34);
            btnChoosePath.Cursor = Cursors.Hand;
            btnChoosePath.FlatAppearance.BorderSize = 0;
            btnChoosePath.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 110, 115);
            btnChoosePath.FlatStyle = FlatStyle.Flat;
            btnChoosePath.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnChoosePath.ForeColor = SystemColors.Control;
            btnChoosePath.Location = new Point(40, 84);
            btnChoosePath.Name = "btnChoosePath";
            btnChoosePath.Size = new Size(395, 37);
            btnChoosePath.TabIndex = 3;
            btnChoosePath.Text = "Choose Path";
            btnChoosePath.UseVisualStyleBackColor = false;
            btnChoosePath.Click += btnChoosePath_Click;
            // 
            // Folder_TXT_Duplicate_Cleaner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(910, 696);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Folder_TXT_Duplicate_Cleaner";
            Text = "DizinTxtTekrarTemizle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxProcessDetails;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxTXTFiles;
        private TextBox textBoxPath;
        private Button btnRemoveDuplicateLines;
        private Button btnChoosePath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label6;
        private Label label5;
    }
}