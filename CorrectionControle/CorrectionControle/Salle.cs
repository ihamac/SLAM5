using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionControle
{
    class Salle
    {
        private int capacitéSalle;
        private string nom;
        private List<Oeuvre> lesOeuvres;

        public Salle(int capacitéSalle, string nom)
        {
            this.capacitéSalle = capacitéSalle;
            this.nom = nom;
            this.lesOeuvres = new List<Oeuvre>();
        }

        public bool AjouterOeuvre(Oeuvre uneOeuvre)
        {
            if (SallePleine() == false)
            {
                lesOeuvres.Add(uneOeuvre);
                return true;
            }
            return false;
        }

        public bool RetirerOeuvre(Oeuvre uneOeuvre)
        {
            lesOeuvres.Remove(uneOeuvre);
            return true;
        }

        public bool SallePleine()
        {
            if(this.lesOeuvres.Count >= this.capacitéSalle)
            {
                return true;
            }
            return false;
        }

        public bool EstPrésente(Oeuvre uneOeuvre)
        {
            for(int i = 0; i < lesOeuvres.Count; i++)
            {
                if (lesOeuvres[i].GetNom() == uneOeuvre.GetNom())
                {
                    return true;
                }
                
            }
            return false;
        }


    }
}
