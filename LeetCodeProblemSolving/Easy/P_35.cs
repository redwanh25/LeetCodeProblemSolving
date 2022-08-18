using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_35
    {
        public int SearchInsert(int[] nums, int target)
        {
            List<int> result = nums.ToList();
            result.Add(target);
            return result.OrderBy(x => x).ToList().IndexOf(target);
        }
    }
}
