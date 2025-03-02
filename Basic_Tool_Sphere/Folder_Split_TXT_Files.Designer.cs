namespace Basic_Tool_Sphere
{
    partial class Folder_Split_TXT_Files
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
            checkBoxDeleteOriginalFile = new CheckBox();
            listBoxProcessDetails = new ListBox();
            numericFileMaxSize = new NumericUpDown();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            listBoxTXTFiles = new ListBox();
            textBoxPath = new TextBox();
            btnStartSplitProcess = new Button();
            btnChoosePath = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFileMaxSize).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBoxDeleteOriginalFile);
            groupBox1.Controls.Add(listBoxProcessDetails);
            groupBox1.Controls.Add(numericFileMaxSize);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxTXTFiles);
            groupBox1.Controls.Add(textBoxPath);
            groupBox1.Controls.Add(btnStartSplitProcess);
            groupBox1.Controls.Add(btnChoosePath);
            groupBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(875, 677);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " Split TXT Files in The Directory ";
            // 
            // checkBoxDeleteOriginalFile
            // 
            checkBoxDeleteOriginalFile.AutoSize = true;
            checkBoxDeleteOriginalFile.Checked = true;
            checkBoxDeleteOriginalFile.CheckState = CheckState.Checked;
            checkBoxDeleteOriginalFile.Location = new Point(40, 175);
            checkBoxDeleteOriginalFile.Name = "checkBoxDeleteOriginalFile";
            checkBoxDeleteOriginalFile.Size = new Size(323, 22);
            checkBoxDeleteOriginalFile.TabIndex = 11;
            checkBoxDeleteOriginalFile.Text = "Delete Original Files Once Completed?";
            checkBoxDeleteOriginalFile.UseVisualStyleBackColor = true;
            // 
            // listBoxProcessDetails
            // 
            listBoxProcessDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxProcessDetails.BackColor = SystemColors.MenuText;
            listBoxProcessDetails.ForeColor = Color.Lime;
            listBoxProcessDetails.FormattingEnabled = true;
            listBoxProcessDetails.HorizontalScrollbar = true;
            listBoxProcessDetails.ItemHeight = 18;
            listBoxProcessDetails.Location = new Point(40, 309);
            listBoxProcessDetails.Name = "listBoxProcessDetails";
            listBoxProcessDetails.Size = new Size(805, 346);
            listBoxProcessDetails.TabIndex = 5;
            // 
            // numericFileMaxSize
            // 
            numericFileMaxSize.Location = new Point(230, 132);
            numericFileMaxSize.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            numericFileMaxSize.Name = "numericFileMaxSize";
            numericFileMaxSize.Size = new Size(169, 25);
            numericFileMaxSize.TabIndex = 9;
            numericFileMaxSize.TextAlign = HorizontalAlignment.Right;
            numericFileMaxSize.Value = new decimal(new int[] { 512, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 136);
            label4.Name = "label4";
            label4.Size = new Size(24, 18);
            label4.TabIndex = 8;
            label4.Text = "MB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 38);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 8;
            label6.Text = "TXT Files:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 277);
            label5.Name = "label5";
            label5.Size = new Size(136, 18);
            label5.TabIndex = 8;
            label5.Text = "Process Details:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 136);
            label3.Name = "label3";
            label3.Size = new Size(184, 18);
            label3.TabIndex = 8;
            label3.Text = "Maximum Size Per File:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 43);
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
            listBoxTXTFiles.Location = new Point(454, 67);
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
            // btnStartSplitProcess
            // 
            btnStartSplitProcess.BackColor = Color.FromArgb(24, 22, 34);
            btnStartSplitProcess.Cursor = Cursors.Hand;
            btnStartSplitProcess.FlatAppearance.BorderSize = 0;
            btnStartSplitProcess.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 120, 50);
            btnStartSplitProcess.FlatStyle = FlatStyle.Flat;
            btnStartSplitProcess.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnStartSplitProcess.ForeColor = SystemColors.Control;
            btnStartSplitProcess.Location = new Point(40, 211);
            btnStartSplitProcess.Name = "btnStartSplitProcess";
            btnStartSplitProcess.Size = new Size(395, 37);
            btnStartSplitProcess.TabIndex = 3;
            btnStartSplitProcess.Text = "Start Split Process";
            btnStartSplitProcess.UseVisualStyleBackColor = false;
            btnStartSplitProcess.Click += btnStartSplitProcess_Click;
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
            // Folder_Split_TXT_Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(910, 696);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Folder_Split_TXT_Files";
            Text = "Folder_Split_TXT_Files";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFileMaxSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxDeleteOriginalFile;
        private ListBox listBoxProcessDetails;
        private NumericUpDown numericFileMaxSize;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private ListBox listBoxTXTFiles;
        private TextBox textBoxPath;
        private Button btnStartSplitProcess;
        private Button btnChoosePath;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}