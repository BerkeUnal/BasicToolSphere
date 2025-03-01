using New_Software;
using Osint_Tool;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace New_Software
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        private Dictionary<Type, Form> openedForms = new Dictionary<Type, Form>();

        public Main()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void hideSubMenu()
        {
            SidebarChildFolderOperations.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();

            if (!openedForms.ContainsKey(childForm.GetType()))
            {
                openedForms[childForm.GetType()] = childForm;
                childForm.FormClosed += (s, args) => openedForms.Remove(childForm.GetType());

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
            }
            else
                childForm = openedForms[childForm.GetType()];

            activeForm = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSidebarFolderOperations_Click(object sender, EventArgs e)
        {
            showSubMenu(SidebarChildFolderOperations);
        }

        private void btnSidebarTXTMerge_Click(object sender, EventArgs e)
        {
            openChildForm(new Folder_Merge_TXT_Documents());
            hideSubMenu();
        }
        private void btnSidebarTXTDuplicate_Click(object sender, EventArgs e)
        {
            openChildForm(new Folder_TXT_Duplicate_Cleaner());
            hideSubMenu();
        }

        private void btnSidebarExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}