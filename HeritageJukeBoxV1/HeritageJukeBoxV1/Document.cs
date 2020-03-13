using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageJukeBoxV1
{
    public abstract class Document
    {
        private string titre;
        private int durée;
        private bool enStock;
        private string commentaire;

        public Document(string titre, int durée, bool enStock, string commentaire)
        {
            this.titre = titre;
            this.durée = durée;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }

        public string GetCommentaire
        {
            get{
                return commentaire; 
            }
            set
            {
                value = commentaire;
            }
        }

        public bool GetStock
        {
            get
            {
                return this.enStock;
            }
            set
            {
                value = enStock;
            }

        }

        //Affiche les détails concernant un document
        public virtual void Afficher()
        {
            
            if (enStock)
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine();
            }
            
            Console.WriteLine("Document :" + titre + "(" + durée + "min)");
            Console.WriteLine("" + commentaire);
        }
    }
}
