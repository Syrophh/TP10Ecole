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
            this.nom = nom;
            this.année = année;
            this.contacts = contacts;
        }

        public string afficheTous()
        {

        }
    }
}
