using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW_gestiune_resurse_umane
{
    public class employee : person, ICloneable, IComparable<employee>
    {
        public job myjob { get; set; }
        public List<course> coursesCompleted { get; set; }

        public employee(job myjob, List<course> coursesCompleted, string fullName, DateTime birthDate, string cNP)
            : base(fullName, birthDate, cNP)
        {
            this.myjob = myjob;

            this.coursesCompleted = new List<course>();
            if (coursesCompleted != null)
            {
                foreach (var c in coursesCompleted)
                {
                    this.coursesCompleted.Add(c);
                }
            }
        }

        public employee()
        {
            coursesCompleted = new List<course>();
        }

        
        public override string ToString()
        {
            if (myjob != null)
                return $"{fullName} - Job: {myjob.jobName} ({myjob.salary} RON)";
            else
                return $"{fullName} - No job";
        }

        
        public object Clone()
        {
            employee clone = (employee)this.MemberwiseClone();

            if (this.myjob != null)
            {
                clone.myjob = new job(this.myjob.jobName, this.myjob.salary, this.myjob.jobId);
            }

            clone.coursesCompleted = new List<course>();
            if (this.coursesCompleted != null)
            {
                foreach (course c in this.coursesCompleted)
                {
                    clone.coursesCompleted.Add(new course(c.courseName, c.numberOfhours, c.courseId));
                }
            }

            return clone;
        }

        
        public int CompareTo(employee other)
        {
            if (other == null) return 1;

            if (this.myjob == null && other.myjob == null) return 0;
            if (this.myjob == null) return -1;
            if (other.myjob == null) return 1;

            return this.myjob.salary.CompareTo(other.myjob.salary);
        }
    }
}
