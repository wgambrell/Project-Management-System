namespace ProjectManagementApp
{
    partial class ProjectSelectWindow
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
            this.SelProjList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelProjButton = new System.Windows.Forms.Button();
            this.CreNewProButton = new System.Windows.Forms.Button();
            this.DelSelProjButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelProjList
            // 
            this.SelProjList.FormattingEnabled = true;
            this.SelProjList.Location = new System.Drawing.Point(266, 117);
            this.SelProjList.Name = "SelProjList";
            this.SelProjList.Size = new System.Drawing.Size(400, 290);
            this.SelProjList.TabIndex = 2;
            this.SelProjList.SelectedIndexChanged += new System.EventHandler(this.SelProjList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome! Select Your Project";
            // 
            // SelProjButton
            // 
            this.SelProjButton.Location = new System.Drawing.Point(266, 427);
            this.SelProjButton.Name = "SelProjButton";
            this.SelProjButton.Size = new System.Drawing.Size(133, 30);
            this.SelProjButton.TabIndex = 6;
            this.SelProjButton.Text = "Select Project";
            this.SelProjButton.UseVisualStyleBackColor = true;
            this.SelProjButton.Click += new System.EventHandler(this.SelProjButton_Click);
            // 
            // CreNewProButton
            // 
            this.CreNewProButton.Location = new System.Drawing.Point(405, 427);
            this.CreNewProButton.Name = "CreNewProButton";
            this.CreNewProButton.Size = new System.Drawing.Size(126, 30);
            this.CreNewProButton.TabIndex = 7;
            this.CreNewProButton.Text = "Create New Project";
            this.CreNewProButton.UseVisualStyleBackColor = true;
            this.CreNewProButton.Click += new System.EventHandler(this.CreNewProButton_Click);
            // 
            // DelSelProjButton
            // 
            this.DelSelProjButton.Location = new System.Drawing.Point(537, 427);
            this.DelSelProjButton.Name = "DelSelProjButton";
            this.DelSelProjButton.Size = new System.Drawing.Size(133, 30);
            this.DelSelProjButton.TabIndex = 8;
            this.DelSelProjButton.Text = "Delete Selected Project";
            this.DelSelProjButton.UseVisualStyleBackColor = true;
            this.DelSelProjButton.Click += new System.EventHandler(this.DelSelProjButton_Click);
            // 
            // ProjectSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelSelProjButton);
            this.Controls.Add(this.CreNewProButton);
            this.Controls.Add(this.SelProjButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelProjList);
            this.Name = "ProjectSelectWindow";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ProjectSelectWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SelProjList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelProjButton;
        private System.Windows.Forms.Button CreNewProButton;
        private System.Windows.Forms.Button DelSelProjButton;
    }
}
