namespace Basic_Tool_Sphere
{
    partial class Decode_Base64
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
            radioButtonFileEncode = new RadioButton();
            radioButtonFileDecode = new RadioButton();
            groupBoxManuallyDecode = new GroupBox();
            radioButtonManuallyEncode = new RadioButton();
            radioButtonManuallyDecode = new RadioButton();
            label3 = new Label();
            richTextBoxOutput = new RichTextBox();
            label2 = new Label();
            richTextBoxInput = new RichTextBox();
            listBoxTXTrows = new ListBox();
            label5 = new Label();
            label1 = new Label();
            textBoxFilePath = new TextBox();
            btnStartFileProcess = new Button();
            btnChoosePath = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBoxManuallyDecode.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(radioButtonFileEncode);
            groupBox1.Controls.Add(radioButtonFileDecode);
            groupBox1.Controls.Add(groupBoxManuallyDecode);
            groupBox1.Controls.Add(listBoxTXTrows);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxFilePath);
            groupBox1.Controls.Add(btnStartFileProcess);
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
            groupBox1.Text = " Base64 Decode/Encode ";
            // 
            // radioButtonFileEncode
            // 
            radioButtonFileEncode.AutoSize = true;
            radioButtonFileEncode.Location = new Point(560, 91);
            radioButtonFileEncode.Name = "radioButtonFileEncode";
            radioButtonFileEncode.Size = new Size(74, 22);
            radioButtonFileEncode.TabIndex = 12;
            radioButtonFileEncode.Text = "Encode";
            radioButtonFileEncode.UseVisualStyleBackColor = true;
            radioButtonFileEncode.CheckedChanged += radioButtonFileEncode_CheckedChanged;
            // 
            // radioButtonFileDecode
            // 
            radioButtonFileDecode.AutoSize = true;
            radioButtonFileDecode.Checked = true;
            radioButtonFileDecode.Location = new Point(468, 91);
            radioButtonFileDecode.Name = "radioButtonFileDecode";
            radioButtonFileDecode.Size = new Size(74, 22);
            radioButtonFileDecode.TabIndex = 13;
            radioButtonFileDecode.TabStop = true;
            radioButtonFileDecode.Text = "Decode";
            radioButtonFileDecode.UseVisualStyleBackColor = true;
            // 
            // groupBoxManuallyDecode
            // 
            groupBoxManuallyDecode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxManuallyDecode.Controls.Add(radioButtonManuallyEncode);
            groupBoxManuallyDecode.Controls.Add(radioButtonManuallyDecode);
            groupBoxManuallyDecode.Controls.Add(label3);
            groupBoxManuallyDecode.Controls.Add(richTextBoxOutput);
            groupBoxManuallyDecode.Controls.Add(label2);
            groupBoxManuallyDecode.Controls.Add(richTextBoxInput);
            groupBoxManuallyDecode.ForeColor = SystemColors.Control;
            groupBoxManuallyDecode.Location = new Point(40, 359);
            groupBoxManuallyDecode.Name = "groupBoxManuallyDecode";
            groupBoxManuallyDecode.Size = new Size(805, 295);
            groupBoxManuallyDecode.TabIndex = 10;
            groupBoxManuallyDecode.TabStop = false;
            groupBoxManuallyDecode.Text = " Base64 Decode/Encode Manually";
            // 
            // radioButtonManuallyEncode
            // 
            radioButtonManuallyEncode.AutoSize = true;
            radioButtonManuallyEncode.Location = new Point(22, 89);
            radioButtonManuallyEncode.Name = "radioButtonManuallyEncode";
            radioButtonManuallyEncode.Size = new Size(74, 22);
            radioButtonManuallyEncode.TabIndex = 11;
            radioButtonManuallyEncode.Text = "Encode";
            radioButtonManuallyEncode.UseVisualStyleBackColor = true;
            // 
            // radioButtonManuallyDecode
            // 
            radioButtonManuallyDecode.AutoSize = true;
            radioButtonManuallyDecode.Checked = true;
            radioButtonManuallyDecode.Location = new Point(22, 61);
            radioButtonManuallyDecode.Name = "radioButtonManuallyDecode";
            radioButtonManuallyDecode.Size = new Size(74, 22);
            radioButtonManuallyDecode.TabIndex = 11;
            radioButtonManuallyDecode.TabStop = true;
            radioButtonManuallyDecode.Text = "Decode";
            radioButtonManuallyDecode.UseVisualStyleBackColor = true;
            radioButtonManuallyDecode.CheckedChanged += radioButtonManuallyDecode_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 40);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 12;
            label3.Text = "Output";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxOutput.BackColor = SystemColors.MenuText;
            richTextBoxOutput.ForeColor = Color.Lime;
            richTextBoxOutput.Location = new Point(463, 61);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.Size = new Size(306, 196);
            richTextBoxOutput.TabIndex = 11;
            richTextBoxOutput.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 40);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 10;
            label2.Text = "Input";
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBoxInput.BackColor = SystemColors.MenuText;
            richTextBoxInput.ForeColor = Color.Lime;
            richTextBoxInput.Location = new Point(132, 61);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(306, 196);
            richTextBoxInput.TabIndex = 9;
            richTextBoxInput.Text = "";
            richTextBoxInput.TextChanged += richTextBoxInput_TextChanged;
            // 
            // listBoxTXTrows
            // 
            listBoxTXTrows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTXTrows.BackColor = SystemColors.MenuText;
            listBoxTXTrows.ForeColor = Color.Lime;
            listBoxTXTrows.FormattingEnabled = true;
            listBoxTXTrows.HorizontalScrollbar = true;
            listBoxTXTrows.ItemHeight = 18;
            listBoxTXTrows.Location = new Point(40, 133);
            listBoxTXTrows.Name = "listBoxTXTrows";
            listBoxTXTrows.Size = new Size(805, 202);
            listBoxTXTrows.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 101);
            label5.Name = "label5";
            label5.Size = new Size(232, 18);
            label5.TabIndex = 8;
            label5.Text = "TXT File Rows: (Max 100 Row)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 8;
            label1.Text = "File:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Enabled = false;
            textBoxFilePath.Location = new Point(94, 41);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(540, 25);
            textBoxFilePath.TabIndex = 4;
            // 
            // btnStartFileProcess
            // 
            btnStartFileProcess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartFileProcess.BackColor = Color.FromArgb(24, 22, 34);
            btnStartFileProcess.Cursor = Cursors.Hand;
            btnStartFileProcess.FlatAppearance.BorderSize = 0;
            btnStartFileProcess.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 120, 50);
            btnStartFileProcess.FlatStyle = FlatStyle.Flat;
            btnStartFileProcess.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnStartFileProcess.ForeColor = SystemColors.Control;
            btnStartFileProcess.Location = new Point(649, 84);
            btnStartFileProcess.Name = "btnStartFileProcess";
            btnStartFileProcess.Size = new Size(196, 37);
            btnStartFileProcess.TabIndex = 3;
            btnStartFileProcess.Text = "Start Decode Process";
            btnStartFileProcess.UseVisualStyleBackColor = false;
            btnStartFileProcess.Click += btnStartFileProcess_Click;
            // 
            // btnChoosePath
            // 
            btnChoosePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChoosePath.BackColor = Color.FromArgb(24, 22, 34);
            btnChoosePath.Cursor = Cursors.Hand;
            btnChoosePath.FlatAppearance.BorderSize = 0;
            btnChoosePath.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 110, 115);
            btnChoosePath.FlatStyle = FlatStyle.Flat;
            btnChoosePath.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnChoosePath.ForeColor = SystemColors.Control;
            btnChoosePath.Location = new Point(649, 41);
            btnChoosePath.Name = "btnChoosePath";
            btnChoosePath.Size = new Size(196, 37);
            btnChoosePath.TabIndex = 3;
            btnChoosePath.Text = "Choose TXT File";
            btnChoosePath.UseVisualStyleBackColor = false;
            btnChoosePath.Click += btnChoosePath_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Decode_Base64
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(910, 696);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Decode_Base64";
            Text = "Decode_Base64";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxManuallyDecode.ResumeLayout(false);
            groupBoxManuallyDecode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxTXTrows;
        private Label label5;
        private Label label1;
        private TextBox textBoxFilePath;
        private Button btnStartFileProcess;
        private Button btnChoosePath;
        private GroupBox groupBoxManuallyDecode;
        private RichTextBox richTextBoxInput;
        private Label label3;
        private RichTextBox richTextBoxOutput;
        private Label label2;
        private RadioButton radioButtonManuallyEncode;
        private RadioButton radioButtonManuallyDecode;
        private RadioButton radioButtonFileEncode;
        private RadioButton radioButtonFileDecode;
        private OpenFileDialog openFileDialog1;
    }
}