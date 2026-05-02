using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW_gestiune_resurse_umane
{
    public class job
    {
        public string jobName { get; set; }

        public readonly int jobId;

        public double salary { get; set; }



        public job(string jobName, double salary, int jobId)

        {

            this.jobName = jobName;

            this.salary = salary;

            this.jobId = jobId;

        }

        public job() { }

    }
}

