using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_13
    {
        public int RomanToInt(string str)
        {
            Dictionary<string, int> priority1 = new Dictionary<string, int> {
                { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 }
            };
            Dictionary<string, int> priority2 = new Dictionary<string, int>{
                { "IV", 4 }, { "IX", 9 }, { "XL", 40 }, { "XC", 90 }, { "CD", 400 }, { "CM", 900 }
            };

            char[] ch = str.ToCharArray() ;
            int res = 0;
            for(int i = ch.Length-1; i >= 0; )
            {
                string s = i == 0 ? "" : ch[i-1] + "" + ch[i];
                if (priority2.ContainsKey(s))
                {
                    res += priority2[s];
                    i = i - 2;
                }
                else
                {
                    res += priority1[ch[i].ToString()];
                    i = i - 1;
                }
            }

            return res;
        }
    }
}
