using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_389
    {
        public char FindTheDifference(string s, string t)
        {
            char x = '\0';
            foreach (char c in t)
            {
                if (s.Contains(c))
                    s = s.Remove(s.IndexOf(c), 1);
                else
                    x = c;
            }
            return x;
        }
    }
}
