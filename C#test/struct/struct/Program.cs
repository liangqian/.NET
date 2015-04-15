using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    public struct person        //用于定义变量，方便，可以减少定义的变量、只是定义一次就行了啊；
    {
        public string name;     //提供了public的调用
        public int age;
        public genda Garde;     //在结构中使用枚举变量
    }
            //变量在程序运行的时候只能储存一个值，但是字段可以储存多个变量
    public enum genda
    {
        male,
        female
    }
    public struct Mycolor
    {
        public int _red;        //给字段起名的时候，在前面加上下划线，以区分变量
        public int _blue;
        public int _green;
    }
    class Program
    {
        static void Main(string[] args)
        {
            person lq;
            lq.age = 21;
            lq.name = "Roy";
            lq.Garde = genda.male;  //赋的值是枚举类型，要按照枚举类型的格式进行
            person ls;
            ls.name = "leishan";
            ls.age = 21;
            ls.Garde = genda.female;
            Console.WriteLine("我是{0},今年{1}岁，是{2}生；",lq.name,lq.age,lq.Garde);
            Console.WriteLine("My girl Friend is {0},{1}-year-old,is a {2}",ls.name,ls.age,ls.Garde);
            Console.ReadKey();
            Mycolor mc;
            mc._red = 255;
            mc._green = 0;
            mc._blue = 0;
        }
    }
}
