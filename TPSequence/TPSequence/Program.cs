using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier Renée = new Cashier("Renée");
            Cook Hank = new Cook("Hank");

            Waiter Bob = new Waiter(Hank, Renée,"Bob");
            Client Fred = new Client("Fred");

            Fred.SeatAtTable(Bob);
            Console.ReadLine();
        }
    }
}
