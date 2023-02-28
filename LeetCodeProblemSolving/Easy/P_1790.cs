using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1790
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else if (s1.Length <= 2)
                return false;

            int cnt = 0;
            int[] index = new int[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    index[cnt] = i;
                    cnt++;
                }
            }
            if (cnt == 2)
                return s1[index[0]] == s2[index[1]] && s1[index[1]] == s2[index[0]] ? true : false;
            else
                return false;
        }
    }
}
