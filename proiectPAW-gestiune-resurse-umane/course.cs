using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW_gestiune_resurse_umane
{
    public class course
    {
        public string courseName { get; set; }

        public readonly int courseId;

        public int numberOfhours { get; set; }





        public course(string courseName, int numberOfhours, int courseId)

        {

            this.courseName = courseName;

            this.numberOfhours = numberOfhours;

            this.courseId = courseId;

        }



        public course() { }

        public override string ToString()
        {
            return $"{courseName} - {numberOfhours} hours";
        }
    }
}
