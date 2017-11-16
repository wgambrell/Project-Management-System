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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProjectNameFieldRequiredLabel = new System.Windows.Forms.Label();
            this.ManagerFieldRequiredLabel = new System.Windows.Forms.Label();
            this.DescriptionFieldRequiredLabel = new System.Windows.Forms.Label();
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
            this.TeamMembersListBox.Size = new System.Drawing.Size(454, 95);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Weekly",
            "Daily"});
            this.comboBox1.Location = new System.Drawing.Point(26, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Text = "Weekly/Daily";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Select a timeframe for making updates";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(132, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(132, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(93, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(22, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "* Must be filled in to continue";
            // 
            // ProjectNameFieldRequiredLabel
            // 
            this.ProjectNameFieldRequiredLabel.AutoSize = true;
            this.ProjectNameFieldRequiredLabel.Location = new System.Drawing.Point(153, 78);
            this.ProjectNameFieldRequiredLabel.Name = "ProjectNameFieldRequiredLabel";
            this.ProjectNameFieldRequiredLabel.Size = new System.Drawing.Size(85, 13);
            this.ProjectNameFieldRequiredLabel.TabIndex = 46;
            this.ProjectNameFieldRequiredLabel.Text = "Field is Required";
            this.ProjectNameFieldRequiredLabel.Visible = false;
            // 
            // ManagerFieldRequiredLabel
            // 
            this.ManagerFieldRequiredLabel.AutoSize = true;
            this.ManagerFieldRequiredLabel.Location = new System.Drawing.Point(148, 127);
            this.ManagerFieldRequiredLabel.Name = "ManagerFieldRequiredLabel";
            this.ManagerFieldRequiredLabel.Size = new System.Drawing.Size(85, 13);
            this.ManagerFieldRequiredLabel.TabIndex = 47;
            this.ManagerFieldRequiredLabel.Text = "Field is Required";
            this.ManagerFieldRequiredLabel.Visible = false;
            // 
            // DescriptionFieldRequiredLabel
            // 
            this.DescriptionFieldRequiredLabel.AutoSize = true;
            this.DescriptionFieldRequiredLabel.Location = new System.Drawing.Point(148, 178);
            this.DescriptionFieldRequiredLabel.Name = "DescriptionFieldRequiredLabel";
            this.DescriptionFieldRequiredLabel.Size = new System.Drawing.Size(85, 13);
            this.DescriptionFieldRequiredLabel.TabIndex = 48;
            this.DescriptionFieldRequiredLabel.Text = "Field is Required";
            this.DescriptionFieldRequiredLabel.Visible = false;
            // 
            // InitialProjectSetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescriptionFieldRequiredLabel);
            this.Controls.Add(this.ManagerFieldRequiredLabel);
            this.Controls.Add(this.ProjectNameFieldRequiredLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ProjectNameFieldRequiredLabel;
        private System.Windows.Forms.Label ManagerFieldRequiredLabel;
        private System.Windows.Forms.Label DescriptionFieldRequiredLabel;
    }
}
