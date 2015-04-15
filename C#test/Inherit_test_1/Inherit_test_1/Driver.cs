using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_test_1
{
    class Driver : Persion    //继承父类
    {

        public Driver(string name, int age, char gendar, int driverTime)
            : base(name, age, gendar)           //使用base()，关键字来调用父类中的构造函数来赋值，避免代码冗余
        {
            this.DriverTime = driverTime;
        }


        private int _driverTime;
        public int DriverTime
        {
            get { return _driverTime; }
            set { _driverTime = value; }
        }


        public void Drive()
        {
            Console.WriteLine("我是{0}，今年{1}岁,是个{2}孩子，开了{3}年的车",this.Name,this.Age,this.Gendar,this.DriverTime);
        }
    }
}
