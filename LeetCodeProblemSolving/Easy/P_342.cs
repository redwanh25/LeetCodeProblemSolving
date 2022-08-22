using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_342
    {
        public bool IsPowerOfFour(int n)
        {
            return Math.Log(n, 4) % 1 == 0;
        }
    }
}
