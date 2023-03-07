using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_242
    {
        public bool IsAnagram(string s, string t)
        {
            return new string(s.OrderBy(x => x).ToArray()) == new string(t.OrderBy(x => x).ToArray());
        }
    }
}
