using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeExo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Modele m = new Modele("Lupo", 0.2);
            Option option = new Option("Direction Assistée", 250);
            m.AddOption(option);

            Vehicule v1 = new Voiture(m, "tam");
            Option op = new Option("a", 0.2);
            v1.AddOption(op);
            Console.WriteLine(v1.possèdeOption(op.GetLibelle()));

            Vehicule v = new Voiture(m,"1234");
            Option optionV = new Option("AirBag", 320);
            v.AddOption(optionV);

            Console.WriteLine(v.ToString());
            Console.WriteLine(m.ToString());
            Console.ReadLine();

        }
    }
}
