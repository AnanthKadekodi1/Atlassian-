using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge2.Interfaces;

namespace CodeChallenge2.PopularityService
{
    public class Popularity : IPopularity
    {
        private Dictionary<int, int> _popDict;
        int initialPop = 1;

        public Popularity()
        {
            _popDict = new Dictionary<int, int>();
        }

        public void decreasePopularity(int contentId)
        {
            if (_popDict[contentId] > 0)
            {
                _popDict[contentId] -= 1;
            }
        }

        public void increasePopularity(int contentId)
        {
            
            if (_popDict.ContainsKey(contentId))
            {
                _popDict[contentId]++;
            }
            else
            {
                _popDict.Add(contentId,initialPop);
            }

        }

        public int mostPopular()
        {
            var numberOfZeroValues = _popDict.Where(x => x.Value > 0).Select(x => x.Value);
            if (numberOfZeroValues.Count() != 0)
            {
                return _popDict.MaxBy(x => x.Value).Key;
            }
            else
            {
                return -1;
            }
        }
    }
}

//popularity o