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
        private DateTime date = DateTime.Now;
        private Project pj = new Project();
        public int b;


        public ProjectEffortManagement()
        {
            InitializeComponent();
            b = 0;

            warningLabel.Text = "";

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

            //reportType.Text = Project.Instance.getDateType();
            CurrentDatalabel.Text = date.Month.ToString() + "/" + date.Day.ToString() + "/" + date.Year.ToString();


            PieChart.Series["Series1"].Points[0].SetValueXY("Management", 0);
            PieChart.Series["Series1"].Points[1].SetValueXY("Requirements", 0);
            PieChart.Series["Series1"].Points[2].SetValueXY("Design", 0);
            PieChart.Series["Series1"].Points[3].SetValueXY("Implementation", 0);
            PieChart.Series["Series1"].Points[4].SetValueXY("Testing", 0);

            //ProjectEffortManagement.Instance.clearAndFillTable();
            //ProjectEffortManagement.Instance.add();

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

        public Label totalLabel
        {
            get { return TotalHourslb; }
            set { TotalHourslb = value; }
        }

        public Label reportLabel
        {
            get { return reportType; }
            set { reportType = value; }
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
            DateTime date = DateTime.Now;
            if (Project.Instance.getEffortListSize() == 0)
            {
                OpenPopup();
                warningLabel.Text = "";
            }
            else if(Project.Instance.getLastEffort().timeControl.Day - date.Day < Project.Instance.getTimeInteger && Project.Instance.getEffortListSize() != 0)
            {
                int timeleft = Project.Instance.getLastEffort().timeControl.Day - date.Day + 7;
                if(Project.Instance.getTimeInteger == 1)
                {
                    warningLabel.Text = "You have to wait a day before adding an update";
                }
                else
                {
                  warningLabel.Text = "You have to wait " + timeleft + " days before adding an update";
                }
            }
            else
            {
                OpenPopup();
                warningLabel.Text = "";
            }
        }



        //Add a new row to the table display populated with the added effort information
        public void AddTableRow(int management, int requirements, int design, int implementation, int testing, DateTime stamp)
        {
            InfoTable2.RowCount++;
            InfoTable2.Height += 10;
            int location = InfoTable2.RowStyles.Count - 1;
            InfoTable2.RowStyles.Add( new RowStyle(SizeType.AutoSize, 20F));
            //b++;
            foreach (Control con in InfoTable2.Controls)
            {
                InfoTable2.SetRow(con, InfoTable2.GetRow(con) + 1);
            }


            InfoTable2.Controls.Add(new Label() { Text = "Date: \n" + stamp.Month +"/"+ stamp.Day + "/"+stamp.Year, Height = 40 }, 0, 0);
            InfoTable2.Controls.Add(new Label() { Text = "Management: \n" + management + " hrs", Height = 40 }, 1, 0);
            InfoTable2.Controls.Add(new Label() { Text = "Requirements: \n" + requirements + " hrs", Height = 40 }, 2, 0);
            InfoTable2.Controls.Add(new Label() { Text = "Design: \n" + design + " hrs", Height = 40 }, 3, 0);
            InfoTable2.Controls.Add(new Label() { Text = "Implementation: \n " + implementation + " hrs", Height = 40 }, 4, 0);
            InfoTable2.Controls.Add(new Label() { Text = "Testing: \n" + testing + " hrs", Height = 40 }, 5, 0);

            button2.Enabled = true;
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
        public void ProjectEditManagement_Clear()
        {
            InfoTable2.Controls.Clear();
            PieChart.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoTable2.ColumnCount; i++)
            {
                var control = InfoTable2.GetControlFromPosition(i, 0);
                InfoTable2.Controls.Remove(control);
            }
            Project.Instance.removeLastEffort();

            for (int i =  1; i < InfoTable2.RowCount; i++)
            {
                for (int k = 0; k < InfoTable2.ColumnCount; k++)
                {
                    var control = InfoTable2.GetControlFromPosition(k, i);
                    if (control != null)
                    {
                        InfoTable2.SetRow(control, i - 1);
                    }
                }
            }


            int[] temp = Project.Instance.getHours();
            updatePieChart(temp[0], temp[1], temp[2], temp[3], temp[4]);
            ProjectEffortManagement.Instance.totalLabel.Text = temp[5].ToString();

            InfoTable2.RowCount--;
            warningLabel.Text = "";

            if (pj.EffortListCount == 0)
            {
                button2.Enabled = false;
            }
            Project.Instance.RewriteFile();
        }

        public void OpenPopup()
        {
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


                DateTime time = DateTime.Now;
                ProjectEffortAddPopup.Instance.TimeLabel.Text = time.Month.ToString() + "/" + time.Day.ToString() + "/" + time.Year.ToString();

                //button2.Enabled = true;
        
        }

        // Updates the chart by erasing chart data and rebuilding the chart
        public void updatePieChart(int management, int requirements, int design, int implementation, int testing)
        {
            PieChart.Series.Clear();
            PieChart.Series.Add("Series1");
            PieChart.Series["Series1"].IsValueShownAsLabel = true;
            //PieChart.Series["Series1"].Label = "#PERCENT{0.00 %}";
           
            PieChart.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            PieChart.Series["Series1"].Points.Add(0);
            PieChart.Series["Series1"].Points[0].SetValueXY("Management: " + management + " hrs", management);
            PieChart.Series["Series1"].Points.Add(0);
            PieChart.Series["Series1"].Points[1].SetValueXY("Requirements: " + requirements + " hrs", requirements);
            PieChart.Series["Series1"].Points.Add(0);
            PieChart.Series["Series1"].Points[2].SetValueXY("Design: " + design + " hrs", design);
            PieChart.Series["Series1"].Points.Add(0);
            PieChart.Series["Series1"].Points[3].SetValueXY("Implementation: " + implementation + " hrs", implementation);
            PieChart.Series["Series1"].Points.Add(0);
            PieChart.Series["Series1"].Points[4].SetValueXY("Testing: " + testing + " hrs", testing);
            PieChart.Update(); 
        }
        public void clearAndFillTable()
        {
           
            for (int i = 0; i < InfoTable2.RowCount; i++)
            {
                for (int j = 0; j < InfoTable2.ColumnCount; j++)
                {
                    var control = InfoTable2.GetControlFromPosition(j, i);
                    InfoTable2.Controls.Remove(control);
                   
                }
            }
            int b = InfoTable2.RowCount;
            for (int i = 0; i < b - 1; i++)
            {
                InfoTable2.RowCount--;
            }

                add();

        }
        public void add()
        {
            List<Effort> listtemp = Project.Instance.EffortControl;
            for (int i = 0; i < listtemp.Count ; i++)
            {
                AddTableRow(listtemp[i].getcategory[0], listtemp[i].getcategory[1], listtemp[i].getcategory[2], listtemp[i].getcategory[3], listtemp[i].getcategory[4], listtemp[i].timeControl);
            }
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
