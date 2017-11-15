﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectManagementApp
{
    public partial class ProjectManagementSystem : Form
    {
        private static ProjectManagementSystem _instance;

        public static ProjectManagementSystem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectManagementSystem();
                return _instance;
            }
        }

        public ProjectManagementSystem()
        {
            InitializeComponent();
            panel1.Controls.Add(ProjectSelectWindow.Instance);
        }

        public Panel Panel1Control
        {
            get
            {
                return panel1;
            }
            set
            {
                panel1 = value;
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectManagementSystem_Load(object sender, EventArgs e)
        {

        }
    }
}