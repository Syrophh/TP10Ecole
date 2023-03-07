using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantsEchange : Etudiant
    {
        private string universiteOrigine;

        public EtudiantsEchange(string universiteOrigine, int matricule, string nom, int anneeArrivee, string section) : base(matricule, nom, anneeArrivee, section)
        {
            this.universiteOrigine = universiteOrigine;
        }

        public override string ToString()
        {
            return $@"{base.ToString()}
Université d'origine : {this.universiteOrigine}";
        }
    }
}
