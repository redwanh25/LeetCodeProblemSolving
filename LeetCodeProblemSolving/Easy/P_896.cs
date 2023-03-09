using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_896
    {
        public bool IsMonotonic(int[] nums)
        {
            var nums1 =  nums.OrderBy(x => x).ToArray();
            var nums2 =  nums.OrderByDescending(x => x).ToArray();
            return nums.SequenceEqual(nums1) || nums.SequenceEqual(nums2) ? true : false;
        }
    }
}
