using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathcount
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter Your Name");       /*show this content*/
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!" ,userName);
            Console.WriteLine("Now , give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());     /*chang input to Double*/
            Console.WriteLine("Now , give me another number");
            secondNumber = Convert.ToDouble(Console.ReadLine());    /*chang input to Double*/
            /* counting  */
            Console.WriteLine("The sum of {0} and {1} is {2}.",firstNumber,secondNumber,firstNumber + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The sum of dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remaider after dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}
