using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
