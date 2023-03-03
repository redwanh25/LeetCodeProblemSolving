using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            string str = "";
            for(int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                str += (i < word1.Length ? word1[i] : "") + "" + (i < word2.Length ? word2[i] : "");
            }

            return str;
        }
    }
}
