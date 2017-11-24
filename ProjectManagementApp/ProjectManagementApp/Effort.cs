using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp
{
    class Effort
    {
        private int hoursExpended;
        private DateTime timeStamps;
        private int[] category = new int[5];

        public Effort(int management, int requirements, int design, int implementation, int testing, DateTime stamp)
        {
            category[0] = management;
            category[1] = requirements;
            category[2] = design;
            category[3] = implementation;
            category[4] = testing;
            //this.hoursExpended = hoursExpended;
            timeStamps = stamp.Date;
        }

        public DateTime timeControl
        {
            get { return timeStamps; }
            set { timeStamps = value; }
        }
    }
}
