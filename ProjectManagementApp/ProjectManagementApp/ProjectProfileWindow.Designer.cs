namespace ProjectManagementApp
{
    partial class ProjectProfileWindow
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
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectLeaderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RiskListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FunctionalRequirementsListBox = new System.Windows.Forms.ListBox();
            this.NonfunctionalRequirementsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Location = new System.Drawing.Point(900, 610);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(137, 58);
            this.EditProfileButton.TabIndex = 1;
            this.EditProfileButton.Text = "Edit Project";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Leader";
            // 
            // ProjectLeaderTextBox
            // 
            this.ProjectLeaderTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProjectLeaderTextBox.Location = new System.Drawing.Point(39, 46);
            this.ProjectLeaderTextBox.Name = "ProjectLeaderTextBox";
            this.ProjectLeaderTextBox.ReadOnly = true;
            this.ProjectLeaderTextBox.Size = new System.Drawing.Size(364, 20);
            this.ProjectLeaderTextBox.TabIndex = 3;
            this.ProjectLeaderTextBox.Text = "ProjectLeader";
            this.ProjectLeaderTextBox.TextChanged += new System.EventHandler(this.ProjectLeaderTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(39, 114);
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.ReadOnly = true;
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(364, 96);
            this.ProjectDescriptionTextBox.TabIndex = 6;
            this.ProjectDescriptionTextBox.Text = "ProjectDescription";
            this.ProjectDescriptionTextBox.TextChanged += new System.EventHandler(this.ProjectDescriptionTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Team Members";
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.Location = new System.Drawing.Point(39, 258);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(364, 147);
            this.TeamMemberListBox.TabIndex = 8;
            this.TeamMemberListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMemberListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project Risks";
            // 
            // RiskListBox
            // 
            this.RiskListBox.FormattingEnabled = true;
            this.RiskListBox.Location = new System.Drawing.Point(39, 445);
            this.RiskListBox.Name = "RiskListBox";
            this.RiskListBox.Size = new System.Drawing.Size(364, 147);
            this.RiskListBox.TabIndex = 10;
            this.RiskListBox.SelectedIndexChanged += new System.EventHandler(this.RiskListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Functional Requirements";
            // 
            // FunctionalRequirementsListBox
            // 
            this.FunctionalRequirementsListBox.FormattingEnabled = true;
            this.FunctionalRequirementsListBox.Location = new System.Drawing.Point(586, 114);
            this.FunctionalRequirementsListBox.Name = "FunctionalRequirementsListBox";
            this.FunctionalRequirementsListBox.Size = new System.Drawing.Size(506, 173);
            this.FunctionalRequirementsListBox.TabIndex = 12;
            this.FunctionalRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.FunctionalRequirementsListBox_SelectedIndexChanged);
            // 
            // NonfunctionalRequirementsListBox
            // 
            this.NonfunctionalRequirementsListBox.FormattingEnabled = true;
            this.NonfunctionalRequirementsListBox.Location = new System.Drawing.Point(586, 358);
            this.NonfunctionalRequirementsListBox.Name = "NonfunctionalRequirementsListBox";
            this.NonfunctionalRequirementsListBox.Size = new System.Drawing.Size(506, 173);
            this.NonfunctionalRequirementsListBox.TabIndex = 13;
            this.NonfunctionalRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.NonfunctionalRequirementsListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Non-Functional Requirements";
            // 
            // ProjectProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NonfunctionalRequirementsListBox);
            this.Controls.Add(this.FunctionalRequirementsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RiskListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectLeaderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditProfileButton);
            this.Name = "ProjectProfileWindow";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ProjectProfileWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectLeaderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox RiskListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox FunctionalRequirementsListBox;
        private System.Windows.Forms.ListBox NonfunctionalRequirementsListBox;
        private System.Windows.Forms.Label label6;
    }
}
