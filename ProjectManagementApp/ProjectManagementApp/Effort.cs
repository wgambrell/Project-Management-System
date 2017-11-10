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
        private string category;

        public Effort(string category, int hoursExpended)
        {
            this.category = category;
            this.hoursExpended = hoursExpended;
            this.timeStamps = DateTime.Now;
        }
    }
}
