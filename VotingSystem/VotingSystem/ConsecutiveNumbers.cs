using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    /**
     * Given an integer n, return the number of ways you can write n as the sum of consecutive positive integers.

 

    Example 1:

    Input: n = 5
    Output: 2
    Explanation: 5 = 2 + 3
    Example 2:

    Input: n = 9
    Output: 3
    Explanation: 9 = 4 + 5 = 2 + 3 + 4
    Example 3:

    Input: n = 15
    Output: 4
    Explanation: 15 = 8 + 7 = 4 + 5 + 6 = 1 + 2 + 3 + 4 + 5
     

    Constraints:

    1 <= n <= 109
     */
    public class ConsecutiveNumbers
    {
        public int ConsecutiveNumbersSum(int n)
        {
            var cnt = 0;
            n -= 1;
            for (var i = 1; n >= 0; i++, n -= i)
            {
                if (n % i == 0)
                    cnt++;
            }

            return cnt;
        }
    }
}
