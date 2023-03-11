using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_58
    {
        public int LengthOfLastWord(string s)
        {
            return s.Split(' ').LastOrDefault(x => x != "").Length;
        }
    }
}
