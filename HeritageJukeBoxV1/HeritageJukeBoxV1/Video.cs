using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageJukeBoxV1
{
    class Video:Document
    {
        private string metteurEnScene;

        public Video(string metteurEnScene, string titre, int durée, bool enStock, string commentaire):base(titre, durée, enStock, commentaire)
        {
            this.metteurEnScene = metteurEnScene;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Vidéo : " + metteurEnScene);
        }
    }
}
