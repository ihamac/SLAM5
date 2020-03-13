using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HeritageJukeBoxV1
{
    public class Database
    {
        private ArrayList lesDocuments;

        //Construit une base de données vide
        public Database()
        {
            lesDocuments = new ArrayList();
        }

        //Ajoute un CD à la base de données
        public void Add(Document d)
        {
            lesDocuments.Add(d);
        }

        //Affiche une liste de tous les documents actuellement stokés sur le terminal
        public void Editer()
        {
            //affiche une liste de documents
            for (int i=0; i<lesDocuments.Count; i++)
            {
                Document document = (Document)lesDocuments[i];
                document.Afficher();
                Console.WriteLine(); 
            }
        }
    }

}
