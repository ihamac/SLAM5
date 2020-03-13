using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPooExo3
{
    class Camion
    {
        string immatriculation;
        string annéeDeConstruction;
        string marque;
        string modele;
        bool decapotable;
        int essieux;

        public Camion(string immatriculation, string annéeDeConstruction, string marque, string modele, bool decapotable, int essieux)
        {
            this.immatriculation = immatriculation;
            this.annéeDeConstruction = annéeDeConstruction;
            this.marque = marque;
            this.modele = modele;
            this.decapotable = decapotable;
            this.essieux = essieux;
        }
    }
}
