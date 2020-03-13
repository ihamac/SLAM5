using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(int nombrePattes, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }
    }
}
