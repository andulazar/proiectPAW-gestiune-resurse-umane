using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW_gestiune_resurse_umane
{
    public class person
    {
        public string fullName { get; set; }
        public DateTime birthDate { get; set; }
        public string cNP { get; set; }
        public person(string fullName, DateTime birthDate, string cNP)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.cNP = cNP;
        }

        public person() { }
    }
}
