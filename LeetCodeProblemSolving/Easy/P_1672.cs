using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int wealth = 0;
            foreach (int[] arr in accounts)
                wealth = Math.Max(wealth, arr.Sum());

            return wealth;
        }
    }
}
