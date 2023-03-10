using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_989
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            BigInteger bigInteger = BigInteger.Parse(string.Join("", num)) + k;
            return bigInteger.ToString().Select(x => x - '0').ToList();
        }
    }
}
