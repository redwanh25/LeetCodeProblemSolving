using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    public class NumArray
    {
        int[] _nums;
        public NumArray(int[] nums)
        {
            _nums = nums;
        }

        public int SumRange(int left, int right)
        {
            int rs = 0;
            for (int i = left; i <= right; i++)
            {
                rs += _nums[i];
            }
            return rs;
        }
    }

    internal class P_303
    {
    }
}
