using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Personnel
    {
        protected string nomLaboratoire;
        protected double salaire;

        public Personnel(string nomLaboratoire, double salaire)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }
    }
}
