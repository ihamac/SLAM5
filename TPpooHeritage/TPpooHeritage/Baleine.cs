using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Baleine : Cetace
    {
        public Baleine(int dureeApnee, int profondeurPlongee, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(dureeApnee, profondeurPlongee, nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
        }
        public void Afficher()
        {
            Console.WriteLine("Je suis un {0}, j'habite dans l'{1}, je suis {2}", nom, LieuHabitation, jeSuisDomestique);
        }
    }
}
