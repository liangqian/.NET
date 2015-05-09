using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOp_review
{
    /// <summary>
    /// 24.	创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。
    /// 再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。
    /// </summary>
    class Persion
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        private string _gendar;
        public string Gendar
        {
            get { return _gendar; }
            set { _gendar = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public virtual void SayHi()
        {
            Console.WriteLine("父类hello");
        }

    }
}
