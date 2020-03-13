using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSequence
{
    class Client:Personne
    {
        string nom;
        public Client(string nom) : base(nom)
        {
            this.nom = nom;
        }

        public void ServeWine(Cashier leCaissier)
        {   
            leCaissier.Pay();
        }

        public void ServeFood(Cashier leCaissier)
        {
            //JeMange
            leCaissier.Pay();
        }

        public void SeatAtTable(Waiter unServeur)
        {
            Console.WriteLine("Le client choisi une table");
            unServeur.OrderFood(this);
            
        }
    }
}
