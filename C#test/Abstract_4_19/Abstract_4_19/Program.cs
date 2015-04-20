using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Bark();

        }

        public abstract class Animal    //抽象类不允许创建对象
        {
            public abstract void Bark();    //抽象函数没有方法体
 
        }
        public class Dog : Animal
        {
            public override void Bark()
            {
                Console.WriteLine("狗狗汪汪叫");
            }
        }
        public class Cat : Animal
        {
            public override void Bark()
            {
                Console.WriteLine("猫咪喵喵叫");
            }
        }
    }
}
