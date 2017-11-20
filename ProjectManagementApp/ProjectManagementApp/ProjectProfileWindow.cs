using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementApp
{
    public partial class ProjectProfileWindow : UserControl
    {
        public ProjectProfileWindow()
        {
            InitializeComponent();
        }
        private static ProjectProfileWindow _instance;

        public static ProjectProfileWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectProfileWindow();
                return _instance;
            }
        }
        public TextBox projecManagerControls
        {
            get { return ProjectLeaderTextBox; }
            set { ProjectLeaderTextBox = value; }
        }

        public RichTextBox projecDescriptionControls
        {
            get { return ProjectDescriptionTextBox; }
            set { ProjectDescriptionTextBox = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectLeaderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NonfunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectEditWindow.Instance))
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectEditWindow.Instance);
                ProjectEditWindow.Instance.Dock = DockStyle.Fill;
                ProjectEditWindow.Instance.BringToFront();
            }
            else
            {
                ProjectEditWindow.Instance.BringToFront();
            }
        }
    }
}
