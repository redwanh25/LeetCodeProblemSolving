using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> list = nums.GroupBy(x => x).Where(x => x.Count() >= 1).Select(x => x.Key).ToList();
            for (int i = 0; i < list.Count(); i++)
                nums[i] = list[i];

            return list.Count();
        }
    }
}

