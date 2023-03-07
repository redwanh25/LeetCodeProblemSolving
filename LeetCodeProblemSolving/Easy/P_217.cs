using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() > 1).Any();
        }
    }
}
