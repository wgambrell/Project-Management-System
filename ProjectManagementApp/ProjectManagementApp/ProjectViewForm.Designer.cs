namespace ProjectManagementApp
{
    partial class ProjectViewForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.RisksLabel = new System.Windows.Forms.Label();
            this.TeamMembersLabel = new System.Windows.Forms.Label();
            this.ProjectManagerTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProjectDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.RisksListBox = new System.Windows.Forms.ListBox();
            this.FunctionalReqsListBox = new System.Windows.Forms.ListBox();
            this.NonfuncReqsListBox = new System.Windows.Forms.ListBox();
            this.AddEffortButton = new System.Windows.Forms.Button();
            this.EditProjectInfoButton = new System.Windows.Forms.Button();
            this.BackToProjectSelectButton = new System.Windows.Forms.Button();
            this.AddNonfuncReqButton = new System.Windows.Forms.Button();
            this.AddFunctReqButton = new System.Windows.Forms.Button();
            this.DelSelNonFuncReqButton = new System.Windows.Forms.Button();
            this.DelSelFuncReqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjectName";
            // 
            // RisksLabel
            // 
            this.RisksLabel.AutoSize = true;
            this.RisksLabel.Location = new System.Drawing.Point(513, 36);
            this.RisksLabel.Name = "RisksLabel";
            this.RisksLabel.Size = new System.Drawing.Size(33, 13);
            this.RisksLabel.TabIndex = 4;
            this.RisksLabel.Text = "Risks";
            // 
            // TeamMembersLabel
            // 
            this.TeamMembersLabel.AutoSize = true;
            this.TeamMembersLabel.Location = new System.Drawing.Point(352, 36);
            this.TeamMembersLabel.Name = "TeamMembersLabel";
            this.TeamMembersLabel.Size = new System.Drawing.Size(80, 13);
            this.TeamMembersLabel.TabIndex = 6;
            this.TeamMembersLabel.Text = "Team Members";
            // 
            // ProjectManagerTextBox
            // 
            this.ProjectManagerTextBox.Location = new System.Drawing.Point(35, 53);
            this.ProjectManagerTextBox.Name = "ProjectManagerTextBox";
            this.ProjectManagerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectManagerTextBox.TabIndex = 7;
            this.ProjectManagerTextBox.Text = "ProjectManager";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(35, 96);
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(287, 82);
            this.ProjectDescriptionTextBox.TabIndex = 10;
            this.ProjectDescriptionTextBox.Text = "ProjectDescription";
            this.ProjectDescriptionTextBox.TextChanged += new System.EventHandler(this.ProjectDescriptionTextBox_TextChanged);
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.Location = new System.Drawing.Point(355, 57);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(120, 121);
            this.TeamMembersListBox.TabIndex = 11;
            this.TeamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMembersListBox_SelectedIndexChanged);
            // 
            // RisksListBox
            // 
            this.RisksListBox.FormattingEnabled = true;
            this.RisksListBox.Location = new System.Drawing.Point(516, 57);
            this.RisksListBox.Name = "RisksListBox";
            this.RisksListBox.Size = new System.Drawing.Size(120, 95);
            this.RisksListBox.TabIndex = 12;
            this.RisksListBox.SelectedIndexChanged += new System.EventHandler(this.RisksListBox_SelectedIndexChanged);
            // 
            // FunctionalReqsListBox
            // 
            this.FunctionalReqsListBox.FormattingEnabled = true;
            this.FunctionalReqsListBox.Location = new System.Drawing.Point(35, 212);
            this.FunctionalReqsListBox.Name = "FunctionalReqsListBox";
            this.FunctionalReqsListBox.Size = new System.Drawing.Size(346, 290);
            this.FunctionalReqsListBox.TabIndex = 13;
            this.FunctionalReqsListBox.SelectedIndexChanged += new System.EventHandler(this.FunctionalReqsListBox_SelectedIndexChanged);
            // 
            // NonfuncReqsListBox
            // 
            this.NonfuncReqsListBox.FormattingEnabled = true;
            this.NonfuncReqsListBox.Location = new System.Drawing.Point(387, 212);
            this.NonfuncReqsListBox.Name = "NonfuncReqsListBox";
            this.NonfuncReqsListBox.Size = new System.Drawing.Size(346, 290);
            this.NonfuncReqsListBox.TabIndex = 14;
            this.NonfuncReqsListBox.SelectedIndexChanged += new System.EventHandler(this.NonfuncReqsListBox_SelectedIndexChanged);
            // 
            // AddEffortButton
            // 
            this.AddEffortButton.Location = new System.Drawing.Point(268, 508);
            this.AddEffortButton.Name = "AddEffortButton";
            this.AddEffortButton.Size = new System.Drawing.Size(225, 40);
            this.AddEffortButton.TabIndex = 15;
            this.AddEffortButton.Text = "Add Effort(s)";
            this.AddEffortButton.UseVisualStyleBackColor = true;
            this.AddEffortButton.Click += new System.EventHandler(this.AddEffortButton_Click);
            // 
            // EditProjectInfoButton
            // 
            this.EditProjectInfoButton.Location = new System.Drawing.Point(35, 509);
            this.EditProjectInfoButton.Name = "EditProjectInfoButton";
            this.EditProjectInfoButton.Size = new System.Drawing.Size(227, 40);
            this.EditProjectInfoButton.TabIndex = 16;
            this.EditProjectInfoButton.Text = "Edit Project Information";
            this.EditProjectInfoButton.UseVisualStyleBackColor = true;
            this.EditProjectInfoButton.Click += new System.EventHandler(this.EditProjectInfoButton_Click);
            // 
            // BackToProjectSelectButton
            // 
            this.BackToProjectSelectButton.Location = new System.Drawing.Point(499, 508);
            this.BackToProjectSelectButton.Name = "BackToProjectSelectButton";
            this.BackToProjectSelectButton.Size = new System.Drawing.Size(234, 40);
            this.BackToProjectSelectButton.TabIndex = 17;
            this.BackToProjectSelectButton.Text = "Back To Project Select";
            this.BackToProjectSelectButton.UseVisualStyleBackColor = true;
            this.BackToProjectSelectButton.Click += new System.EventHandler(this.BackToProjectSelectButton_Click);
            // 
            // AddNonfuncReqButton
            // 
            this.AddNonfuncReqButton.Location = new System.Drawing.Point(387, 184);
            this.AddNonfuncReqButton.Name = "AddNonfuncReqButton";
            this.AddNonfuncReqButton.Size = new System.Drawing.Size(171, 23);
            this.AddNonfuncReqButton.TabIndex = 18;
            this.AddNonfuncReqButton.Text = "Add Nonfunctional Requirement";
            this.AddNonfuncReqButton.UseVisualStyleBackColor = true;
            this.AddNonfuncReqButton.Click += new System.EventHandler(this.AddNonfuncReqButton_Click);
            // 
            // AddFunctReqButton
            // 
            this.AddFunctReqButton.Location = new System.Drawing.Point(35, 184);
            this.AddFunctReqButton.Name = "AddFunctReqButton";
            this.AddFunctReqButton.Size = new System.Drawing.Size(161, 23);
            this.AddFunctReqButton.TabIndex = 19;
            this.AddFunctReqButton.Text = "Add Functional Requirement";
            this.AddFunctReqButton.UseVisualStyleBackColor = true;
            this.AddFunctReqButton.Click += new System.EventHandler(this.AddFunctReqButton_Click);
            // 
            // DelSelNonFuncReqButton
            // 
            this.DelSelNonFuncReqButton.Location = new System.Drawing.Point(564, 184);
            this.DelSelNonFuncReqButton.Name = "DelSelNonFuncReqButton";
            this.DelSelNonFuncReqButton.Size = new System.Drawing.Size(171, 23);
            this.DelSelNonFuncReqButton.TabIndex = 20;
            this.DelSelNonFuncReqButton.Text = "Delete Requirement";
            this.DelSelNonFuncReqButton.UseVisualStyleBackColor = true;
            this.DelSelNonFuncReqButton.Click += new System.EventHandler(this.DelSelNonFuncReqButton_Click);
            // 
            // DelSelFuncReqButton
            // 
            this.DelSelFuncReqButton.Location = new System.Drawing.Point(202, 184);
            this.DelSelFuncReqButton.Name = "DelSelFuncReqButton";
            this.DelSelFuncReqButton.Size = new System.Drawing.Size(178, 23);
            this.DelSelFuncReqButton.TabIndex = 21;
            this.DelSelFuncReqButton.Text = "Delete Requirement";
            this.DelSelFuncReqButton.UseVisualStyleBackColor = true;
            this.DelSelFuncReqButton.Click += new System.EventHandler(this.DelSelFuncReqButton_Click);
            // 
            // ProjectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DelSelFuncReqButton);
            this.Controls.Add(this.DelSelNonFuncReqButton);
            this.Controls.Add(this.AddFunctReqButton);
            this.Controls.Add(this.AddNonfuncReqButton);
            this.Controls.Add(this.BackToProjectSelectButton);
            this.Controls.Add(this.EditProjectInfoButton);
            this.Controls.Add(this.AddEffortButton);
            this.Controls.Add(this.NonfuncReqsListBox);
            this.Controls.Add(this.FunctionalReqsListBox);
            this.Controls.Add(this.RisksListBox);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.ProjectDescriptionTextBox);
            this.Controls.Add(this.ProjectManagerTextBox);
            this.Controls.Add(this.TeamMembersLabel);
            this.Controls.Add(this.RisksLabel);
            this.Controls.Add(this.label1);
            this.Name = "ProjectViewForm";
            this.Text = "ProjectView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RisksLabel;
        private System.Windows.Forms.Label TeamMembersLabel;
        private System.Windows.Forms.TextBox ProjectManagerTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.ListBox RisksListBox;
        private System.Windows.Forms.ListBox FunctionalReqsListBox;
        private System.Windows.Forms.ListBox NonfuncReqsListBox;
        private System.Windows.Forms.Button AddEffortButton;
        private System.Windows.Forms.Button EditProjectInfoButton;
        private System.Windows.Forms.Button BackToProjectSelectButton;
        private System.Windows.Forms.Button AddNonfuncReqButton;
        private System.Windows.Forms.Button AddFunctReqButton;
        private System.Windows.Forms.Button DelSelNonFuncReqButton;
        private System.Windows.Forms.Button DelSelFuncReqButton;
    }
}