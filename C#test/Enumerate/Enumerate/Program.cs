using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerate
{
    enum orientation : byte  //先定义一个枚举集合，再在后面调用(类型定义代码放在名称空间中)
    {
        north = 1,  //这是逗号。。。
        south = 2,
        east = 3,
        weat = 4,
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte dirtationByte;
            string dirtationString;
            orientation myDirtation = orientation.north;
            Console.WriteLine("mydirtation = {0}", myDirtation);
            dirtationByte = (byte)myDirtation;
            dirtationString = Convert.ToString(myDirtation);    //效果等同于：dirtationByte = myDirtation.ToString();
            Console.WriteLine("byte equivation = {0}", dirtationByte);
            Console.WriteLine("string equivation = {0}", dirtationString);
            Console.ReadKey();
        }
    }
}
