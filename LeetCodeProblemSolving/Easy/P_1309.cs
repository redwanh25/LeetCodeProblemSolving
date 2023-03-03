using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1309
    {
        public string FreqAlphabets(string s)
        {
            string str = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                    str += (char)('a' + ((s[--i] - '0') + ((s[--i] - '0') * 10) - 1));
                else
                    str += (char)('a' + (s[i] - '0' - 1));
            }
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public string FreqAlphabets_Old(string s)
        {
            Dictionary<string, string> result = new Dictionary<string, string> {
                { "10#", "j" }, { "11#", "k" }, { "12#", "l" }, { "13#", "m" }, { "14#", "n" }, { "15#", "o" }, { "16#", "p" }, { "17#", "q" },
                { "18#", "r" }, { "19#", "s" }, { "20#", "t" }, { "21#", "u" }, { "22#", "v" }, { "23#", "w" }, { "24#", "x" }, { "25#", "y" },
                { "26#", "z" },
                { "1", "a" }, { "2", "b" }, { "3", "c" }, { "4", "d" }, { "5", "e" }, { "6", "f" }, { "7", "g" }, { "8", "h" }, { "9", "i" }
            };

            foreach (string key in result.Keys)
                s = s.Replace(key, result[key]);

            return s;
        }
    }
}
