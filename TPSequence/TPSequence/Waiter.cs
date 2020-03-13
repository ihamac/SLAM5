using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSequence
{
    class Waiter:Personne
    {
        private Client monClient;
        private Cook monCuisinier;
        private Cashier leCaissier;

        public Waiter(Cook leCuisinier, Cashier leCaissier, string nom) : base(nom)
        {
            this.monCuisinier = leCuisinier;
            this.leCaissier = leCaissier;
        } 

        public void OrderFood(Client unClient)
        {
            Console.WriteLine("Le serveur prend la commande du client");
            this.monClient = unClient;
            this.monCuisinier.OrderFood(this);
        }

        public void Pickup()
        {
            this.monClient.ServeFood(leCaissier);
        }
    }
}
