using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1822
    {
        public int ArraySign(int[] nums)
        {
            BigInteger[] result = new BigInteger[nums.Length];
            for(int i = 0; i < nums.Length; i++)
                result[i] = nums[i];

            BigInteger val = result.Aggregate((x, y) => x * y);
            return val == 0 ? 0 : (val > 0 ? 1 : -1);
        }
    }
}
