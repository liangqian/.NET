using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        weat = 4
    }
    struct route
    {
        public orientation direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) south\n3) East\n4) Weat");
            do
            {
                 Console.WriteLine("Select a direction:");
                 myDirection = Convert.ToInt32("console.Readline()");
            }
            while ((myDirection < 1)||(myDirection > 4));
            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.distance = myDistance;
            Console.WriteLine("myroute specifies a direction of {0} and a distance of {1}", myRoute.direction, myRoute.distance);
            Console.ReadKey();
        }
    }
}
