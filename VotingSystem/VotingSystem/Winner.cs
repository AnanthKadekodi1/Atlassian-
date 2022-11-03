using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class Winner
    {
        public Winner()
        {

        }
        public string FindWinner(String[] votes)
        {
            if (votes.Length == 0)
            {
                throw new ArgumentException("Number of votes are 0");
            }
            // Insert all votes in a hashmap
            Dictionary<String, int> map
                = new Dictionary<String, int>();
            foreach (String str in votes)
            {
                if (map.ContainsKey(str))
                    map[str] = map[str] + 1;
                else
                    map.Add(str, 1);
            }

            // Traverse through map to find the candidate
            // with maximum votes.
            int maxValueInMap = 0;
            String winner = "";
            foreach (KeyValuePair<String, int> entry in map)
            {
                String key = entry.Key;
                int val = entry.Value;
                if (val > maxValueInMap)
                {
                    maxValueInMap = val;
                    winner = key;
                }

                // If there is a tie, pick lexicographically
                // smaller.
                else if (val == maxValueInMap
                         && winner.CompareTo(key) > 0)
                    winner = key;
            }
            return winner;
        }
        public string RankTeams(string[] votes)
        {
            int n = votes.Length;
            int m = votes[0].Length;

            // position counter
            Dictionary<char, int>[] arr = new Dictionary<char, int>[m];
            for (int j = 0; j < m; j++)
            {
                // frequency for the jth place
                arr[j] = new Dictionary<char, int>();
                for (int i = 0; i < n; i++)
                {
                    char c = votes[i][j];
                    arr[j][c] = 1 + (arr[j].ContainsKey(c) ? arr[j][c] : 0);
                }
            }

            // create a character array of all the teams
            char[] ans = votes[0].ToCharArray();

            // sort the teams using the position counter
            Array.Sort(ans, (c1, c2) =>
            {
                for (int i = 0; i < m; i++)
                {
                    int ch1 = arr[i].ContainsKey(c1) ? arr[i][c1] : 0;
                    int ch2 = arr[i].ContainsKey(c2) ? arr[i][c2] : 0;
                    if (ch1 == ch2) continue;
                    return ch2 - ch1;
                }
                // if the execution reached this point, it mean the teams are tied. So, we compare them alphabetically.
                return c1 - c2;
            });

            return string.Join("", ans);
        }

    }
}
