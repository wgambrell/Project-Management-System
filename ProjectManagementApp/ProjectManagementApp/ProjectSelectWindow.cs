﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectManagementApp
{
    public partial class ProjectSelectWindow : UserControl
    {
        int selProjListIndex = 0;   //Index of currently selected file in the Project Selection window - to easily delete the currently selected project and to access the currently selected project. 
        String[] projects;          //List of Project file names, without file paths - to more easily read the Project Selection List
        String[] projectSaves;      //Lit of Project file names, with file paths - to more easily locate and delete/access files in the Project Selection list
        String pathfiles;
        private static ProjectSelectWindow _instance;

        public static ProjectSelectWindow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProjectSelectWindow();
                return _instance;
            }
        }
        public ProjectSelectWindow()
        {
            InitializeComponent(); //Opens projects folder
            pathfiles = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System";
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projects = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projectSaves = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            for (int i = 0; i < projects.Length; i++)   //Removes all the mile-long file path from the file names, to look more presentable!
            {
                for (int j = projects[i].Length - 1; j > 0; j--)
                {
                    String str = projects[i];
                    if (str[j].ToString() == "\\")
                    {
                        projects[i] = projects[i].Substring(j + 1);
                        break;
                    }
                }
            }
            SelProjList.Items.AddRange(projects);

        }

        public void ProjectSelectWindow_Reload()
        {
            SelProjList.Items.Clear();
            pathfiles = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System";
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projects = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            projectSaves = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System");
            for (int i = 0; i < projects.Length; i++)   //Removes all the mile-long file path from the file names, to look more presentable!
            {
                for (int j = projects[i].Length - 1; j > 0; j--)
                {
                    String str = projects[i];
                    if (str[j].ToString() == "\\")
                    {
                        projects[i] = projects[i].Substring(j + 1);
                        break;
                    }
                }
            }
            SelProjList.Items.AddRange(projects);
        }

        private void ProjectSelectWindow_Load(object sender, EventArgs e)
        {

        }

        private void SelProjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selProjListIndex = SelProjList.SelectedIndex - 1;
        }

        private void SelProjButton_Click(object sender, EventArgs e)
        {
            if (SelProjList.SelectedItem != null)
            {
                
                ProjectProfileWindow.Instance.ProjectProfileWindow_Clear();
                Project.Instance.EffortControl.Clear();
                Project.Instance.ReadFile(SelProjList.SelectedItem.ToString().Substring(0, SelProjList.SelectedItem.ToString().IndexOf(".")));
                // create files and save data
                //SaveFile(path);

                // set mandatory variables on profile
                //Project.Instance.SetInitialVariables(ProjectNameTextBox.Text, ProjectManagerTextBox.Text, DescriptionTextBox.Text, comboBox1.SelectedItem.ToString());
                //Project.Instance.SetOptionalVariables(TeamMembersListBox, RiskListBox);

                //Creates taskbar
                if (!ProjectManagementSystem.Instance.PanelBarControls.Controls.Contains(Taskbar.Instance))
                {
                    ProjectManagementSystem.Instance.PanelBarControls.Controls.Add(Taskbar.Instance);
                    Taskbar.Instance.Dock = DockStyle.Fill;
                    Taskbar.Instance.BringToFront();
                }
                else
                {
                    Taskbar.Instance.BringToFront();
                }
                //Creates Project Profile window and sets it to open
                if (!ProjectManagementSystem.Instance.Panel1Control.Controls.Contains(ProjectProfileWindow.Instance))
                {
                    ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectProfileWindow.Instance);
                    ProjectProfileWindow.Instance.Dock = DockStyle.Fill;
                    ProjectProfileWindow.Instance.BringToFront();
                }
                else
                {
                    ProjectProfileWindow.Instance.BringToFront();
                }
                //Create Project Effort page
                ProjectManagementSystem.Instance.Panel1Control.Controls.Add(ProjectEffortManagement.Instance);
                ProjectEffortManagement.Instance.Dock = DockStyle.Fill;

                ProjectManagementSystem.Instance.Panel1Control.Controls.Remove(InitialProjectSetupWindow.Instance);
               

                Taskbar.Instance.projectTitleControls.Text = Project.Instance.projectNameControls;
                ProjectProfileWindow.Instance.ProjectProfileWindow_Reload();
                loadPieChart();
                ProjectEffortManagement.Instance.clearAndFillTable();
                //Set ProjectProfileWIndow and Taskbar text
                //InitialProjectSetupWindow.Instance.SetProjectProfilePage();

            }
        }
        private void loadPieChart()
        {
            int[] temp = Project.Instance.getHours();
            ProjectEffortManagement.Instance.updatePieChart(temp[0], temp[1], temp[2], temp[3], temp[4]);
            ProjectEffortManagement.Instance.totalLabel.Text = temp[5].ToString();
        }


        private void CreNewProButton_Click(object sender, EventArgs e)  //Transfers to InitialProjectSetup page
        {
            ProjectManagementSystem.Instance.Panel1Control.Controls.Add(InitialProjectSetupWindow.Instance);
            InitialProjectSetupWindow.Instance.BringToFront();
            ProjectManagementSystem.Instance.Panel1Control.Controls.Remove(ProjectSelectWindow.Instance);
            InitialProjectSetupWindow.Instance.InitialProjectSetupWindow_Clear();
        }

        private void DelSelProjButton_Click(object sender, EventArgs e)
        {
            if (SelProjList.SelectedItem != null)
            {
                String s = SelProjList.SelectedItem.ToString();
                File.Delete(pathfiles + " \\" + s);
                if (ProjectProfileWindow.Instance != null)
                    ProjectProfileWindow.Instance.ProjectProfileWindow_Clear();
                if (ProjectEffortManagement.Instance != null)
                    ProjectEffortManagement.Instance.ProjectEditManagement_Clear();
                SelProjList.Items.Remove(SelProjList.SelectedItem);
            }
        }
    }
}
