using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpooHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat m = new Chat(4,"Guy", "Paris", "Miaou", true);
            m.Afficher();
            Baleine b = new Baleine(60, 125,"Rayhane", "Ermont", "ahou", true);
            b.Afficher();
            Lion l = new Lion(4, "Roi", "Savane", "Rhuuu", false);
            l.Afficher();
        }
    }
}
