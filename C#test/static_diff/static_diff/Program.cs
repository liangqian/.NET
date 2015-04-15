using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            persion lq = new persion(); //
            lq.M1();    //实例成员  ，   非静态字段要实例化对象之后才能调用
            m3();
            persion.M2();   //静态方法直接在类之后调用
            Console.ReadKey();
            
        }
        public static void m3()
        {
            persion.M2();   //静态方法的调用，只要是静态成员，都要使用类名去调用
        }

    }
}
