using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter
{
    public class Comparator
    {
        public string CompareVotes(Dictionary<char, int[]> votesRecord, int len)
        {
            var list = votesRecord.Keys.ToList();
            list.Sort((a, b) => {

                for (int i = 0; i < len; i++)
                {
                    if (votesRecord[a][i] != votesRecord[b][i])
                    {
                        return votesRecord[b][i] - votesRecord[a][i];
                    }
                }

                return a - b;
            });

            return new string(list.ToArray());
        }
    }
}
