using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int année;
        private Dictionary<int, Contact> contacts;

        public Ecole(string nom, int année, Dictionary<int, Contact> contacts)
        {
            this.Nom = nom;
            this.Année = année;
            this.Contacts = contacts;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Année { get => année; set => année = value; }
        internal Dictionary<int, Contact> Contacts { get => contacts; set => contacts = value; }

        public string AfficheTous()
        {
            string texte = "";
            foreach (KeyValuePair<int, Contact> contact in this.contacts)
            {
                texte += contact.Value.ToString();
            }
            return texte;
        }

        public double AnciennetéMoyenne()
        {
            double anciennetéTotal = 0.0;
            int i = 0;
            foreach (KeyValuePair<int, Contact> contact in this.contacts)
            {
                anciennetéTotal += contacts[i].AnneeArrivee;
                i++;
            }
            return anciennetéTotal /= i;
        }

        public bool EstEtudiant(Object contact)
        {
            return (contact is Etudiant);
        }


    }
}
