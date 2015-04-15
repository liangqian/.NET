using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_review
{
    public class Ticket
    {
        private double _distance;

        public double distance
        {
            get { return _distance; }   //只能读取
        }

        public Ticket(double distance)     //构造函数，定义了需要输入变量
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        private double _price;
        public double price         //只有输出price的值，才会有执行get
        {
            get
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if(_distance>100&&_distance<=200)
                {
                    return _distance * 0.95;
                 }
                else if (_distance > 200 && _distance <=300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
        }

        public void Showticket()
        {
            Console.WriteLine("你{0}公里，需要给{1}元；",this.distance,this.price);
        }



    }
}
