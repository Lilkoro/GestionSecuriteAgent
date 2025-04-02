using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public abstract class Personnel
    {
        private string nom;
        private string prenom;

        // Constructeur
        public Personnel(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        protected string infopersonnel()
        {
            return this.nom + " " + this.prenom;
        }

        // Methode qui va être réécris dans les class filles pour remonter les informations
        public abstract string info();

    }

    // Class Fille
    // 1 - Class Enseignants | avec héritage 

    public class enseignant : Personnel
    {
        private int nbHeure;

        // Constructeur 
        public enseignant(string nom, string prenom, int nbHeure):base(nom, prenom)
        {
            this.nbHeure = nbHeure;
        }

        // Override pour redefinir la fonction info() que la class mère va utiliser.
        public override string info()
        {
            return base.infopersonnel() + " - " + nbHeure + " Heures enseignées";
        }
    }

    // 2 - Class Service

    public class admin : Personnel
    {
        private string service;

        public admin(string nom, string prenom, string service) : base(nom, prenom)
        {

            this.service = service;
        }

        public override string info()
        {
            return base.infopersonnel() + " - " + service;
        }
    }

}
