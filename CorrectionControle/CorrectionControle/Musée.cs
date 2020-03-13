using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionControle
{
    class Musée
    {
        private string nom;
        List<Salle> lesSalles;
        List<Oeuvre> reserve;

        public Musée(string nom)
        {
            this.nom = nom;
            this.lesSalles = new List<Salle>();
            this.reserve = new List<Oeuvre>();
        }

        public int OùSeTrouve(Oeuvre uneOeuvre)
        {
            int n = -1;
            for(int i=0; i < lesSalles.Count; i++)
            {
                if (lesSalles[i].EstPrésente(uneOeuvre))
                {
                    return n = 1;
                }
            }
            return n;
            
     
        }

        public bool ChangerSalle(Oeuvre uneOeuvre, Salle salleDestination)
        {
            int i = OùSeTrouve(uneOeuvre);
            if (i == -1)
            {
                return false;
            }
            if (lesSalles[i] == salleDestination)
            {
                return false;
            }
            if (salleDestination.SallePleine())
            {
                return false;
            }

            lesSalles[i].RetirerOeuvre(uneOeuvre);
            salleDestination.AjouterOeuvre(uneOeuvre);
            return true;
        }

        public string ToString()
        {
            return string.Format("L'oeuvre se trouve dans : {0}", this.nom);
        }


    }
}
