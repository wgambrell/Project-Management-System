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
    public partial class ProjectSelectForm : Form
    {
        int selProjListIndex = 0;   //Index of currently selected file in the Project Selection window - to easily delete the currently selected project and to access the currently selected project. 
        String[] projects;          //List of Project file names, without file paths - to more easily read the Project Selection List
        String[] projectSaves;      //Lit of Project file names, with file paths - to more easily locate and delete/access files in the Project Selection list
        public ProjectSelectForm() //Creates a directory in Documents folder called "Project Management System", Populates the Project List in the window with all file names in there.
        {

            InitializeComponent();
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projects = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projectSaves = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            for (int i = 0; i < projects.Length; i++)
            {
                for (int j = projects[i].Length-1; j > 0; j--)
                {
                    String str = projects[i];
                    if(str[j].ToString() == "\\")
                    {
                        projects[i] = projects[i].Substring(j+1);
                        break;
                    }
                }
            }
            SelProjList.Items.AddRange(projects);

        }

        private void ProjectSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void SelProjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selProjListIndex = SelProjList.SelectedIndex - 1; 
        }

        private void DelSelProjButton_Click(object sender, EventArgs e)
        {
            String s = SelProjList.SelectedItem.ToString();
            File.Delete(s);
            SelProjList.Items.Remove(SelProjList.SelectedItem);
        }

        private void CreNewProButton_Click(object sender, EventArgs e)
        {

        }
    }
}
