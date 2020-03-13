using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationDelegue_Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new Calculatrice();
            c.ChoixOpération(Choix.Multiplication);
            c.ChoixOpération(Choix.Addition);

            c.Add(5);
            c.Add(6);
            c.Add(5);

            Console.WriteLine(c.Calculer());
            Console.ReadLine();
        }
    }
}
