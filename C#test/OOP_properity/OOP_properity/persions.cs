using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_properity
{
    class persions
    {
        //字段，属性，方法
        string _name;   //类中的字段默认是private
        public string name  //定义属性
        {
            get { return _name; }   //取值设定
            set { _name = value;}   //赋值设定
        }
        int _age;
        public int age
        {
            get { return _age; }
            set 
            {
                if (value > 100 || value < 0)
                {
                    value = 21;
                }
                _age = value; 
            }
        }
        char _gendar;       //字段
        public char gendar      //属性
        {
            get 
            { 
                return _gendar;
            }
            set 
            {
                if (_gendar != '男' && _gendar != '女')
                {
                    value='男';
                }
                _gendar = value;
            }
        }
        public void hello()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，是个天真可爱的{2}生",this.name,this.age,this.gendar);   //凡是与外界打交道的都是属性，不是字段,如果输出的是字段，那就可能没有执行到get()里面的初始化过程
        }
    }
}
