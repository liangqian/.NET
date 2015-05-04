using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_your_Hand
{
    class Judger
    {
        public static Result Judge(int playerNum, int PcNum)
        {
            if (playerNum - PcNum == -1 || playerNum - PcNum == 2)
            {
                return Result.玩家赢;
            }
            else if (playerNum - PcNum == 0)
            {
                return Result.平手啦;
            }
            else
            {
                return Result.电脑赢;
            }
        }
    }
    public enum Result
    {
        玩家赢,
        电脑赢,
        平手啦,
    }
}
