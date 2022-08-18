using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_3
    {
        public int LengthOfLongestSubstring(string str)
        {
            List<string> list = new List<string>();
            if(str.Length == 0 || str.Length == 1)
            {
                return str.Length;
            }
            else
            {
                string temp_str = "";
                for (int i = 1; i < str.Length; i++)
                {
                    temp_str += str[i - 1];
                    if (temp_str.Contains(str[i]))
                    {
                        list.Add(temp_str);
                        temp_str = "";
                    }
                }
                if (!temp_str.Contains(str[str.Length-1]))
                {
                    temp_str += str[str.Length - 1];
                    list.Add(temp_str);
                }
                return list.Max(x => x.Length);
            }
        }
    }
}
