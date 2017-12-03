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
    public partial class Taskbar : UserControl
    {
        public Taskbar()
        {
            InitializeComponent();
        }
        private static Taskbar _instance;

        public static Taskbar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Taskbar();
                return _instance;
            }
        }
        public Label projectTitleControls
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {

        }

        private void ProjectEffort_Click(object sender, EventArgs e)
        {
            ProjectEffortManagement.Instance.BringToFront();
        }

        private void ProjectProfileButton_Click(object sender, EventArgs e)
        {
            ProjectProfileWindow.Instance.BringToFront();
        }

        private void ProjectSelectButton_Click(object sender, EventArgs e)
        {
            // loads the project select page
            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectSelectWindow.Instance))
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectSelectWindow.Instance);
                ProjectSelectWindow.Instance.Dock = DockStyle.Fill;
                ProjectSelectWindow.Instance.BringToFront();
            }
            else
            {
                ProjectSelectWindow.Instance.BringToFront();
            }
        }
    }
}
