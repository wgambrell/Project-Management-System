namespace ProjectManagementApp
{
    partial class ProjectManagementSystem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TaskbarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 728);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(1200, 30);
            this.TaskbarPanel.TabIndex = 1;
            this.TaskbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskbarPanel_Paint);
            // 
            // ProjectManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.TaskbarPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "ProjectManagementSystem";
            this.Text = "ProjectManagementSystem";
            this.Load += new System.EventHandler(this.ProjectManagementSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TaskbarPanel;
    }
}