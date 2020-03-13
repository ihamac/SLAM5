using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Cetace:Mammifere
    {
        protected int DureeApnee;
        protected int ProfondeurPlongee;

        public Cetace(int dureeApnee, int profondeurPlongee, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            DureeApnee = dureeApnee;
            ProfondeurPlongee = profondeurPlongee;
        }


        
    }
}
