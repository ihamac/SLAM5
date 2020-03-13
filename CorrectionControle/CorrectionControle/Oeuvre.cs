using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionControle
{
    class Oeuvre
    {
        private string nom;
        private int prix;

        public Oeuvre(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetPrix()
        {
            return this.prix;
        }

        public string ToString()
        {
            return string.Format("Nom : {0} - Prix : {1} millions d'euros", nom, prix);
        }
    }
}
