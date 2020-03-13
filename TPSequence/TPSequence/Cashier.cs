using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSequence
{
    class Cashier:Personne
    {
        public Cashier(string nom) : base(nom)
        {

        }
        public void Pay()
        {
            Console.WriteLine("*Le client paie* Merci, bonne soirée et à bientôt !");
        }
    }
}
