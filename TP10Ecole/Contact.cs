using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        protected int anneeArrivee;

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneeArrivee
        {
            get => anneeArrivee;
            private set
            {
                if (value < DateTime.Today.Year)
                {
                    anneeArrivee = value;
                }
                else
                {
                    throw new Exception("Erreur, l'année d'arrivée est supérieur à l'année actuelle");
                }
            }
        }


        public override string ToString()
        {
            return $@"{this.GetType().Name}
Matricule : {this.matricule}
Nom : {this.nom}
Annee : {this.anneeArrivee}";
        }
    }
}
