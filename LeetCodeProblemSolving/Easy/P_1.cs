using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            foreach (int i in nums)
            {
                if (target - i == i)
                {
                    if (nums.Count(x => x == i) == 2)
                    {
                        res[0] = Array.IndexOf(nums, i);
                        res[1] = Array.LastIndexOf(nums, i);
                        break;
                    }      
                }
                else
                {
                    int v = target - i;
                    if (nums.Contains(v))
                    {
                        res[0] = Array.IndexOf(nums, i);
                        res[1] = Array.IndexOf(nums, v);
                        break;
                    }
                }
            }
            return res;
        }
    }
}
