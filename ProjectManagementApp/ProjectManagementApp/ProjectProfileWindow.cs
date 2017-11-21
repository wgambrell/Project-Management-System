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
        public ListBox teamMemberListControls
        {
            get { return TeamMemberListBox; }
            set { TeamMemberListBox = value; }
        }

        public ListBox RiskListControls
        {
            get { return RiskListBox; }
            set { RiskListBox = value; }
        }
        public ListBox funcRequirements
        {
            get { return FunctionalRequirementsListBox; }
            set { FunctionalRequirementsListBox = value; }
        }

        public ListBox NonfuncRequirements
        {
            get { return NonfunctionalRequirementsListBox; }
            set { NonfunctionalRequirementsListBox = value; }
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

            // Sets values on edit page
            ProjectEditWindow.Instance.projecManagerControls.Text = ProjectLeaderTextBox.Text;
            ProjectEditWindow.Instance.projecDescriptionControls.Text = ProjectDescriptionTextBox.Text;

            // Sets valuse for lists
            ProjectEditWindow.Instance.teamMemberListControls.Items.Clear();
            ProjectEditWindow.Instance.RiskListControls.Items.Clear();

            foreach (var item in Project.Instance.projectMembersControl)
            {
                ProjectEditWindow.Instance.teamMemberListControls.Items.Add(item);
            }

            foreach (var item in Project.Instance.projectRiskControl)
            {
                ProjectEditWindow.Instance.RiskListControls.Items.Add(item);
            }
        }

        private void ProjectProfileWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
