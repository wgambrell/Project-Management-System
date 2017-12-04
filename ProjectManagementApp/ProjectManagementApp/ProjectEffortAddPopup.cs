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
    public partial class ProjectEffortAddPopup : UserControl
    {
        //private DateTime date;
        private String currentTime;
        public ProjectEffortAddPopup()
        {
            InitializeComponent();
            
        }

        private static ProjectEffortAddPopup _instance;

        public static ProjectEffortAddPopup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectEffortAddPopup();
                return _instance;
            }
        }
        public Label TimeLabel
        {
            get { return SubmitDate; }
            set { SubmitDate = value; }
        }
        public void resetLabels()
        {
            ManagementTB.Text = "0";
            RequirementsTB.Text = "0";
            DesignTB.Text = "0";
            ImplemenationTB.Text = "0";
            TestingTB.Text = "0";

        }

        private void ProjectEffortAddPopup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectEffortManagement.Instance.BringToFront();
            resetLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int manage, req, des, imp, test;

            
            try
            {
                manage = Math.Abs(Int32.Parse(ManagementTB.Text));
                req = Math.Abs(Int32.Parse(RequirementsTB.Text));
                des = Math.Abs(Int32.Parse(DesignTB.Text));
                imp = Math.Abs(Int32.Parse(ImplemenationTB.Text));
                test = Math.Abs(Int32.Parse(TestingTB.Text));

                Effort ef = new Effort(manage, req, des, imp, test, date);
                Project.Instance.EffortControl.Add(ef);
                ProjectEffortManagement.Instance.AddTableRow(manage, req, des, imp, test, date);
                //DateTime data =  Project.Instance.EffortControl.Last<Effort>().timeControl;

                ProjectEffortManagement.Instance.BringToFront();
                resetLabels();
                int[] temp = Project.Instance.getHours();
                ProjectEffortManagement.Instance.updatePieChart(temp[0], temp[1], temp[2], temp[3], temp[4]);
                ProjectEffortManagement.Instance.totalLabel.Text = temp[5].ToString();
                InvalidValuesError.Enabled = false;
                InvalidValuesError.Visible = false;
                Project.Instance.RewriteFile();
            }
            catch(Exception ex)
            {
                InvalidValuesError.Enabled = true;
                InvalidValuesError.Visible = true;
                string error = ex.Message;
                Console.WriteLine(ex.Message);
                manage = 0;
                req = 0;
                des = 0;
                imp = 0;
                test = 0;
            }
        }
    }
}
