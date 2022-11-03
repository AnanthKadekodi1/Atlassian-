using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class GreatestCommonDivisor
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string longerString = str1.Length > str2.Length ? str1 : str2;
            string shorterString = str1.Length > str2.Length ? str2 : str1;
            StringBuilder sb = new StringBuilder();
            string divides = string.Empty;

            for (int i = 0; i < longerString.Length; i++)
            {
                sb.Append(longerString[i]);
                String temp = sb.ToString();
                if ((shorterString.Length % temp.Length == 0) && Divides(temp, str1) && Divides(temp, str2))
                {
                    divides = temp;
                }
            }
            return divides;
        }
        private bool Divides(string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();

            while (sb.Length < s2.Length)
            {
                sb.Append(s1);
            }
            return s2.Equals(sb.ToString());
        }
    }
}
