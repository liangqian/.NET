using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_test
{
    class persion
    {
        public string _name;
        private int _age;
        private char _Gendar;

        public int age
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 21;
                }
                _age = value;
            }
            get { return _age; }
        }
        public char Gendar
        {
            get { return _Gendar; }     //对属性的取值设定
            set                         //对属性赋值
            {
                if (value != '男' && value != '女')
                {
                    value = '男';
                }
                _Gendar = value;
            }
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，{2}生，我可以哟~~",this._name,this._age,this._Gendar);
        }
        public  void hao()
        {
            Console.WriteLine("{0} {1} {2}",this.age,this.Gendar,this._name);
        }
    }
}
