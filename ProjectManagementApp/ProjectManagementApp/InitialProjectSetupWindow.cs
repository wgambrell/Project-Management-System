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
    public partial class InitialProjectSetupWindow : UserControl
    {
        private static InitialProjectSetupWindow _instance;

        public static InitialProjectSetupWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InitialProjectSetupWindow();
                return _instance;
            }
        }
        public InitialProjectSetupWindow()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProjectManagerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamMemberNewInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddRiskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRiskButton_Click(object sender, EventArgs e)
        {
            if (TeamMemberNewInputBox.Text != "")
                TeamMembersListBox.Items.Add(TeamMemberNewInputBox.Text);
        }

        private void FinishSetupButton_Click(object sender, EventArgs e)
        {

            //Creates taskbar
            if (!ProjectManagementSystem.Instance.PanelBarControls.Controls.Contains(Taskbar.Instance))
            {
                ProjectManagementSystem.Instance.PanelBarControls.Controls.Add(Taskbar.Instance);
                Taskbar.Instance.Dock = DockStyle.Fill;
                Taskbar.Instance.BringToFront();
            }
            else
            {
                Taskbar.Instance.BringToFront();  
            }
            //Creates Project Profile window and sets it to open
            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectProfileWindow.Instance))
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectProfileWindow.Instance);
                ProjectProfileWindow.Instance.Dock = DockStyle.Fill;
                ProjectProfileWindow.Instance.BringToFront();
            }
            else
            {
                ProjectProfileWindow.Instance.BringToFront();
            }
            //Create Project Effort page
            ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectEffortManagement.Instance);
            ProjectEffortManagement.Instance.Dock = DockStyle.Fill;

            ProjectManagementSystem.Instance.Panel1Control.Controls.Remove(InitialProjectSetupWindow.Instance);


        }

        private void CancelSetupButton_Click(object sender, EventArgs e)
        {
            ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectSelectWindow.Instance);
            ProjectSelectWindow.Instance.BringToFront();
        }

        private void InitialProjectSetupWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
