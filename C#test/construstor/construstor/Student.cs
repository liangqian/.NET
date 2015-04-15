using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construstor
{
    public class Student
    {
        //析构函数

        ~Student()  //析构函数在程序执行完了之后才执行，用于释放内存，通过GC（garbage collection）//垃圾回收
        {
            Console.WriteLine("调用");
        }

        public Student(string name,int age,char gendar,int chinese,int math,int english)        //首先执行构造函数
        {
            this.Name = name;
            this.Age = age;
            this.Gendar = gendar;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
 
        }
        public Student(string name, int chinese, int math, int english)
            : this(name,0,'c',chinese,math,english)     //去调用上面那个构造函数
        {
            //避免在这里再赋值；
        }




        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }    //在get里判断字段
            set 
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }   //在set里判断value
        }

        private char _gendar;
        public char Gendar
        {
            get { return _gendar; }
            set
            {
                if (value != '男' && value != '女')
                {
                    value ='男';
                }
                _gendar = value; 
            }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set 
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                _chinese = value;
            }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set 
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                _math = value;
            }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set 
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                _english = value;
            }
        }
        public void Sayhello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，是个{2}生。",this.Name,this.Age,this.Gendar);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，平均成绩是{2}；", this.Name, this.Chinese + this.Math + this.English, (this.Chinese + this.Math + this.English) / 3);
        }

    }
}
