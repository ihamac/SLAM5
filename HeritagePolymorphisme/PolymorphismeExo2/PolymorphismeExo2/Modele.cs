using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeExo2
{
    class Modele
    {
        private string nom;
        private double prix;
        List<Option> optionsModele;

        public Modele(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModele = new List<Option>();
        }

        public double GetPrix
        {
            get
            {
                return prix;
            }
        }

        public void AddOption(Option option)
        {
            optionsModele.Add(option);
        }

        public int Count
        {
            get
            {
                return this.optionsModele.Count;
            }
        }

        public new string ToString()
        {
            Option optionM = new Option("Direction Assistée", 250);
            for (int i =0; i < optionsModele.Count; i++)
            {
                
                optionM = optionsModele[i];
                Console.WriteLine(optionM);
               
            }
            return string.Format("Modèle : {0} - Prix : {1} euros", nom, prix, "\n {2}",optionM);
        }
    }
}
