using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_4_3
{
    class Persion
    {
        //字段，属性，方法
        //字段：存储数据
        //属性：保护字段，对字段的取值和赋值进行限定
        //方法：描述对象的行为
        //构造函数：初始化对象（依次赋值）
        //类中的成员如果没有加访问修饰符，默认private

        string _name;
        //属性的本质就是两个方法


        public string Name
        {
            get { return _name; }   //打印
            set { _name = value; }  //赋值
        }

        int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0 || value >= 100)
                {
                    value = 20;
                }
                _age = value;
            }
        }

        char _gendar;

        public char Gendar
        {
            get { return _gendar; }
            set { _gendar = value; }
        }
        //this : 当前类的对象
          //    2、调用当前类的构造函数
        public void Sayhello()
        {
            string Name = "张";      //下面使用了this，避免了混淆name的取值
            Console.WriteLine("{0},{1},{2}",this.Name,this.Age,this.Gendar);
        }


        //静态函数内不能访问到实例化的参数，比如_name,...  ; 只能访问静态成员
        //静态类中不能创建对象
        public static void Sayhi()
        {
            _id = 10;
            Console.WriteLine("静态调用{0}",_id);
        }

        private static int _id;

        //构造函数：1、没有返回值，连void也没有
                    //2、构造函数的名称跟类名一样
        public Persion(string name,int age,char gendar)
        {
            this.Name = name;
            this.Age = age;
            if (gendar != '男' && gendar != '女')
            {
                gendar = '男';
            }
            this.Gendar = gendar;
        }

        public Persion(string name, char gendar):this(name,0,gendar)    //this的第二个作用:调用当前类的构造函数
        {
            //this.Name = name;
            //this,gendar=gendar;
        }

    }
}
