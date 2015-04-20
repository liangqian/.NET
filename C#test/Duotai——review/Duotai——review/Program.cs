using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duotai__review
{
    class Program
    {
        static void Main(string[] args)
        {
            RealDuck re=new RealDuck ();
            XpDuck xp = new XpDuck();
            Muduck mu = new Muduck();
            RealDuck[] duck = { re,xp,mu};
            for (int i = 0; i < duck.Length; i++)
            {
                duck[i].Bark();
            }

        }

        public class RealDuck
        {
            public virtual void Bark()
            {
                Console.WriteLine("真的鸭子呱呱叫");
            }
        }
        public class Muduck:RealDuck
        {
            public override void Bark()
            {
                Console.WriteLine("木头鸭子唧唧叫");
            }
        }
        public class XpDuck:RealDuck
        {
            public override void Bark()
            {
                Console.WriteLine("橡皮鸭子咕咕叫");
            }
        }
    }
}
