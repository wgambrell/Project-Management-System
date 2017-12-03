namespace ProjectManagementApp
{
    partial class ProjectEffortManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalHourslb = new System.Windows.Forms.Label();
            this.CurrentDatalabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportType = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1080, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Effort Hours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Hours:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalHourslb
            // 
            this.TotalHourslb.AutoSize = true;
            this.TotalHourslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHourslb.Location = new System.Drawing.Point(252, 27);
            this.TotalHourslb.Name = "TotalHourslb";
            this.TotalHourslb.Size = new System.Drawing.Size(18, 20);
            this.TotalHourslb.TabIndex = 5;
            this.TotalHourslb.Text = "0";
            this.TotalHourslb.Click += new System.EventHandler(this.label2_Click);
            // 
            // CurrentDatalabel
            // 
            this.CurrentDatalabel.AutoSize = true;
            this.CurrentDatalabel.Location = new System.Drawing.Point(674, 366);
            this.CurrentDatalabel.Name = "CurrentDatalabel";
            this.CurrentDatalabel.Size = new System.Drawing.Size(84, 13);
            this.CurrentDatalabel.TabIndex = 6;
            this.CurrentDatalabel.Text = "Date Goes Here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current day:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.AutoScroll = true;
            this.PanelContainer.AutoSize = true;
            this.PanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContainer.Location = new System.Drawing.Point(129, 357);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(0, 0);
            this.PanelContainer.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(129, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 251);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1080, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove Last Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(129, 50);
            this.PieChart.Name = "PieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(462, 300);
            this.PieChart.TabIndex = 13;
            this.PieChart.Text = "chart1";
            // 
            // reportType
            // 
            this.reportType.AutoSize = true;
            this.reportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportType.Location = new System.Drawing.Point(126, 362);
            this.reportType.Name = "reportType";
            this.reportType.Size = new System.Drawing.Size(116, 18);
            this.reportType.TabIndex = 14;
            this.reportType.Text = "Date Goes Here";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(808, 310);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(45, 16);
            this.warningLabel.TabIndex = 15;
            this.warningLabel.Text = "label2";
            // 
            // ProjectEffortManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.reportType);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentDatalabel);
            this.Controls.Add(this.TotalHourslb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ProjectEffortManagement";
            this.Size = new System.Drawing.Size(1200, 728);
            this.Load += new System.EventHandler(this.ProjectEffortManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalHourslb;
        private System.Windows.Forms.Label CurrentDatalabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Label reportType;
        private System.Windows.Forms.Label warningLabel;
    }
}
