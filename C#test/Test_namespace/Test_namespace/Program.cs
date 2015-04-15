using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_review;

namespace Test_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket lq = new Ticket(42904);
            lq.Showticket();
            Console.ReadKey();
        }
    }
}
