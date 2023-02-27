using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_976
    {
        public int LargestPerimeter(int[] nums)
        {
            int perimeter = 0;
            nums = nums.OrderByDescending(x => x).ToArray();
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i - 2] < nums[i - 1] + nums[i])
                {
                    perimeter = nums[i - 2] + nums[i - 1] + nums[i];
                    break;
                }
            }
            return perimeter;
        }
    }
}
