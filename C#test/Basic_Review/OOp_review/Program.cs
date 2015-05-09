using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOp_review
{
    class Program
    {
        /// <summary>
        /// 24.	创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。
        /// 再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee em = new Employee();
            em.SayHi();
        }
    }
}
