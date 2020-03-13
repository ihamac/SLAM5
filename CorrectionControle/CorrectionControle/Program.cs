using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionControle
{
    class Program
    {
        static void Main(string[] args)
        {
            Oeuvre o = new Oeuvre("Mona Lisa", 100);
            Console.WriteLine(o.ToString());
            Salle s = new Salle(100, "Mone Lisa");
            Musée m = new Musée("Louvres");
            m.ChangerSalle(o,s);
            Console.WriteLine(m.OùSeTrouve(o).ToString());
            Console.ReadLine();
        }
    }
}
