using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Mammifere
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;

        public Mammifere(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        protected bool JeSuisDangereux
        {
            get
            {
                return jeSuisDomestique;
            }
            set
            {
                jeSuisDomestique = value;
            }

        }
    }
}
