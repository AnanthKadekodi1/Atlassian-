using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter
{
    public class Anagrams
    {

        public List<List<string>> GroupAnagrams(string[] strs)
        {
            List<List<string>> result = new List<List<string>>();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] charArray = strs[i].ToCharArray();

                Array.Sort(charArray);

                string keyString = new string(charArray);

                if(!dict.TryAdd())
            }
        }
    }
}
