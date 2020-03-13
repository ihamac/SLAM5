using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageJukeBoxV1
{
    class CD:Document
    {
        private string artitste;
        private int nombrePiste;

        public CD(string artitste, int nombrePiste, string titre, int durée, bool enStock, string commentaire) : base(titre, durée, enStock, commentaire)
        {
            this.artitste = artitste;
            this.nombrePiste = nombrePiste;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("CD : " + artitste + " - Nombre de piste : " + nombrePiste);
        }
    }
}
