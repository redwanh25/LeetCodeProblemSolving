using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_66
    {
        public int[] PlusOne(int[] digits)
        {
            BigInteger bigInteger = BigInteger.Parse(string.Join("", digits)) + 1;
            int[] arr = bigInteger.ToString().Select(x => x - '0').ToArray();
            return arr;
        }
    }
}
