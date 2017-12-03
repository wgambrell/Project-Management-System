using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            TeamRemoveButton.Enabled = true;
        }

        private void TeamMemberNewInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (AddMemberbox.Text != "")
                TeamMembersListBox.Items.Add(AddMemberbox.Text);
            AddMemberbox.Text = "";
        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RisksRemoveButton.Enabled = true;
        }

        private void AddRiskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRiskButton_Click(object sender, EventArgs e)
        {
            if (AddRiskTextBox.Text != "")
                RiskListBox.Items.Add(AddRiskTextBox.Text);
            AddRiskTextBox.Text = "";
        }

        private void FinishSetupButton_Click(object sender, EventArgs e)
        {
            if (ProjectNameTextBox.Text == "" || ProjectManagerTextBox.Text == "" || DescriptionTextBox.Text == "" || comboBox1.SelectedItem == null)
            {
                if(ProjectNameTextBox.Text == "")
                    ProjectNameFieldRequiredLabel.Visible = true;
                if (ProjectManagerTextBox.Text == "")
                    ManagerFieldRequiredLabel.Visible = true;
                if (DescriptionTextBox.Text == "")
                    DescriptionFieldRequiredLabel.Visible = true;
                if (comboBox1.SelectedItem == null)
                    WeeklyLabel.Visible = true;
            }
            else
            {
                ProjectProfileWindow.Instance.ProjectProfileWindow_Clear();
//                ProjectProfileWindow.Instance.ProjectProfileWindow_Reload();
                //ProjectProfileWindow.Instance.ProjectProfileWindow_Reload(ProjectSelectWindow.Instance.SelectedItem);
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System" + "\\" + ProjectNameTextBox.Text + ".txt";
                if (!File.Exists(path))
                {
                    // create files and save data
                    SaveFile(path);

                    // set mandatory variables on profile
                    Project.Instance.SetInitialVariables(ProjectNameTextBox.Text, ProjectManagerTextBox.Text, DescriptionTextBox.Text, comboBox1.SelectedItem.ToString());
                    Project.Instance.SetOptionalVariables(TeamMembersListBox, RiskListBox);

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
                    //ProjectProfileWindow.Instance.ProjectProfileWindow_Reload();
                    //Set ProjectProfileWIndow and Taskbar text
                    //SetProjectProfilePage();
                }
                else if (File.Exists(path))
                {
                    return;
                }
            }
        }

        private void CancelSetupButton_Click(object sender, EventArgs e)
        {
            ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectSelectWindow.Instance);
            ProjectSelectWindow.Instance.BringToFront();
            InitialProjectSetupWindow.Instance.Refresh();
            InitialProjectSetupWindow_Clear();
        }

        private void InitialProjectSetupWindow_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetProjectProfilePage()
        {
            Taskbar.Instance.projectTitleControls.Text = Project.Instance.projectNameControls;
            ProjectProfileWindow.Instance.projecManagerControls.Text = Project.Instance.managerNameControls;
            ProjectProfileWindow.Instance.projecDescriptionControls.Text = Project.Instance.projectDescriptionControls;
            //adds Members list to page
            /*
            foreach (var item in Project.Instance.projectMembersControl)
            {
                ProjectProfileWindow.Instance.teamMemberListControls.Items.Add(item);
            }
            //adds Risks list to page
            foreach (var item in Project.Instance.projectRiskControl)
            {
                ProjectProfileWindow.Instance.RiskListControls.Items.Add(item);
            }
            */

        }


        private void SaveFile(String path)  //Saves edited data to the file. This needs to be replaced by the Project.cs -> RewriteFile function somewhow.
        {
            File.Create(path).Close();
            using (TextWriter tw = new StreamWriter(path, true))
            {

                String s = "";
                tw.WriteLine(ProjectNameTextBox.Text);
                tw.WriteLine(ProjectManagerTextBox.Text);
                tw.WriteLine(DescriptionTextBox.Text);
                foreach (var item in TeamMembersListBox.Items)
                {
                    s += item.ToString() + " *@* ";
                }
                tw.WriteLine(s);
                s = "";
                foreach (var item in RiskListBox.Items)
                {
                    s += item.ToString() + " *@* ";
                }
                tw.WriteLine(s);
                if (comboBox1.SelectedItem.ToString() == "Weekly")
                    tw.WriteLine("7");
                if (comboBox1.SelectedItem.ToString() == "Daily")
                    tw.WriteLine("1");
                tw.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamMembersListBox.Items.Remove(TeamMembersListBox.SelectedItem);
            TeamRemoveButton.Enabled = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void RisksRemoveButton_Click(object sender, EventArgs e)
        {
            RiskListBox.Items.Remove(RiskListBox.SelectedItem);
            RisksRemoveButton.Enabled = false;
        }

        public void InitialProjectSetupWindow_Clear()
        {
            ProjectManagerTextBox.Text = "";
            ProjectNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            comboBox1.Text = "";
            TeamMembersListBox.Items.Clear();
            RiskListBox.Items.Clear();
            
        }
    }
}
