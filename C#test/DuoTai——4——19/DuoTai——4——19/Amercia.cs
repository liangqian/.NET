using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai__4__19
{
    class Amercia:Person
    {
        public Amercia(string name)
            : base(name)
        {
 
        }
        public override void Sayhello()
        {
            Console.WriteLine("我是美国人，我叫{0}",this.Name);
        }

    }
}
