namespace New_Software
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelLeftSide = new Panel();
            SidebarChildDecode = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnSidebarDecodeHex = new Button();
            btnSidebarDecodeBase64 = new Button();
            btnSidebarDecryptOperations = new Button();
            btnSidebarExit = new Button();
            SidebarChildFolderOperations = new Panel();
            btnSidebarTXTDuplicate = new Button();
            btnSidebarSplitLargeTXT = new Button();
            btnSidebarTXTMerge = new Button();
            btnSidebarFolderOperations = new Button();
            panelLogo = new Panel();
            pictureBoxSidebar = new PictureBox();
            panelChildForm = new Panel();
            panelLeftSide.SuspendLayout();
            SidebarChildDecode.SuspendLayout();
            SidebarChildFolderOperations.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSidebar).BeginInit();
            SuspendLayout();
            // 
            // panelLeftSide
            // 
            panelLeftSide.AutoScroll = true;
            panelLeftSide.BackColor = Color.FromArgb(11, 7, 17);
            panelLeftSide.Controls.Add(SidebarChildDecode);
            panelLeftSide.Controls.Add(btnSidebarDecryptOperations);
            panelLeftSide.Controls.Add(btnSidebarExit);
            panelLeftSide.Controls.Add(SidebarChildFolderOperations);
            panelLeftSide.Controls.Add(btnSidebarFolderOperations);
            panelLeftSide.Controls.Add(panelLogo);
            panelLeftSide.Dock = DockStyle.Left;
            panelLeftSide.Location = new Point(0, 0);
            panelLeftSide.Name = "panelLeftSide";
            panelLeftSide.Size = new Size(250, 711);
            panelLeftSide.TabIndex = 0;
            // 
            // SidebarChildDecode
            // 
            SidebarChildDecode.BackColor = Color.FromArgb(35, 32, 39);
            SidebarChildDecode.Controls.Add(button4);
            SidebarChildDecode.Controls.Add(button3);
            SidebarChildDecode.Controls.Add(button2);
            SidebarChildDecode.Controls.Add(btnSidebarDecodeHex);
            SidebarChildDecode.Controls.Add(btnSidebarDecodeBase64);
            SidebarChildDecode.Dock = DockStyle.Top;
            SidebarChildDecode.Location = new Point(0, 312);
            SidebarChildDecode.Name = "SidebarChildDecode";
            SidebarChildDecode.Size = new Size(250, 203);
            SidebarChildDecode.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 32, 38);
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(0, 160);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 40);
            button4.TabIndex = 4;
            button4.Text = "Binary Decode/Encode";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 32, 38);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(0, 120);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 40);
            button3.TabIndex = 3;
            button3.Text = "ASCII Decode/Encode";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 32, 38);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(0, 80);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(250, 40);
            button2.TabIndex = 2;
            button2.Text = "URL Decode/Encode";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSidebarDecodeHex
            // 
            btnSidebarDecodeHex.BackColor = Color.FromArgb(35, 32, 38);
            btnSidebarDecodeHex.Cursor = Cursors.Hand;
            btnSidebarDecodeHex.Dock = DockStyle.Top;
            btnSidebarDecodeHex.FlatAppearance.BorderSize = 0;
            btnSidebarDecodeHex.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarDecodeHex.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarDecodeHex.FlatStyle = FlatStyle.Flat;
            btnSidebarDecodeHex.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnSidebarDecodeHex.ForeColor = Color.Silver;
            btnSidebarDecodeHex.Location = new Point(0, 40);
            btnSidebarDecodeHex.Name = "btnSidebarDecodeHex";
            btnSidebarDecodeHex.Padding = new Padding(35, 0, 0, 0);
            btnSidebarDecodeHex.Size = new Size(250, 40);
            btnSidebarDecodeHex.TabIndex = 1;
            btnSidebarDecodeHex.Text = "HEX Decode/Encode";
            btnSidebarDecodeHex.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarDecodeHex.UseVisualStyleBackColor = true;
            // 
            // btnSidebarDecodeBase64
            // 
            btnSidebarDecodeBase64.BackColor = Color.FromArgb(35, 32, 38);
            btnSidebarDecodeBase64.Cursor = Cursors.Hand;
            btnSidebarDecodeBase64.Dock = DockStyle.Top;
            btnSidebarDecodeBase64.FlatAppearance.BorderSize = 0;
            btnSidebarDecodeBase64.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarDecodeBase64.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarDecodeBase64.FlatStyle = FlatStyle.Flat;
            btnSidebarDecodeBase64.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnSidebarDecodeBase64.ForeColor = Color.Silver;
            btnSidebarDecodeBase64.Location = new Point(0, 0);
            btnSidebarDecodeBase64.Name = "btnSidebarDecodeBase64";
            btnSidebarDecodeBase64.Padding = new Padding(35, 0, 0, 0);
            btnSidebarDecodeBase64.Size = new Size(250, 40);
            btnSidebarDecodeBase64.TabIndex = 0;
            btnSidebarDecodeBase64.Text = "Base64 Decode/Encode";
            btnSidebarDecodeBase64.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarDecodeBase64.UseVisualStyleBackColor = true;
            btnSidebarDecodeBase64.Click += btnSidebarDecodeBase64_Click;
            // 
            // btnSidebarDecryptOperations
            // 
            btnSidebarDecryptOperations.Cursor = Cursors.Hand;
            btnSidebarDecryptOperations.Dock = DockStyle.Top;
            btnSidebarDecryptOperations.FlatAppearance.BorderSize = 0;
            btnSidebarDecryptOperations.FlatStyle = FlatStyle.Flat;
            btnSidebarDecryptOperations.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSidebarDecryptOperations.ForeColor = Color.Silver;
            btnSidebarDecryptOperations.Image = (Image)resources.GetObject("btnSidebarDecryptOperations.Image");
            btnSidebarDecryptOperations.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarDecryptOperations.Location = new Point(0, 267);
            btnSidebarDecryptOperations.Name = "btnSidebarDecryptOperations";
            btnSidebarDecryptOperations.Padding = new Padding(5, 0, 0, 0);
            btnSidebarDecryptOperations.Size = new Size(250, 45);
            btnSidebarDecryptOperations.TabIndex = 10;
            btnSidebarDecryptOperations.Text = " Decode Operations";
            btnSidebarDecryptOperations.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarDecryptOperations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSidebarDecryptOperations.UseVisualStyleBackColor = true;
            btnSidebarDecryptOperations.Click += btnSidebarDecryptOperations_Click;
            // 
            // btnSidebarExit
            // 
            btnSidebarExit.Cursor = Cursors.Hand;
            btnSidebarExit.Dock = DockStyle.Bottom;
            btnSidebarExit.FlatAppearance.BorderSize = 0;
            btnSidebarExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 42, 83);
            btnSidebarExit.FlatStyle = FlatStyle.Flat;
            btnSidebarExit.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnSidebarExit.ForeColor = Color.Silver;
            btnSidebarExit.Image = (Image)resources.GetObject("btnSidebarExit.Image");
            btnSidebarExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarExit.Location = new Point(0, 666);
            btnSidebarExit.Name = "btnSidebarExit";
            btnSidebarExit.Padding = new Padding(5, 0, 0, 0);
            btnSidebarExit.Size = new Size(250, 45);
            btnSidebarExit.TabIndex = 9;
            btnSidebarExit.Text = " Exit";
            btnSidebarExit.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSidebarExit.UseVisualStyleBackColor = true;
            btnSidebarExit.Click += btnSidebarExit_Click;
            // 
            // SidebarChildFolderOperations
            // 
            SidebarChildFolderOperations.BackColor = Color.FromArgb(35, 32, 39);
            SidebarChildFolderOperations.Controls.Add(btnSidebarTXTDuplicate);
            SidebarChildFolderOperations.Controls.Add(btnSidebarSplitLargeTXT);
            SidebarChildFolderOperations.Controls.Add(btnSidebarTXTMerge);
            SidebarChildFolderOperations.Dock = DockStyle.Top;
            SidebarChildFolderOperations.Location = new Point(0, 145);
            SidebarChildFolderOperations.Name = "SidebarChildFolderOperations";
            SidebarChildFolderOperations.Size = new Size(250, 122);
            SidebarChildFolderOperations.TabIndex = 2;
            // 
            // btnSidebarTXTDuplicate
            // 
            btnSidebarTXTDuplicate.BackColor = Color.FromArgb(35, 32, 38);
            btnSidebarTXTDuplicate.Cursor = Cursors.Hand;
            btnSidebarTXTDuplicate.Dock = DockStyle.Top;
            btnSidebarTXTDuplicate.FlatAppearance.BorderSize = 0;
            btnSidebarTXTDuplicate.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarTXTDuplicate.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarTXTDuplicate.FlatStyle = FlatStyle.Flat;
            btnSidebarTXTDuplicate.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnSidebarTXTDuplicate.ForeColor = Color.Silver;
            btnSidebarTXTDuplicate.Location = new Point(0, 80);
            btnSidebarTXTDuplicate.Name = "btnSidebarTXTDuplicate";
            btnSidebarTXTDuplicate.Padding = new Padding(35, 0, 0, 0);
            btnSidebarTXTDuplicate.Size = new Size(250, 40);
            btnSidebarTXTDuplicate.TabIndex = 1;
            btnSidebarTXTDuplicate.Text = "TXT Duplicate Cleaner";
            btnSidebarTXTDuplicate.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarTXTDuplicate.UseVisualStyleBackColor = true;
            btnSidebarTXTDuplicate.Click += btnSidebarTXTDuplicate_Click;
            // 
            // btnSidebarSplitLargeTXT
            // 
            btnSidebarSplitLargeTXT.BackColor = Color.FromArgb(35, 32, 38);
            btnSidebarSplitLargeTXT.Cursor = Cursors.Hand;
            btnSidebarSplitLargeTXT.Dock = DockStyle.Top;
            btnSidebarSplitLargeTXT.FlatAppearance.BorderSize = 0;
            btnSidebarSplitLargeTXT.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarSplitLargeTXT.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarSplitLargeTXT.FlatStyle = FlatStyle.Flat;
            btnSidebarSplitLargeTXT.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnSidebarSplitLargeTXT.ForeColor = Color.Silver;
            btnSidebarSplitLargeTXT.Location = new Point(0, 40);
            btnSidebarSplitLargeTXT.Name = "btnSidebarSplitLargeTXT";
            btnSidebarSplitLargeTXT.Padding = new Padding(35, 0, 0, 0);
            btnSidebarSplitLargeTXT.Size = new Size(250, 40);
            btnSidebarSplitLargeTXT.TabIndex = 2;
            btnSidebarSplitLargeTXT.Text = "Split TXT Files";
            btnSidebarSplitLargeTXT.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarSplitLargeTXT.UseVisualStyleBackColor = true;
            btnSidebarSplitLargeTXT.Click += btnSidebarSplitLargeTXT_Click;
            // 
            // btnSidebarTXTMerge
            // 
            btnSidebarTXTMerge.BackColor = Color.FromArgb(35, 32, 38);
            btnSidebarTXTMerge.Cursor = Cursors.Hand;
            btnSidebarTXTMerge.Dock = DockStyle.Top;
            btnSidebarTXTMerge.FlatAppearance.BorderSize = 0;
            btnSidebarTXTMerge.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarTXTMerge.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnSidebarTXTMerge.FlatStyle = FlatStyle.Flat;
            btnSidebarTXTMerge.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnSidebarTXTMerge.ForeColor = Color.Silver;
            btnSidebarTXTMerge.Location = new Point(0, 0);
            btnSidebarTXTMerge.Name = "btnSidebarTXTMerge";
            btnSidebarTXTMerge.Padding = new Padding(35, 0, 0, 0);
            btnSidebarTXTMerge.Size = new Size(250, 40);
            btnSidebarTXTMerge.TabIndex = 0;
            btnSidebarTXTMerge.Text = "Merge TXT Files";
            btnSidebarTXTMerge.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarTXTMerge.UseVisualStyleBackColor = true;
            btnSidebarTXTMerge.Click += btnSidebarTXTMerge_Click;
            // 
            // btnSidebarFolderOperations
            // 
            btnSidebarFolderOperations.Cursor = Cursors.Hand;
            btnSidebarFolderOperations.Dock = DockStyle.Top;
            btnSidebarFolderOperations.FlatAppearance.BorderSize = 0;
            btnSidebarFolderOperations.FlatStyle = FlatStyle.Flat;
            btnSidebarFolderOperations.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSidebarFolderOperations.ForeColor = Color.Silver;
            btnSidebarFolderOperations.Image = (Image)resources.GetObject("btnSidebarFolderOperations.Image");
            btnSidebarFolderOperations.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarFolderOperations.Location = new Point(0, 100);
            btnSidebarFolderOperations.Name = "btnSidebarFolderOperations";
            btnSidebarFolderOperations.Padding = new Padding(5, 0, 0, 0);
            btnSidebarFolderOperations.Size = new Size(250, 45);
            btnSidebarFolderOperations.TabIndex = 1;
            btnSidebarFolderOperations.Text = " Folder Operations";
            btnSidebarFolderOperations.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarFolderOperations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSidebarFolderOperations.UseVisualStyleBackColor = true;
            btnSidebarFolderOperations.Click += btnSidebarFolderOperations_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxSidebar);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxSidebar
            // 
            pictureBoxSidebar.Image = (Image)resources.GetObject("pictureBoxSidebar.Image");
            pictureBoxSidebar.Location = new Point(29, -13);
            pictureBoxSidebar.Name = "pictureBoxSidebar";
            pictureBoxSidebar.Size = new Size(167, 122);
            pictureBoxSidebar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSidebar.TabIndex = 0;
            pictureBoxSidebar.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(903, 711);
            panelChildForm.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1153, 711);
            Controls.Add(panelChildForm);
            Controls.Add(panelLeftSide);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1169, 750);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Tool Sphere";
            Load += Form1_Load;
            panelLeftSide.ResumeLayout(false);
            SidebarChildDecode.ResumeLayout(false);
            SidebarChildFolderOperations.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSidebar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeftSide;
        private Panel panelLogo;
        private PictureBox pictureBoxSidebar;
        private Button btnSidebarFolderOperations;
        private Panel SidebarChildFolderOperations;
        private Button btnSidebarTXTMerge;
        private Panel panelChildForm;
        private Button btnSidebarExit;
        private Button btnSidebarTXTDuplicate;
        private Button btnSidebarSplitLargeTXT;
        private Button btnSidebarDecryptOperations;
        private Panel SidebarChildDecode;
        private Button button2;
        private Button btnSidebarDecodeHex;
        private Button btnSidebarDecodeBase64;
        private Button button4;
        private Button button3;
    }
}