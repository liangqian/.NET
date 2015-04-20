using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai__4__19
{
    class Chinese:Person
    {
        public Chinese(string name)
            : base(name)
        {
 
        }
        public override void Sayhello()
        {
            Console.WriteLine("我是中国人，我叫{0}",this.Name);
        }
    }
}
