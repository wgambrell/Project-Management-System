﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementApp
{
    class Project
    {
        private static Project _instance;

        public static Project Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Project();
                return _instance;
            }
        }
        private String projectName;
        private String managerName;
        private int daytime;
        private ArrayList projectMembers = new ArrayList();
        private String projectDescription;
        private ArrayList risks = new ArrayList();
        private ArrayList funcReq = new ArrayList();
        private ArrayList nonFuncReq = new ArrayList();
        private List<Effort> effortList = new List<Effort>();
        

        public void SetInitialVariables(String prjname, String mgrname, String prjDescription, String timeday)
        {
            projectName = prjname;
            managerName = mgrname;
            projectDescription = prjDescription;
            if (timeday == "Weekly")
                daytime = 7;
            else
                daytime = 1;

        }
        public void setProfilePage()
        {
            ProjectProfileWindow.Instance.projecManagerControls.Text = managerName;
            ProjectProfileWindow.Instance.projecDescriptionControls.Text = projectDescription;

            ProjectProfileWindow.Instance.teamMemberListControls.Items.Clear();
            foreach (var item in projectMembers)
            {
                ProjectProfileWindow.Instance.teamMemberListControls.Items.Add(item);
            }

            ProjectProfileWindow.Instance.RiskListControls.Items.Clear();
            foreach (var item in risks)
            {
                ProjectProfileWindow.Instance.RiskListControls.Items.Add(item);
            }

            ProjectProfileWindow.Instance.funcRequirements.Items.Clear();
            foreach (var item in funcReq)
            {
                ProjectProfileWindow.Instance.funcRequirements.Items.Add(item);
            }

            ProjectProfileWindow.Instance.NonfuncRequirements.Items.Clear();
            foreach (var item in nonFuncReq)
            {
                ProjectProfileWindow.Instance.NonfuncRequirements.Items.Add(item);
            }
        }

        public void RewriteFile()   //Rebuilds file with new shtuff
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System" + "\\" + projectName + ".txt";
            File.WriteAllText(path, null);
            using (TextWriter tw = new StreamWriter(path, true))
            {
                String s = "";
                tw.WriteLine(projectName);
                tw.WriteLine(managerName);
                tw.WriteLine(projectDescription);
                foreach (var item in projectMembers)
                {
                    s += item.ToString() + "*@*";
                }
                tw.WriteLine(s);
                s = "";
                foreach (var item in risks)
                {
                    s += item.ToString() + "*@*";
                }
                tw.WriteLine(s);
                s = "";
                tw.WriteLine(daytime);
                foreach (var item in funcReq)
                {
                    s += item.ToString() + "*@*";
                }
                tw.WriteLine(s);
                s = "";
                foreach(var item in nonFuncReq)
                {
                    s += item.ToString() + "*@*";
                }
                tw.WriteLine(s);
                s = "";
                tw.Close();
            }
        }

        public void SetOptionalVariables(ListBox arr1, ListBox arr2)
        {
            foreach (var item in arr1.Items)
            {
                projectMembers.Add(item);
            }

            foreach (var item in arr2.Items)
            {
                risks.Add(item);
            }
        }
        public ArrayList projectMembersControl
        {
            get { return projectMembers; }
            set { projectMembers = value; }
        }
        public ArrayList projectRiskControl
        {
            get { return risks; }
            set { risks = value; }
        }
        public ArrayList FuncReqControl
        {
            get { return funcReq; }
            set { funcReq = value; }
        }
        public ArrayList NonFuncReqControl
        {
            get { return nonFuncReq; }
            set { nonFuncReq = value; }
        }
        public List<Effort> EffortControl
        {
            get { return effortList; }
            set { effortList = value; }
        }
        public String projectNameControls
        {
            get { return projectName;  }
            set { projectName = value;  }
        }
        public String managerNameControls
        {
            get { return managerName; }
            set { managerName = value; }
        }
        public String projectDescriptionControls
        {
            get { return projectDescription; }
            set { projectDescription = value; }
        }
        public int daytimeControls
        {
            get { return daytime; }
            set { daytime = value; }
        }
        public void AddProjectMember(String s)
        {
            projectMembers.Add(s);
        }
        public void RemoveProjectMembers(String s)
        {
            projectMembers.Remove(s);
        }
        public void AddRisks(String s)
        {
            risks.Add(s);
        }
        public void RemoveRisks(String s)
        {
            risks.Remove(s);
        }
        public void AddFuncReq(String s)
        {
            funcReq.Add(s);
        }
        public void RemoveFuncReq(String s)
        {
            funcReq.Remove(s);
        }
        public void AddNonFuncReq(String s)
        {
            nonFuncReq.Add(s);
        }
        public void RemoveNonFuncReq(String s)
        {
            nonFuncReq.Remove(s);
        }

    }
}
