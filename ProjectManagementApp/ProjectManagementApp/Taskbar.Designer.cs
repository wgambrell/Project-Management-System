namespace ProjectManagementApp
{
    partial class Taskbar
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
            this.ProjectSelectButton = new System.Windows.Forms.Button();
            this.ProjectProfileButton = new System.Windows.Forms.Button();
            this.ProjectEffort = new System.Windows.Forms.Button();
            this.ProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectSelectButton
            // 
            this.ProjectSelectButton.Location = new System.Drawing.Point(3, 0);
            this.ProjectSelectButton.Name = "ProjectSelectButton";
            this.ProjectSelectButton.Size = new System.Drawing.Size(144, 30);
            this.ProjectSelectButton.TabIndex = 0;
            this.ProjectSelectButton.Text = "Select Project";
            this.ProjectSelectButton.UseVisualStyleBackColor = true;
            this.ProjectSelectButton.Click += new System.EventHandler(this.ProjectSelectButton_Click);
            // 
            // ProjectProfileButton
            // 
            this.ProjectProfileButton.Location = new System.Drawing.Point(154, 0);
            this.ProjectProfileButton.Name = "ProjectProfileButton";
            this.ProjectProfileButton.Size = new System.Drawing.Size(173, 30);
            this.ProjectProfileButton.TabIndex = 1;
            this.ProjectProfileButton.Text = "Project Profile";
            this.ProjectProfileButton.UseVisualStyleBackColor = true;
            this.ProjectProfileButton.Click += new System.EventHandler(this.ProjectProfileButton_Click);
            // 
            // ProjectEffort
            // 
            this.ProjectEffort.Location = new System.Drawing.Point(334, 0);
            this.ProjectEffort.Name = "ProjectEffort";
            this.ProjectEffort.Size = new System.Drawing.Size(153, 30);
            this.ProjectEffort.TabIndex = 2;
            this.ProjectEffort.Text = "Project Effort";
            this.ProjectEffort.UseVisualStyleBackColor = true;
            this.ProjectEffort.Click += new System.EventHandler(this.ProjectEffort_Click);
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(585, 4);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 3;
            this.ProjectName.Text = "ProjectName";
            this.ProjectName.Click += new System.EventHandler(this.ProjectName_Click);
            // 
            // Taskbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ProjectEffort);
            this.Controls.Add(this.ProjectProfileButton);
            this.Controls.Add(this.ProjectSelectButton);
            this.Name = "Taskbar";
            this.Size = new System.Drawing.Size(1200, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProjectSelectButton;
        private System.Windows.Forms.Button ProjectProfileButton;
        private System.Windows.Forms.Button ProjectEffort;
        private System.Windows.Forms.Label ProjectName;
    }
}
