using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSequence
{
    class Cook:Personne
    {
        public Cook(string nom) : base(nom)
        {

        }
        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Cuisinier : Préparation de la commande...");
            Console.WriteLine("Le serveur sert le client");
            unServeur.Pickup();

        }
    }
}
