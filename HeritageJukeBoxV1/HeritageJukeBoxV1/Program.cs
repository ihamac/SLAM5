using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageJukeBoxV1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Document c = new CD("A2H", 3, "Blues", 3, true, "Excellent");
            c.Afficher();
            Console.ReadLine();

        }
    }
}
