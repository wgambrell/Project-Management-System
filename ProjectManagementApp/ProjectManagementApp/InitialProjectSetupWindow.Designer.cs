namespace ProjectManagementApp
{
    partial class InitialProjectSetupWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddRiskTextBox = new System.Windows.Forms.TextBox();
            this.TeamMemberNewInputBox = new System.Windows.Forms.TextBox();
            this.ProjectManagerTextBox = new System.Windows.Forms.TextBox();
            this.AddRiskButton = new System.Windows.Forms.Button();
            this.CancelSetupButton = new System.Windows.Forms.Button();
            this.FinishSetupButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RiskListBox = new System.Windows.Forms.ListBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Initial Project Setup";
            // 
            // AddRiskTextBox
            // 
            this.AddRiskTextBox.Location = new System.Drawing.Point(281, 334);
            this.AddRiskTextBox.Name = "AddRiskTextBox";
            this.AddRiskTextBox.Size = new System.Drawing.Size(373, 20);
            this.AddRiskTextBox.TabIndex = 39;
            this.AddRiskTextBox.TextChanged += new System.EventHandler(this.AddRiskTextBox_TextChanged);
            // 
            // TeamMemberNewInputBox
            // 
            this.TeamMemberNewInputBox.Location = new System.Drawing.Point(281, 177);
            this.TeamMemberNewInputBox.Name = "TeamMemberNewInputBox";
            this.TeamMemberNewInputBox.Size = new System.Drawing.Size(230, 20);
            this.TeamMemberNewInputBox.TabIndex = 38;
            this.TeamMemberNewInputBox.TextChanged += new System.EventHandler(this.TeamMemberNewInputBox_TextChanged);
            // 
            // ProjectManagerTextBox
            // 
            this.ProjectManagerTextBox.Location = new System.Drawing.Point(26, 127);
            this.ProjectManagerTextBox.Name = "ProjectManagerTextBox";
            this.ProjectManagerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectManagerTextBox.TabIndex = 37;
            this.ProjectManagerTextBox.TextChanged += new System.EventHandler(this.ProjectManagerTextBox_TextChanged);
            // 
            // AddRiskButton
            // 
            this.AddRiskButton.AccessibleName = "AddRiskButton";
            this.AddRiskButton.Location = new System.Drawing.Point(660, 333);
            this.AddRiskButton.Name = "AddRiskButton";
            this.AddRiskButton.Size = new System.Drawing.Size(75, 23);
            this.AddRiskButton.TabIndex = 36;
            this.AddRiskButton.Text = "Add Risk";
            this.AddRiskButton.UseVisualStyleBackColor = true;
            this.AddRiskButton.Click += new System.EventHandler(this.AddRiskButton_Click);
            // 
            // CancelSetupButton
            // 
            this.CancelSetupButton.AccessibleName = "CancelInitialSetupButton";
            this.CancelSetupButton.Location = new System.Drawing.Point(616, 361);
            this.CancelSetupButton.Name = "CancelSetupButton";
            this.CancelSetupButton.Size = new System.Drawing.Size(119, 48);
            this.CancelSetupButton.TabIndex = 35;
            this.CancelSetupButton.Text = "Cancel Setup";
            this.CancelSetupButton.UseVisualStyleBackColor = true;
            this.CancelSetupButton.Click += new System.EventHandler(this.CancelSetupButton_Click);
            // 
            // FinishSetupButton
            // 
            this.FinishSetupButton.AccessibleName = "EndSetupButton";
            this.FinishSetupButton.Location = new System.Drawing.Point(477, 361);
            this.FinishSetupButton.Name = "FinishSetupButton";
            this.FinishSetupButton.Size = new System.Drawing.Size(100, 48);
            this.FinishSetupButton.TabIndex = 34;
            this.FinishSetupButton.Text = "Finish Setup";
            this.FinishSetupButton.UseVisualStyleBackColor = true;
            this.FinishSetupButton.Click += new System.EventHandler(this.FinishSetupButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Risks";
            // 
            // RiskListBox
            // 
            this.RiskListBox.AccessibleName = "RiskList";
            this.RiskListBox.FormattingEnabled = true;
            this.RiskListBox.Location = new System.Drawing.Point(281, 232);
            this.RiskListBox.Name = "RiskListBox";
            this.RiskListBox.Size = new System.Drawing.Size(454, 95);
            this.RiskListBox.TabIndex = 32;
            this.RiskListBox.SelectedIndexChanged += new System.EventHandler(this.RiskListBox_SelectedIndexChanged);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.AccessibleName = "AddMemberButton";
            this.AddMemberButton.Location = new System.Drawing.Point(517, 174);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(75, 23);
            this.AddMemberButton.TabIndex = 31;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "TeamMembersLabel";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Team Members";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.AccessibleName = "TeamMembersList";
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.Location = new System.Drawing.Point(281, 75);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(120, 95);
            this.TeamMembersListBox.TabIndex = 29;
            this.TeamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMembersListBox_SelectedIndexChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AccessibleName = "DescriptionTextbox";
            this.DescriptionTextBox.Location = new System.Drawing.Point(26, 199);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(226, 96);
            this.DescriptionTextBox.TabIndex = 28;
            this.DescriptionTextBox.Text = "";
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Project Manager";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.AccessibleName = "ProjectNameTextBox";
            this.ProjectNameTextBox.Location = new System.Drawing.Point(26, 75);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectNameTextBox.TabIndex = 25;
            this.ProjectNameTextBox.TextChanged += new System.EventHandler(this.ProjectNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Project Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InitialProjectSetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddRiskTextBox);
            this.Controls.Add(this.TeamMemberNewInputBox);
            this.Controls.Add(this.ProjectManagerTextBox);
            this.Controls.Add(this.AddRiskButton);
            this.Controls.Add(this.CancelSetupButton);
            this.Controls.Add(this.FinishSetupButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RiskListBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "InitialProjectSetupWindow";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.InitialProjectSetupWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddRiskTextBox;
        private System.Windows.Forms.TextBox TeamMemberNewInputBox;
        private System.Windows.Forms.TextBox ProjectManagerTextBox;
        private System.Windows.Forms.Button AddRiskButton;
        private System.Windows.Forms.Button CancelSetupButton;
        private System.Windows.Forms.Button FinishSetupButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox RiskListBox;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}
