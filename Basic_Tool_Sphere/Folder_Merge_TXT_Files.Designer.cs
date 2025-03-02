namespace Osint_Tool
{
    partial class Folder_Merge_TXT_Files
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
            textBox2 = new TextBox();
            numericFileMaxSize = new NumericUpDown();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxTXTFiles = new ListBox();
            textBoxPath = new TextBox();
            btnStartMergeProcess = new Button();
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(numericFileMaxSize);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxTXTFiles);
            groupBox1.Controls.Add(textBoxPath);
            groupBox1.Controls.Add(btnStartMergeProcess);
            groupBox1.Controls.Add(btnChoosePath);
            groupBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(16, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(875, 677);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Merge TXT Documents in the Directory";
            // 
            // checkBoxDeleteOriginalFile
            // 
            checkBoxDeleteOriginalFile.AutoSize = true;
            checkBoxDeleteOriginalFile.Checked = true;
            checkBoxDeleteOriginalFile.CheckState = CheckState.Checked;
            checkBoxDeleteOriginalFile.Location = new Point(40, 215);
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
            listBoxProcessDetails.Location = new Point(40, 341);
            listBoxProcessDetails.Name = "listBoxProcessDetails";
            listBoxProcessDetails.Size = new Size(805, 310);
            listBoxProcessDetails.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 25);
            textBox2.TabIndex = 10;
            textBox2.Text = "merged_file";
            // 
            // numericFileMaxSize
            // 
            numericFileMaxSize.Location = new Point(230, 173);
            numericFileMaxSize.Maximum = new decimal(new int[] { 10240, 0, 0, 0 });
            numericFileMaxSize.Name = "numericFileMaxSize";
            numericFileMaxSize.Size = new Size(169, 25);
            numericFileMaxSize.TabIndex = 9;
            numericFileMaxSize.TextAlign = HorizontalAlignment.Right;
            numericFileMaxSize.Value = new decimal(new int[] { 10240, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 176);
            label4.Name = "label4";
            label4.Size = new Size(24, 18);
            label4.TabIndex = 8;
            label4.Text = "MB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 37);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 8;
            label6.Text = "TXT Files:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 309);
            label5.Name = "label5";
            label5.Size = new Size(136, 18);
            label5.TabIndex = 8;
            label5.Text = "Process Details:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 176);
            label3.Name = "label3";
            label3.Size = new Size(184, 18);
            label3.TabIndex = 8;
            label3.Text = "Maximum Size Per File:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 138);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 8;
            label2.Text = "File Name to Create:";
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
            // btnStartMergeProcess
            // 
            btnStartMergeProcess.BackColor = Color.FromArgb(24, 22, 34);
            btnStartMergeProcess.Cursor = Cursors.Hand;
            btnStartMergeProcess.FlatAppearance.BorderSize = 0;
            btnStartMergeProcess.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 120, 50);
            btnStartMergeProcess.FlatStyle = FlatStyle.Flat;
            btnStartMergeProcess.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnStartMergeProcess.ForeColor = SystemColors.Control;
            btnStartMergeProcess.Location = new Point(40, 252);
            btnStartMergeProcess.Name = "btnStartMergeProcess";
            btnStartMergeProcess.Size = new Size(395, 37);
            btnStartMergeProcess.TabIndex = 3;
            btnStartMergeProcess.Text = "Start Merge Process";
            btnStartMergeProcess.UseVisualStyleBackColor = false;
            btnStartMergeProcess.Click += btnStartMergeProcess_Click;
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
            // Folder_Merge_TXT_Documents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(910, 696);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Folder_Merge_TXT_Documents";
            Text = "DizinTXTBirlestir";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFileMaxSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChoosePath;
        private Label label1;
        private ListBox listBoxTXTFiles;
        private TextBox textBoxPath;
        private TextBox textBox2;
        private NumericUpDown numericFileMaxSize;
        private Label label3;
        private Label label2;
        private Button btnStartMergeProcess;
        private ListBox listBoxProcessDetails;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
        private CheckBox checkBoxDeleteOriginalFile;
        private Label label6;
        private Label label5;
    }
}