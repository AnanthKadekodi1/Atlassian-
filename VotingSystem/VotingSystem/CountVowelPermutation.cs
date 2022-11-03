using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    /**
     * Given an integer n, your task is to count how many strings of length n can be formed under the following rules:

    Each character is a lower case vowel ('a', 'e', 'i', 'o', 'u')
    Each vowel 'a' may only be followed by an 'e'.
    Each vowel 'e' may only be followed by an 'a' or an 'i'.
    Each vowel 'i' may not be followed by another 'i'.
    Each vowel 'o' may only be followed by an 'i' or a 'u'.
    Each vowel 'u' may only be followed by an 'a'.
    Since the answer may be too large, return it modulo 10^9 + 7.

     

    Example 1:

    Input: n = 1
    Output: 5
    Explanation: All possible strings are: "a", "e", "i" , "o" and "u".
    Example 2:

    Input: n = 2
    Output: 10
    Explanation: All possible strings are: "ae", "ea", "ei", "ia", "ie", "io", "iu", "oi", "ou" and "ua".
    Example 3: 

    Input: n = 5
    Output: 68
     

    Constraints:

    1 <= n <= 2 * 10^4
     */
    public class CountVowelPermutation
    {
        public int CountVowelPermutationtest(int n)
        {
            long[][] dp = new long[n][];
            for (int j = 0; j < n; j++)
                dp[j] = new long[5];

            const int a = 0, e = 1, i = 2, o = 3, u = 4, mod = 1000000007;
            dp[0][a] = dp[0][e] = dp[0][i] = dp[0][o] = dp[0][u] = 1;
            for (int j = 1; j < n; j++)
            {
                dp[j][a] = (dp[j - 1][e] + dp[j - 1][i] + dp[j - 1][u]) % mod;
                dp[j][e] = (dp[j - 1][a] + dp[j - 1][i]) % mod;
                dp[j][i] = (dp[j - 1][e] + dp[j - 1][o]) % mod;
                dp[j][o] = (dp[j - 1][i]) % mod;
                dp[j][u] = (dp[j - 1][i] + dp[j - 1][o]) % mod;
            }

            return (int)((dp[n - 1][a] + dp[n - 1][e] + dp[n - 1][i] + dp[n - 1][o] + dp[n - 1][u]) % mod);
        }
    }
}
