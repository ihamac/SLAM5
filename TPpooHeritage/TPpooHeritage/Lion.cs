using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Lion : Felin
    {
        public Lion(int nombrePattes, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(nombrePattes, nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
        }
        public void Afficher()
        {
            Console.WriteLine("Je suis un {0}, j'ai {1} pattes, je suis {2}", nom, nombrePattes, jeSuisDomestique);
        }
    }


}

