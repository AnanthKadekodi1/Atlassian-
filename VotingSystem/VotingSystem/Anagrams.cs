using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //Create a result list to return
            List<IList<string>> result = new List<IList<string>>();
            //Create a dictionary
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            //Iterate through each word in the strs array.
            for (int i = 0; i < strs.Length; i++)
            {
                //Convert strs[i] to a char array
                char[] charArray = strs[i].ToCharArray();
                //Sort the array
                Array.Sort(charArray);
                //Create a key value from the char array. 
                string keyString = new string(charArray);
                //Try to add it to the dictionary.
                //This method returns a boolean, so if it is false, then we can add our current string to the existing list.
                if (!dict.TryAdd(keyString, new List<string>() {strs[i]}))
                {
                    //add the current string to the existing list if it already exists in the dictionary.
                    dict[keyString].Add(strs[i]);
                }
            }

            //Loop through each pair in the dictionary
            foreach (var pair in dict)
            {
                //Add the list from each key value to the result list. 
                result.Add(pair.Value);
            }

            return result;
        }
    }
}
