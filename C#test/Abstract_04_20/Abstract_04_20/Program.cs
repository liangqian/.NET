using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_04_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入图像半径");
            string inputStr = Console.ReadLine();
            int Input = Convert.ToInt32(inputStr);
            Shape shape = new Circle(Input);
            double area = shape.GetArea();
            double perimeter = shape.Getperimeter();
            Console.WriteLine("这个图形的面积是{0}，周长是{1}",area,perimeter);
        }

        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double Getperimeter();
        }
        public class Circle : Shape
        {
            public string ShApe = "圆形";
            private double _r;
            public double R
            {
                get { return _r; }
                set { _r = value; }
            }
            public override double GetArea()
            {
                return Math.PI * this.R * this.R;
                //throw new NotImplementedException();
            }
            public override double Getperimeter()
            {
                return 2 * Math.PI * this.R;
                //throw new NotImplementedException();
            }
            public Circle(double r)
            {
                this.R = r;
            }

        }
        public class Square : Shape
        {
            public string ShApe = "长方形";
            private double _height;
            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }
            private double _width;
            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }
            public Square(double height, double width)
            {
                this.Height = height;
                this.Width = width;
            }
            public override double GetArea()
            {
                return this.Height * this.Width;
                //throw new NotImplementedException();
            }
            public override double Getperimeter()
            {
                return 2 * this.Width * this.Height;
                //throw new NotImplementedException();
            }


        }
    }
}
