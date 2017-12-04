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
    public partial class ProjectEditWindow : UserControl
    {
        public ProjectEditWindow()
        {
            InitializeComponent();
        }
        private static ProjectEditWindow _instance;

        public static ProjectEditWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectEditWindow();
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


        public ListBox RiskListControls
        {
            get { return RiskListBox; }
            set { RiskListBox = value; }
        }

        public ListBox teamMemberListControls
        {
            get { return TeamMemberListBox1; }
            set { TeamMemberListBox1 = value; }
        }

        public ListBox FuncReqsListControls
        {
            get { return FunctionalReqListBox; }
            set { FunctionalReqListBox = value; }
        }

        public ListBox NonFuncReqsListControls
        {
            get { return NonFunctionalReqListBox; }
            set { NonFunctionalReqListBox = value; }
        }
        private void ProjectEditWindow_Load(object sender, EventArgs e)
        {

        }

        private void ProjectLeaderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveTeamMemberButton.Enabled = true;
        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveRiskButton.Enabled = true;
        }

        private void FunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NonfunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveProfileButton_Click(object sender, EventArgs e)    //Sendds all data in text boxes to Project.cs class, moves to project profile window
        {
            Project.Instance.managerNameControls = ProjectLeaderTextBox.Text;
            Project.Instance.projectDescriptionControls = ProjectDescriptionTextBox.Text;
            Project.Instance.projectMembersControl.Clear();
            foreach (var item in TeamMemberListBox1.Items)
            {
                Project.Instance.projectMembersControl.Add(item);
            }

            Project.Instance.projectRiskControl.Clear();
            foreach (var item in RiskListBox.Items)
            {
                Project.Instance.projectRiskControl.Add(item);
            }

            Project.Instance.FuncReqControl.Clear();
            foreach (var item in FunctionalReqListBox.Items)
            {
                Project.Instance.FuncReqControl.Add(item);
            }

            Project.Instance.NonFuncReqControl.Clear();
            foreach (var item in NonFunctionalReqListBox.Items)
            {
                Project.Instance.NonFuncReqControl.Add(item);
            }
            Project.Instance.setProfilePage();

            Project.Instance.RewriteFile(); //Rewrites the file, passing the buck to the Project.cs file for a sec
            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectProfileWindow.Instance))
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectProfileWindow.Instance);
                ProjectProfileWindow.Instance.Dock = DockStyle.Fill;
                ProjectProfileWindow.Instance.BringToFront();
            }
            else
            {
                ProjectProfileWindow.Instance.BringToFront();   //Switches back to project profile window
            }
        }

        private void AddFuncReqButton_Click(object sender, EventArgs e)
        {
            if (AddFunctionalRequirementTextBox.Text != "")
                FunctionalReqListBox.Items.Add(AddFunctionalRequirementTextBox.Text);
            AddFunctionalRequirementTextBox.Text = "";
        }

        private void AddNonFunctReqButton_Click(object sender, EventArgs e)
        {
            if (AddNonFunctRequirement.Text != "")
                NonFunctionalReqListBox.Items.Add(AddNonFunctRequirement.Text);
            AddNonFunctRequirement.Text = "";
        }

        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {
            if (AddTeamMemberTextBox.Text != "")
                TeamMemberListBox1.Items.Add(AddTeamMemberTextBox.Text);
            AddTeamMemberTextBox.Text = "";
        }

        private void AddRisksButton_Click(object sender, EventArgs e)
        {
            if (AddRiskTextBox.Text != "")
                RiskListBox.Items.Add(AddRiskTextBox.Text);
            AddRiskTextBox.Text = "";
        }

        private void FunctionalReqListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveFuncReq.Enabled = true;
        }

        private void NonFunctionalReqListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveNonFuncReq.Enabled = true;
        }

        private void RemoveFuncReq_Click(object sender, EventArgs e)
        {
            FunctionalReqListBox.Items.Remove(FunctionalReqListBox.SelectedItem);
            RemoveFuncReq.Enabled = false;
        }

        private void RemoveNonFuncReq_Click(object sender, EventArgs e)
        {
            NonFunctionalReqListBox.Items.Remove(NonFunctionalReqListBox.SelectedItem);
            RemoveNonFuncReq.Enabled = false;
        }

        private void RemoveTeamMemberButton_Click(object sender, EventArgs e)
        {
            TeamMemberListBox1.Items.Remove(TeamMemberListBox1.SelectedItem);
            RemoveTeamMemberButton.Enabled = false;
        }

        private void RemoveRiskButton_Click(object sender, EventArgs e)
        {
            RiskListBox.Items.Remove(RiskListBox.SelectedItem);
            RemoveRiskButton.Enabled = false;
        }
        private void AddNonFuncRequirement_Click(object sender, EventArgs e)
        {
            AddNonFunctRequirement.Text = "";
        }
        private void AddFuncRequirementTextBoxTextBox_Click(object sender, EventArgs e)
        {
            AddFunctionalRequirementTextBox.Text = "";
        }
        private void AddTeamMemberTextBox_Click(object sender, EventArgs e)
        {
            AddTeamMemberTextBox.Text = "";
        }
        private void AddRiskTextBox_Click(object sender, EventArgs e)
        {
            AddRiskTextBox.Text = "";
        }
    }
}
