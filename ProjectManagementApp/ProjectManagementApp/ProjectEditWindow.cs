﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementApp
{
    public partial class ProjectEditWindow : UserControl
    {
        public ProjectEditWindow()
        {
            InitializeComponent();
        }
        private static ProjectEditWindow _instance;

        public static ProjectEditWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectEditWindow();
                return _instance;
            }
        }

        private void ProjectEditWindow_Load(object sender, EventArgs e)
        {

        }

        private void ProjectLeaderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RiskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NonfunctionalRequirementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            ProjectProfileWindow.Instance.BringToFront();
        }
    }
}
