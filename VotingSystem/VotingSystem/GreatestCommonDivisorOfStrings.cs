using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    /*
     *For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

        Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

 

        Example 1:
    
        Input: str1 = "ABCABC", str2 = "ABC"
        Output: "ABC"
        Example 2:

        Input: str1 = "ABABAB", str2 = "ABAB"
        Output: "AB"
        Example 3:

        Input: str1 = "LEET", str2 = "CODE"
        Output: ""
 

        Constraints:

        1 <= str1.length, str2.length <= 1000
        str1 and str2 consist of English uppercase letters.
     *
     */
    public class GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            //Step 1: check any uncommon char
            if (str1 + str2 != str2 + str1)
                return "";

            //Step 2: find out the common divisible # of repeats
            int maxLength = Math.Max(str1.Length, str2.Length);
            int minLength = Math.Min(str1.Length, str2.Length);
            int remainder = maxLength % minLength;

            if (remainder == 0)
                return str1.Substring(0, minLength);

            while (minLength % remainder != 0)
            {
                maxLength = minLength;
                minLength = remainder;
                remainder = maxLength % minLength;
            }

            return str1.Substring(0, remainder);
        }
    }
}
