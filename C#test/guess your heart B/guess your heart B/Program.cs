using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_your_heart_B
{
    class Program               //guess a radom number
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int Intinput;
            int i = ran.Next(0, 100);
            string InputNumber;
        reInput1:
            Console.WriteLine("Please Input a random number.");
            InputNumber = Console.ReadLine();
            Intinput = Convert.ToInt16(InputNumber);
            if (Intinput > 100 || Intinput < 0)
            {
                Console.WriteLine("Sorry,U have Input a illegal Number,Please Input again!");
                goto reInput1;
            }
            while (i != Intinput && Intinput > 0 && Intinput < 100)
            {
                Console.WriteLine("Sorry , U are wrong! , Please Inoput again");
            Reput1:
                InputNumber = Console.ReadLine();
                Intinput = Convert.ToInt16(InputNumber);
                if (Intinput > 100 || Intinput < 0)
                {
                    Console.WriteLine("Sorry,U have Input a illegal Number,Please Input again!");
                    goto Reput1;
                }
            }
            Console.WriteLine("Congratulations！ U gain a excellent Mark");
            Console.ReadKey();
        }
    }
}