using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_283
    {
        public void MoveZeroes(int[] nums)
        {
            List<int> list = nums.Where(x => x != 0).ToList();
            list.AddRange(nums.Where(x => x == 0).ToArray());
            int i = 0;
            foreach (int x in list)
                nums[i++] = x;
        }
    }
}
