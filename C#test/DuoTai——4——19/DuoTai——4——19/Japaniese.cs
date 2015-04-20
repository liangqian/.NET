using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai__4__19
{
    class Japaniese:Person
    {
        public Japaniese(string name)
            : base(name)
        {
 
        }
        public override void Sayhello()
        {
            Console.WriteLine("我是日本人，我叫{0}",this.Name);
        }
    }
}
