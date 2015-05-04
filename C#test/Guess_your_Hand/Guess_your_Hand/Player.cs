using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_your_Hand
{
    class Player
    {
        public int ShowFist(string fist)
        {
            //根据出拳的情况返回数字
            int num = 0;
            switch (fist)
            {
                case "石头": num = 1;
                    break;
                case "剪刀": num = 2;
                    break;
                case "布": num = 3;
                    break;
            }
            return  num;
        }
    }
}
