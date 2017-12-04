using System;
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
        private List<Effort> effortList = new List<Effort>();   //NOT SUPPORTED
        private String path;

        public int EffortListCount
        {
            get { return effortList.Count; }
        }



        public void SetInitialVariables(String prjname, String mgrname, String prjDescription, String timeday)  //Used to initialize a project file when it's first created.
        {
            projectName = prjname;
            managerName = mgrname;
            projectDescription = prjDescription;
            if (timeday == "Weekly")
                daytime = 7;
            else
                daytime = 1;

        }
        public void setProfilePage()    //sets all windows in ProjectProfileWindow
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

            ProjectProfileWindow.Instance.funcRequirementsControls.Items.Clear();
            foreach (var item in funcReq)
            {
                ProjectProfileWindow.Instance.funcRequirementsControls.Items.Add(item);
            }

            ProjectProfileWindow.Instance.NonfuncRequirementsControls.Items.Clear();
            foreach (var item in nonFuncReq)
            {
                ProjectProfileWindow.Instance.NonfuncRequirementsControls.Items.Add(item);
            }
        }

        public int getTimeInteger
        {
            get { return daytime; }
            set { daytime = value; }
        }

        public void ReadFile(String fileName)   //Reads from a file to populate data in the project class. CURRENTLY DOES NOT SUPPORT EFFORT OFFLOAD.
        {
           
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System" + "\\" + fileName + ".txt";
            StreamReader sr = new StreamReader(path);
            projectName = sr.ReadLine();
            managerName = sr.ReadLine();
            projectDescription = sr.ReadLine();
            String memList = sr.ReadLine();
            try
            {
                while (memList != "")
                {
                    projectMembers.Add(memList.Substring(0, memList.IndexOf("*")));
                    memList = memList.Substring(memList.IndexOf("*") + 3);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No more members found." + ex.Message);
            }
            String riskList = sr.ReadLine();
            if (riskList != "")
            {
                try
                {
                    while (riskList != "")
                    {
                        risks.Add(riskList.Substring(0, riskList.IndexOf("*")));
                        riskList = riskList.Substring(riskList.IndexOf("*") + 3);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No more risks found." + ex.Message);
                }
            }
            daytime = Int32.Parse(sr.ReadLine());
            String funcList = sr.ReadLine();
            if (funcList != "")
            {
                try
                {
                    while (funcList != "")
                    {
                        funcReq.Add(funcList.Substring(0, funcList.IndexOf("*")));
                        funcList = funcList.Substring(funcList.IndexOf("*") + 3);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No more functional requirements found." + ex.Message);
                }
            }
            String nonFuncList = sr.ReadLine();
            if (nonFuncList != "")
            {
                try
                {
                    while (nonFuncList != "")
                    {
                        nonFuncReq.Add(nonFuncList.Substring(0, nonFuncList.IndexOf("*")));
                        nonFuncList = nonFuncList.Substring(nonFuncList.IndexOf("*") + 3);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No more nonfunctional requirements found." + ex.Message);
                }
            }

            
            String effortString = sr.ReadLine();
            if (effortString != "")
            {
                try
                {
                    while (effortString != "")
                    {
                        String dateStamp = effortString.Substring(0, effortString.IndexOf("&"));
                        DateTime setStamp = Convert.ToDateTime(dateStamp);   
                        effortString = effortString.Substring(effortString.IndexOf("&") + 1);

                        int int1 = Int32.Parse(effortString.Substring(0, effortString.IndexOf("#")));
                        effortString = effortString.Substring(effortString.IndexOf("#") + 1);

                        int int2 = Int32.Parse(effortString.Substring(0, effortString.IndexOf("#")));
                        effortString = effortString.Substring(effortString.IndexOf("#") + 1);

                        int int3 = Int32.Parse(effortString.Substring(0, effortString.IndexOf("#")));
                        effortString = effortString.Substring(effortString.IndexOf("#") + 1);

                        int int4 = Int32.Parse(effortString.Substring(0, effortString.IndexOf("#")));
                        effortString = effortString.Substring(effortString.IndexOf("#") + 1);

                        int int5 = Int32.Parse(effortString.Substring(0, effortString.IndexOf("*")));
                        //effortString = effortString.Substring(effortString.IndexOf("") + 1);


                        Effort tempE = new Effort(int1, int2, int3, int4, int5, setStamp);
                        effortList.Add(tempE);

                        effortString = effortString.Substring(nonFuncList.IndexOf("*") + 3);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No Effort Found." + ex.Message);
                }
            }
            sr.Close();
            sr.Close();
        }

        public void RewriteFile()   //Rebuilds file with new shtuff
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Project Management System" + "\\" + projectName + ".txt";
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
                foreach (var item in effortList)
                {
                    s += item.timeControl.ToString() + "&" + item.getcategory[0] + "#" + item.getcategory[1] + "#" + item.getcategory[2] + "#" + item.getcategory[3] + "#" + item.getcategory[4] + "*@*";
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
        public String getDateType()
        {
            if (daytime == 7)
                return "Weekly Reports";
            else if (daytime == 1)
                return "Daily Reports";
            else
                return "Daily Reports";
        }
         
        public void removeLastEffort()
        {
            effortList.RemoveAt(effortList.Count - 1);
        }
        public Effort getLastEffort()
        {
            return effortList[effortList.Count - 1];
        }
        public int getEffortListSize()
        {
            return effortList.Count;
        }
        public void clearEffortList()
        {
            effortList.Clear();
        }
         // Get all hours from each effort and compile a total, then return an array of the total efforts
         public int[] getHours()
        {
            int[] temp = new int[6];
            int total = 0, management = 0, requirement =0, design = 0, implementation = 0, testing = 0;
            foreach(var item in effortList)
            {
                management += item.getcategory[0];
                requirement += item.getcategory[1];
                design += item.getcategory[2];
                implementation += item.getcategory[3];
                testing += item.getcategory[4];
            }
            total = management + requirement + design + implementation + testing;
            temp[0] = management;
            temp[1] = requirement;
            temp[2] = design;
            temp[3] = implementation;
            temp[4] = testing;
            temp[5] = total;
            return temp;
        } 
    }
}
