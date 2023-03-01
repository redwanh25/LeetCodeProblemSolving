using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_912
    {
        public int[] SortArray(int[] nums)
        {
            return nums.OrderBy(x => x).ToArray();
        }
    }
}
