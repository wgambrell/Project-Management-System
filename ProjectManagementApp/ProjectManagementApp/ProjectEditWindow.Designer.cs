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
            this.label5 = new System.Windows.Forms.Label();
            this.RiskListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamMemberListBox1 = new System.Windows.Forms.ListBox();
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
            this.RemoveFuncReq = new System.Windows.Forms.Button();
            this.RemoveNonFuncReq = new System.Windows.Forms.Button();
            this.FunctionalReqListBox = new System.Windows.Forms.ListBox();
            this.NonFunctionalReqListBox = new System.Windows.Forms.ListBox();
            this.RemoveTeamMemberButton = new System.Windows.Forms.Button();
            this.RemoveRiskButton = new System.Windows.Forms.Button();
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
            this.RiskListBox.Location = new System.Drawing.Point(75, 482);
            this.RiskListBox.Name = "RiskListBox";
            this.RiskListBox.Size = new System.Drawing.Size(364, 147);
            this.RiskListBox.TabIndex = 23;
            this.RiskListBox.SelectedIndexChanged += new System.EventHandler(this.RiskListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Project Risks";
            // 
            // TeamMemberListBox1
            // 
            this.TeamMemberListBox1.FormattingEnabled = true;
            this.TeamMemberListBox1.Location = new System.Drawing.Point(75, 260);
            this.TeamMemberListBox1.Name = "TeamMemberListBox1";
            this.TeamMemberListBox1.Size = new System.Drawing.Size(364, 147);
            this.TeamMemberListBox1.TabIndex = 21;
            this.TeamMemberListBox1.SelectedIndexChanged += new System.EventHandler(this.TeamMemberListBox_SelectedIndexChanged);
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
            this.ProjectLeaderTextBox.Size = new System.Drawing.Size(301, 20);
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
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // AddFunctionalRequirementTextBox
            // 
            this.AddFunctionalRequirementTextBox.Location = new System.Drawing.Point(622, 295);
            this.AddFunctionalRequirementTextBox.Name = "AddFunctionalRequirementTextBox";
            this.AddFunctionalRequirementTextBox.Size = new System.Drawing.Size(346, 20);
            this.AddFunctionalRequirementTextBox.TabIndex = 28;
            this.AddFunctionalRequirementTextBox.Text = "Add Functional Requirement";
            // 
            // AddNonFunctRequirement
            // 
            this.AddNonFunctRequirement.Location = new System.Drawing.Point(622, 539);
            this.AddNonFunctRequirement.Name = "AddNonFunctRequirement";
            this.AddNonFunctRequirement.Size = new System.Drawing.Size(346, 20);
            this.AddNonFunctRequirement.TabIndex = 29;
            this.AddNonFunctRequirement.Text = "Add Non-Functional Requirement";
            // 
            // AddFuncReqButton
            // 
            this.AddFuncReqButton.Location = new System.Drawing.Point(986, 295);
            this.AddFuncReqButton.Name = "AddFuncReqButton";
            this.AddFuncReqButton.Size = new System.Drawing.Size(37, 23);
            this.AddFuncReqButton.TabIndex = 30;
            this.AddFuncReqButton.Text = "Add";
            this.AddFuncReqButton.UseVisualStyleBackColor = true;
            this.AddFuncReqButton.Click += new System.EventHandler(this.AddFuncReqButton_Click);
            // 
            // AddNonFunctReqButton
            // 
            this.AddNonFunctReqButton.Location = new System.Drawing.Point(986, 537);
            this.AddNonFunctReqButton.Name = "AddNonFunctReqButton";
            this.AddNonFunctReqButton.Size = new System.Drawing.Size(37, 23);
            this.AddNonFunctReqButton.TabIndex = 31;
            this.AddNonFunctReqButton.Text = "Add";
            this.AddNonFunctReqButton.UseVisualStyleBackColor = true;
            this.AddNonFunctReqButton.Click += new System.EventHandler(this.AddNonFunctReqButton_Click);
            // 
            // AddTeamMemberTextBox
            // 
            this.AddTeamMemberTextBox.Location = new System.Drawing.Point(75, 413);
            this.AddTeamMemberTextBox.Name = "AddTeamMemberTextBox";
            this.AddTeamMemberTextBox.Size = new System.Drawing.Size(267, 20);
            this.AddTeamMemberTextBox.TabIndex = 32;
            this.AddTeamMemberTextBox.Text = "Add Team Member";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.Location = new System.Drawing.Point(360, 413);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(37, 23);
            this.AddTeamMemberButton.TabIndex = 33;
            this.AddTeamMemberButton.Text = "Add";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            this.AddTeamMemberButton.Click += new System.EventHandler(this.AddTeamMemberButton_Click);
            // 
            // AddRiskTextBox
            // 
            this.AddRiskTextBox.Location = new System.Drawing.Point(75, 635);
            this.AddRiskTextBox.Name = "AddRiskTextBox";
            this.AddRiskTextBox.Size = new System.Drawing.Size(267, 20);
            this.AddRiskTextBox.TabIndex = 34;
            this.AddRiskTextBox.Text = "Add Risk";
            // 
            // AddRisksButton
            // 
            this.AddRisksButton.Location = new System.Drawing.Point(360, 630);
            this.AddRisksButton.Name = "AddRisksButton";
            this.AddRisksButton.Size = new System.Drawing.Size(37, 23);
            this.AddRisksButton.TabIndex = 35;
            this.AddRisksButton.Text = "Add";
            this.AddRisksButton.UseVisualStyleBackColor = true;
            this.AddRisksButton.Click += new System.EventHandler(this.AddRisksButton_Click);
            // 
            // RemoveFuncReq
            // 
            this.RemoveFuncReq.Enabled = false;
            this.RemoveFuncReq.Location = new System.Drawing.Point(1038, 295);
            this.RemoveFuncReq.Name = "RemoveFuncReq";
            this.RemoveFuncReq.Size = new System.Drawing.Size(109, 23);
            this.RemoveFuncReq.TabIndex = 38;
            this.RemoveFuncReq.Text = "Remove selected";
            this.RemoveFuncReq.UseVisualStyleBackColor = true;
            this.RemoveFuncReq.Click += new System.EventHandler(this.RemoveFuncReq_Click);
            // 
            // RemoveNonFuncReq
            // 
            this.RemoveNonFuncReq.Enabled = false;
            this.RemoveNonFuncReq.Location = new System.Drawing.Point(1038, 537);
            this.RemoveNonFuncReq.Name = "RemoveNonFuncReq";
            this.RemoveNonFuncReq.Size = new System.Drawing.Size(109, 23);
            this.RemoveNonFuncReq.TabIndex = 39;
            this.RemoveNonFuncReq.Text = "Remove selected";
            this.RemoveNonFuncReq.UseVisualStyleBackColor = true;
            this.RemoveNonFuncReq.Click += new System.EventHandler(this.RemoveNonFuncReq_Click);
            // 
            // FunctionalReqListBox
            // 
            this.FunctionalReqListBox.FormattingEnabled = true;
            this.FunctionalReqListBox.Location = new System.Drawing.Point(622, 116);
            this.FunctionalReqListBox.Name = "FunctionalReqListBox";
            this.FunctionalReqListBox.Size = new System.Drawing.Size(463, 160);
            this.FunctionalReqListBox.TabIndex = 41;
            this.FunctionalReqListBox.SelectedIndexChanged += new System.EventHandler(this.FunctionalReqListBox_SelectedIndexChanged);
            // 
            // NonFunctionalReqListBox
            // 
            this.NonFunctionalReqListBox.FormattingEnabled = true;
            this.NonFunctionalReqListBox.Location = new System.Drawing.Point(622, 368);
            this.NonFunctionalReqListBox.Name = "NonFunctionalReqListBox";
            this.NonFunctionalReqListBox.Size = new System.Drawing.Size(463, 160);
            this.NonFunctionalReqListBox.TabIndex = 42;
            this.NonFunctionalReqListBox.SelectedIndexChanged += new System.EventHandler(this.NonFunctionalReqListBox_SelectedIndexChanged);
            // 
            // RemoveTeamMemberButton
            // 
            this.RemoveTeamMemberButton.Enabled = false;
            this.RemoveTeamMemberButton.Location = new System.Drawing.Point(403, 413);
            this.RemoveTeamMemberButton.Name = "RemoveTeamMemberButton";
            this.RemoveTeamMemberButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveTeamMemberButton.TabIndex = 43;
            this.RemoveTeamMemberButton.Text = "Remove selected";
            this.RemoveTeamMemberButton.UseVisualStyleBackColor = true;
            this.RemoveTeamMemberButton.Click += new System.EventHandler(this.RemoveTeamMemberButton_Click);
            // 
            // RemoveRiskButton
            // 
            this.RemoveRiskButton.Enabled = false;
            this.RemoveRiskButton.Location = new System.Drawing.Point(403, 630);
            this.RemoveRiskButton.Name = "RemoveRiskButton";
            this.RemoveRiskButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveRiskButton.TabIndex = 44;
            this.RemoveRiskButton.Text = "Remove selected";
            this.RemoveRiskButton.UseVisualStyleBackColor = true;
            this.RemoveRiskButton.Click += new System.EventHandler(this.RemoveRiskButton_Click);
            // 
            // ProjectEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveRiskButton);
            this.Controls.Add(this.RemoveTeamMemberButton);
            this.Controls.Add(this.NonFunctionalReqListBox);
            this.Controls.Add(this.FunctionalReqListBox);
            this.Controls.Add(this.RemoveNonFuncReq);
            this.Controls.Add(this.RemoveFuncReq);
            this.Controls.Add(this.AddRisksButton);
            this.Controls.Add(this.AddRiskTextBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.AddTeamMemberTextBox);
            this.Controls.Add(this.AddNonFunctReqButton);
            this.Controls.Add(this.AddFuncReqButton);
            this.Controls.Add(this.AddNonFunctRequirement);
            this.Controls.Add(this.AddFunctionalRequirementTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RiskListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeamMemberListBox1);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RiskListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TeamMemberListBox1;
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
        private System.Windows.Forms.Button RemoveFuncReq;
        private System.Windows.Forms.Button RemoveNonFuncReq;
        private System.Windows.Forms.ListBox FunctionalReqListBox;
        private System.Windows.Forms.ListBox NonFunctionalReqListBox;
        private System.Windows.Forms.Button RemoveTeamMemberButton;
        private System.Windows.Forms.Button RemoveRiskButton;
    }
}
