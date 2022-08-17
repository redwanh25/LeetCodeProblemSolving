using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_9
    {
        public bool IsPalindrome(int x)
        {
            string s1 = x.ToString();
            string s2 = new string(x.ToString().Reverse().ToArray());

            return s1 == s2;
        }
    }
}
