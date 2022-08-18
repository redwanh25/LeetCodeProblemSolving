using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] ints = new int[nums.Length];
            int sum = 0, j = 0;
            foreach (int i in nums)
            {
                sum += i;
                ints[j++] = sum;
            }
            return ints;
        }
    }
}
