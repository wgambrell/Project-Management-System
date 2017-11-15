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
    public partial class ProjectEffortManagement : UserControl
    {
        public ProjectEffortManagement()
        {
            InitializeComponent();
        }
        private static ProjectEffortManagement _instance;

        public static ProjectEffortManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectEffortManagement();
                return _instance;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
