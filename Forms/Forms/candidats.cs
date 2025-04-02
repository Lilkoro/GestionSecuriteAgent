using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    class candidats
    {
        private string nom;
        private string prenom;
        private int age;

        public candidats (string c_nom, string c_prenom, int c_age)
        {
            nom = c_nom;
            prenom = c_prenom;
            age = c_age;
        }

        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public int getAge()
        {
            return age;
        }
    }
}
