using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPooExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahicule[] Tab = new Vehicule[4];
            Tab[0] = new Voiture("333 ABC 06", 2000, "peugeot", "360", true, false);
            Tab[1] = new Voiture("321 BBD 06", 2001, "renault", "clio", true, false);
            Tab[2] = new Voiture("333 ABC 06", 2000, "peugeot", "360", true, false);
            Tab[3] = new Voiture("333 ABC 06", 2000, "peugeot", "360", true, false);

        }
    }
}
