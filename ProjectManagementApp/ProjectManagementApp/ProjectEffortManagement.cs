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
        private TableLayoutPanel InfoTable2 = new TableLayoutPanel();
        private Panel temppanel = new Panel();
        public int b;


        public ProjectEffortManagement()
        {
            InitializeComponent();
            b = 0;


            
            InfoTable2.ColumnCount = 6;
            InfoTable2.RowCount = 100;
            InfoTable2.AutoSize = true;
            //InfoTable2.Dock = DockStyle.Left;
            InfoTable2.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            InfoTable2.AutoSizeMode = AutoSizeMode.GrowOnly;
            temppanel.AutoScroll = true;
            temppanel.Dock = DockStyle.Fill;
            temppanel.AutoSize = true;

            if (!panel1.Contains(temppanel))
            {
                panel1.Controls.Add(temppanel);
                temppanel.BringToFront();
            }
            else
                temppanel.BringToFront();


            if (!temppanel.Contains(InfoTable2))
            {
                temppanel.Controls.Add(InfoTable2);
                InfoTable2.BringToFront();
            }
            else
                InfoTable2.BringToFront();

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

        private void button1_Click(object sender, EventArgs e)
        {
            //int x = (ProjectManagementSystem.Instance.Panel1Control.Size. - label1.Size.Width) / 2;

            if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectEffortAddPopup.Instance))
            {
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectEffortAddPopup.Instance);
                ProjectEffortAddPopup.Instance.Location = new Point(300, 200);
                ProjectEffortAddPopup.Instance.Dock = DockStyle.None;
                ProjectEffortAddPopup.Instance.BringToFront();
            }
            else
            {
                ProjectEffortAddPopup.Instance.BringToFront();
            }

            InfoTable2.RowCount++;
            InfoTable2.Height += 10;
         
            InfoTable2.RowStyles.Add(new RowStyle(SizeType.AutoSize, 20F));
            b++;
            InfoTable2.Controls.Add(new Label() { Text = "Management, \n  State " + b , Height = 40 }, 0, InfoTable2.RowCount - 1);
            InfoTable2.Controls.Add(new Label() { Text = "Implementation" }, 1, InfoTable2.RowCount - 1);
            InfoTable2.Controls.Add(new Label() { Text = "Testing" }, 2, InfoTable2.RowCount - 1);
            

            DateTime time = DateTime.Now;
            ProjectEffortAddPopup.Instance.TimeLabel.Text = time.Day.ToString() + "/" + time.Month.ToString() + "/" + time.Year.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InfoTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectEffortManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
