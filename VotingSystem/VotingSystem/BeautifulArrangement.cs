using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    /**
     * Suppose you have n integers labeled 1 through n. A permutation of those n integers perm (1-indexed) is considered a beautiful arrangement if for every i (1 <= i <= n), either of the following is true:

    perm[i] is divisible by i.
    i is divisible by perm[i].
    Given an integer n, return the number of the beautiful arrangements that you can construct.

     

    Example 1:

    Input: n = 2
    Output: 2
    Explanation: 
    The first beautiful arrangement is [1,2]:
        - perm[1] = 1 is divisible by i = 1
        - perm[2] = 2 is divisible by i = 2
    The second beautiful arrangement is [2,1]:
        - perm[1] = 2 is divisible by i = 1
        - i = 2 is divisible by perm[2] = 1
    Example 2:

    Input: n = 1
    Output: 1
     

    Constraints:

    1 <= n <= 15
     */

    public class BeautifulArrangement
    {
        public int CountArrangement(int n)
        {
            var masks = new List<int>();
            for (int i = 0; i < n; i++)
            {
                masks.Add(1 << i);
            }
            var newMas = new List<int>();
            for (int sequence = 2; sequence <= n; sequence++)
            {
                for (int number = 1; number <= n; number++)
                {
                    if (sequence % number == 0 || number % sequence == 0)
                    {
                        var testBitNumberInUse = 1 << (number - 1);
                        for (int q = 0; q < masks.Count; q++)
                        {
                            if ((masks[q] & testBitNumberInUse) == 0)
                            {
                                newMas.Add(masks[q] + testBitNumberInUse);
                            }
                        }
                    }
                }
                masks = newMas;
                newMas = new List<int>();
            }
            return masks.Count;
        }
    }
}
