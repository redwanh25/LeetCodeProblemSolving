using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_724
    {
        public int PivotIndex(int[] nums)
        {
            int right = nums.Sum(), left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                right -= nums[i];
                if(right == left)
                {
                    return i;
                }
                left += nums[i];
            }

            return -1;
        }
    }
}
