namespace ProjectManagementApp
{
    partial class ProjectEditWindow
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
            this.label6 = new System.Windows.Forms.Label();
            this.NonfunctionalRequirementsListBox = new System.Windows.Forms.ListBox();
            this.FunctionalRequirementsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RiskListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectLeaderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.AddFunctionalRequirementTextBox = new System.Windows.Forms.TextBox();
            this.AddNonFunctRequirement = new System.Windows.Forms.TextBox();
            this.AddFuncReqButton = new System.Windows.Forms.Button();
            this.AddNonFunctReqButton = new System.Windows.Forms.Button();
            this.AddTeamMemberTextBox = new System.Windows.Forms.TextBox();
            this.AddTeamMemberButton = new System.Windows.Forms.Button();
            this.AddRiskTextBox = new System.Windows.Forms.TextBox();
            this.AddRisksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Non-Functional Requirements";
            // 
            // NonfunctionalRequirementsListBox
            // 
            this.NonfunctionalRequirementsListBox.FormattingEnabled = true;
            this.NonfunctionalRequirementsListBox.Location = new System.Drawing.Point(622, 360);
            this.NonfunctionalRequirementsListBox.Name = "NonfunctionalRequirementsListBox";
            this.NonfunctionalRequirementsListBox.Size = new System.Drawing.Size(506, 173);
            this.NonfunctionalRequirementsListBox.TabIndex = 26;
            this.NonfunctionalRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.NonfunctionalRequirementsListBox_SelectedIndexChanged);
            // 
            // FunctionalRequirementsListBox
            // 
            this.FunctionalRequirementsListBox.FormattingEnabled = true;
            this.FunctionalRequirementsListBox.Location = new System.Drawing.Point(622, 116);
            this.FunctionalRequirementsListBox.Name = "FunctionalRequirementsListBox";
            this.FunctionalRequirementsListBox.Size = new System.Drawing.Size(506, 173);
            this.FunctionalRequirementsListBox.TabIndex = 25;
            this.FunctionalRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.FunctionalRequirementsListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Functional Requirements";
            // 
            // RiskListBox
            // 
            this.RiskListBox.FormattingEnabled = true;
            this.RiskListBox.Location = new System.Drawing.Point(75, 447);
            this.RiskListBox.Name = "RiskListBox";
            this.RiskListBox.Size = new System.Drawing.Size(364, 147);
            this.RiskListBox.TabIndex = 23;
            this.RiskListBox.SelectedIndexChanged += new System.EventHandler(this.RiskListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Project Risks";
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.Location = new System.Drawing.Point(75, 260);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(364, 147);
            this.TeamMemberListBox.TabIndex = 21;
            this.TeamMemberListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMemberListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Team Members";
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(75, 116);
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(364, 96);
            this.ProjectDescriptionTextBox.TabIndex = 19;
            this.ProjectDescriptionTextBox.Text = "ProjectDescription";
            this.ProjectDescriptionTextBox.TextChanged += new System.EventHandler(this.ProjectDescriptionTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Project Description";
            // 
            // ProjectLeaderTextBox
            // 
            this.ProjectLeaderTextBox.Location = new System.Drawing.Point(75, 48);
            this.ProjectLeaderTextBox.Name = "ProjectLeaderTextBox";
            this.ProjectLeaderTextBox.Size = new System.Drawing.Size(364, 20);
            this.ProjectLeaderTextBox.TabIndex = 17;
            this.ProjectLeaderTextBox.Text = "ProjectLeader";
            this.ProjectLeaderTextBox.TextChanged += new System.EventHandler(this.ProjectLeaderTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Project Leader";
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(936, 612);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(137, 58);
            this.SaveProfileButton.TabIndex = 15;
            this.SaveProfileButton.Text = "Finish Editing";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            // 
            // AddFunctionalRequirementTextBox
            // 
            this.AddFunctionalRequirementTextBox.Location = new System.Drawing.Point(622, 295);
            this.AddFunctionalRequirementTextBox.Name = "AddFunctionalRequirementTextBox";
            this.AddFunctionalRequirementTextBox.Size = new System.Drawing.Size(463, 20);
            this.AddFunctionalRequirementTextBox.TabIndex = 28;
            this.AddFunctionalRequirementTextBox.Text = "Add Functional Requirement";
            // 
            // AddNonFunctRequirement
            // 
            this.AddNonFunctRequirement.Location = new System.Drawing.Point(622, 539);
            this.AddNonFunctRequirement.Name = "AddNonFunctRequirement";
            this.AddNonFunctRequirement.Size = new System.Drawing.Size(463, 20);
            this.AddNonFunctRequirement.TabIndex = 29;
            this.AddNonFunctRequirement.Text = "Add Non-Functional Requirement";
            // 
            // AddFuncReqButton
            // 
            this.AddFuncReqButton.Location = new System.Drawing.Point(1091, 292);
            this.AddFuncReqButton.Name = "AddFuncReqButton";
            this.AddFuncReqButton.Size = new System.Drawing.Size(37, 23);
            this.AddFuncReqButton.TabIndex = 30;
            this.AddFuncReqButton.Text = "Add";
            this.AddFuncReqButton.UseVisualStyleBackColor = true;
            // 
            // AddNonFunctReqButton
            // 
            this.AddNonFunctReqButton.Location = new System.Drawing.Point(1091, 536);
            this.AddNonFunctReqButton.Name = "AddNonFunctReqButton";
            this.AddNonFunctReqButton.Size = new System.Drawing.Size(37, 23);
            this.AddNonFunctReqButton.TabIndex = 31;
            this.AddNonFunctReqButton.Text = "Add";
            this.AddNonFunctReqButton.UseVisualStyleBackColor = true;
            // 
            // AddTeamMemberTextBox
            // 
            this.AddTeamMemberTextBox.Location = new System.Drawing.Point(75, 413);
            this.AddTeamMemberTextBox.Name = "AddTeamMemberTextBox";
            this.AddTeamMemberTextBox.Size = new System.Drawing.Size(301, 20);
            this.AddTeamMemberTextBox.TabIndex = 32;
            this.AddTeamMemberTextBox.Text = "Add Team Meber";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.Location = new System.Drawing.Point(402, 413);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(37, 23);
            this.AddTeamMemberButton.TabIndex = 33;
            this.AddTeamMemberButton.Text = "Add";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddRiskTextBox
            // 
            this.AddRiskTextBox.Location = new System.Drawing.Point(75, 600);
            this.AddRiskTextBox.Name = "AddRiskTextBox";
            this.AddRiskTextBox.Size = new System.Drawing.Size(301, 20);
            this.AddRiskTextBox.TabIndex = 34;
            this.AddRiskTextBox.Text = "Add Risk";
            // 
            // AddRisksButton
            // 
            this.AddRisksButton.Location = new System.Drawing.Point(402, 597);
            this.AddRisksButton.Name = "AddRisksButton";
            this.AddRisksButton.Size = new System.Drawing.Size(37, 23);
            this.AddRisksButton.TabIndex = 35;
            this.AddRisksButton.Text = "Add";
            this.AddRisksButton.UseVisualStyleBackColor = true;
            // 
            // ProjectEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddRisksButton);
            this.Controls.Add(this.AddRiskTextBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.AddTeamMemberTextBox);
            this.Controls.Add(this.AddNonFunctReqButton);
            this.Controls.Add(this.AddFuncReqButton);
            this.Controls.Add(this.AddNonFunctRequirement);
            this.Controls.Add(this.AddFunctionalRequirementTextBox);
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
            this.Controls.Add(this.SaveProfileButton);
            this.Name = "ProjectEditWindow";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ProjectEditWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox NonfunctionalRequirementsListBox;
        private System.Windows.Forms.ListBox FunctionalRequirementsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RiskListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectLeaderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.TextBox AddFunctionalRequirementTextBox;
        private System.Windows.Forms.TextBox AddNonFunctRequirement;
        private System.Windows.Forms.Button AddFuncReqButton;
        private System.Windows.Forms.Button AddNonFunctReqButton;
        private System.Windows.Forms.TextBox AddTeamMemberTextBox;
        private System.Windows.Forms.Button AddTeamMemberButton;
        private System.Windows.Forms.TextBox AddRiskTextBox;
        private System.Windows.Forms.Button AddRisksButton;
    }
}
