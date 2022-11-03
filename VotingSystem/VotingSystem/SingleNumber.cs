using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    /**
         * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

    You must implement a solution with a linear runtime complexity and use only constant extra space.

     

    Example 1:

    Input: nums = [2,2,1]
    Output: 1
    Example 2:

    Input: nums = [4,1,2,1,2]
    Output: 4
    Example 3:

    Input: nums = [1]
    Output: 1
     */
    public class SingleNumber
    {
        public int GetSingleNumber(int[] nums)
            {
                var dict = new Dictionary<int, int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                        dict.Remove(nums[i]);
                    else
                        dict.Add(nums[i], nums[i]);
                }
                foreach (var i in dict.Keys) return i;
                return int.MaxValue;
            }
    }
}
