using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class ArrangeCoins
    {
        public int ArrangeCoinsCalculate(int n)
        {


            int cRows = 0;
            int stair = 1;
            while (n >= stair)
            {
                cRows++;
                n -= stair;
                stair++;
            }
            return cRows;

        }
    }
}
