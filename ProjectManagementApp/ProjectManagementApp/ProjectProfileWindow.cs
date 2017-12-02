using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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
        private void ProjectProfileWindow_Load(object sender, EventArgs e)  //populates all boxes with information of selected project. Only happens when the page loads. I need a way of CLOSING this page, so that this info re-populates every time this page opens.
        {                                                                   //ALTERNATIVELY, look at Project.cs->SetProfilePage. That can be called from ANYWHERE in this program as long as the project form is open. We may retire this method.
            ProjectLeaderTextBox.Text = Project.Instance.projectNameControls;
            ProjectDescriptionTextBox.Text = Project.Instance.projectDescriptionControls;
            ArrayList temp = new ArrayList();
            temp = Project.Instance.projectMembersControl;
            foreach (String s in temp)
            {
                TeamMemberListBox.Items.Add(s);
            }
            temp = Project.Instance.projectRiskControl;
            foreach(String s in temp)
            {
                RiskListBox.Items.Add(s);
            }
            temp = Project.Instance.FuncReqControl;
            foreach (String s in temp)
            {
                FunctionalRequirementsListBox.Items.Add(s);
            }
            temp = Project.Instance.NonFuncReqControl;
            foreach(String s in temp)
            {
                NonfunctionalRequirementsListBox.Items.Add(s);
            }

        }
        //ACCESSOR METHODS
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
        public ListBox funcRequirementsControls
        {
            get { return FunctionalRequirementsListBox; }
            set { FunctionalRequirementsListBox = value; }
        }

        public ListBox NonfuncRequirementsControls
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

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectEditWindow.Instance))  //Checks to see if an instance of this form is open, if not opens it.
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectEditWindow.Instance);    //Makes a new instance of ProjectEditWindow
                ProjectEditWindow.Instance.Dock = DockStyle.Fill;
                ProjectEditWindow.Instance.BringToFront();
                ProjectManagementSystem.Instance.Panel1Control.Controls.Remove(ProjectProfileWindow.Instance);  //Deletes this instance of ProjectProfileWindow

            }
            else
            {
                ProjectEditWindow.Instance.BringToFront();
            }

            // Sets basic values on edit page
            ProjectEditWindow.Instance.projecManagerControls.Text = ProjectLeaderTextBox.Text;
            ProjectEditWindow.Instance.projecDescriptionControls.Text = ProjectDescriptionTextBox.Text;
            // Sets values for lists - clearing to remove any danger of contamination
            ProjectEditWindow.Instance.teamMemberListControls.Items.Clear();
            ProjectEditWindow.Instance.RiskListControls.Items.Clear();
            ProjectEditWindow.Instance.FuncReqsListControls.Items.Clear();
            ProjectEditWindow.Instance.NonFuncReqsListControls.Items.Clear();

            foreach (var item in Project.Instance.projectMembersControl)
            {
                ProjectEditWindow.Instance.teamMemberListControls.Items.Add(item);
            }

            foreach (var item in Project.Instance.projectRiskControl)
            {
                ProjectEditWindow.Instance.RiskListControls.Items.Add(item);
            }
            foreach (var item in Project.Instance.FuncReqControl)
            {
                ProjectEditWindow.Instance.FuncReqsListControls.Items.Add(item);
            }
            foreach (var item in Project.Instance.NonFuncReqControl)
            {
                ProjectEditWindow.Instance.NonFuncReqsListControls.Items.Add(item);
            }
        }
    }
}
