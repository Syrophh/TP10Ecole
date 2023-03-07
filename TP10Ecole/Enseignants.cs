using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Enseignants : Personnel
    {
        private string section;

        public Enseignants(string section, int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) 
            : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire)
        {
            this.section = section;
        }

        public override string ToString()
        {
            return $@"{this.GetType()}
Section : {this.section}";
        }
    }
}
