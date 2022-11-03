using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2.Interfaces
{
    public interface IPopularity
    {
        public void increasePopularity(int contentId);
        public int mostPopular();
        public void decreasePopularity(int contentId);
    }

}
