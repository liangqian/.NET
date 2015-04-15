using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你所走的距离 = =！");
            Ticket t = new Ticket(Convert.ToInt32(Console.ReadLine()));
            t.Showticket();
            Console.ReadKey();
        }
    }
}
