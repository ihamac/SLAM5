using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeExo2
{
    class Voiture:Vehicule
    {
        private Modele modele;

        public Voiture(Modele modele, string immatriculation):base(immatriculation)
        {
            this.modele = modele;
        }

        /*public double CalculerPrix()
        {
           //question3
        }*/

        public override string ToString()
        { 
            return string.Format("{0}{1}", modele.ToString(), base.ToString());
        }
    }
}
