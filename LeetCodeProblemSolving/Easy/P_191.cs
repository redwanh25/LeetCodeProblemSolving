using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_191
    {
        public int HammingWeight(uint n)
        {
            //uint c = 0;
            //while (n > 0)
            //{
            //    c += n & 1; // or: c += n % 2;
            //    n >>= 1;    // or: n /= 2;
            //}
            //return (int)c;

            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
