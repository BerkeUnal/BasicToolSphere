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
            btnSidebarExit = new Button();
            SidebarChildFolderOperations = new Panel();
            btnSidebarTXTDuplicate = new Button();
            btnSidebarTXTMerge = new Button();
            btnSidebarFolderOperations = new Button();
            panelLogo = new Panel();
            pictureBoxSidebar = new PictureBox();
            panelChildForm = new Panel();
            panelLeftSide.SuspendLayout();
            SidebarChildFolderOperations.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSidebar).BeginInit();
            SuspendLayout();
            // 
            // panelLeftSide
            // 
            panelLeftSide.AutoScroll = true;
            panelLeftSide.BackColor = Color.FromArgb(11, 7, 17);
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
            SidebarChildFolderOperations.Controls.Add(btnSidebarTXTMerge);
            SidebarChildFolderOperations.Dock = DockStyle.Top;
            SidebarChildFolderOperations.Location = new Point(0, 145);
            SidebarChildFolderOperations.Name = "SidebarChildFolderOperations";
            SidebarChildFolderOperations.Size = new Size(250, 83);
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
            btnSidebarTXTDuplicate.Location = new Point(0, 40);
            btnSidebarTXTDuplicate.Name = "btnSidebarTXTDuplicate";
            btnSidebarTXTDuplicate.Padding = new Padding(35, 0, 0, 0);
            btnSidebarTXTDuplicate.Size = new Size(250, 40);
            btnSidebarTXTDuplicate.TabIndex = 1;
            btnSidebarTXTDuplicate.Text = "TXT Duplicate Cleaner";
            btnSidebarTXTDuplicate.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarTXTDuplicate.UseVisualStyleBackColor = true;
            btnSidebarTXTDuplicate.Click += btnSidebarTXTDuplicate_Click;
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
            btnSidebarTXTMerge.Text = "Merge TXT Documents";
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
    }
}