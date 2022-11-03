using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {

            Dictionary<char, char> dc = new Dictionary<char, char>();
            dc.Add(')', '(');
            dc.Add(']', '[');
            dc.Add('}', '{');

            int i = 0;
            Stack<char> stack = new Stack<char>();
            while (i < s.Length)
            {
                if (dc.ContainsKey(s[i]))
                {
                    var z = s[i];
                    if (stack.Count == 0) return false;
                    var x= dc[s[i]];
                    var y = stack.Pop();
                    if (dc[s[i]] != stack.Pop())
                        return false;
                }
                else
                    stack.Push(s[i]);

                i++;
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }

}
