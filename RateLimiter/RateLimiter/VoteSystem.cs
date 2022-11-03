using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter
{
    public class VoteSystem
    {
        public VoteSystem()
        {

        }

        public string RankByVotesChar(string[] votes)
        {
            Dictionary<char, int[]> votesRecord = new Dictionary<char, int[]>();
            var len = votes[0].Length;

            foreach (var vote in votes)
            {
                for (int i = 0; i < len; i++)
                {
                    var ch = vote[i];

                    if (!votesRecord.ContainsKey(ch))
                    {
                        votesRecord.Add(ch, new int[len]);
                    }
                    else
                    {
                        votesRecord[ch][i]++;
                    }
                }
            }

            Comparator cmp = new Comparator();
            return cmp.CompareVotes(votesRecord, len);
        }

    }
}
