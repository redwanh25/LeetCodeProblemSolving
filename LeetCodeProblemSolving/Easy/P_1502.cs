using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1502
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            if (arr.Length == 2) return true;

            arr = arr.OrderByDescending(x => x).ToArray();
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i - 2] - arr[i - 1] != arr[i - 1] - arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
