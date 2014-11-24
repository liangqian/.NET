using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @goto
{
    class Program
    {
        static void Main(string[] args)         /*无限循环的函数（goto语句）*/
        {
            start:
            int myInteger = 5;
            goto addval;
            writeResult:
            Console.WriteLine("myInteger = {0}", myInteger);
            goto start;
            addval:
            myInteger += 10;
            goto writeResult;

        }
    }
}
