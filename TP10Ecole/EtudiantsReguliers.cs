using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantsReguliers : Etudiant
    {
        private double noteMoyenne;

        public EtudiantsReguliers(double noteMoyenne, int matricule, string nom, int anneeArrivee, string section) : base(matricule, nom, anneeArrivee, section)
        {
            this.noteMoyenne = noteMoyenne;
        }

        public override string ToString()
        {
            return $@"{base.ToString()}
Moyenne : {this.noteMoyenne}";
        }
    }
}
