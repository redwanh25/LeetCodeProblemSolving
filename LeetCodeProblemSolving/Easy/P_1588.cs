using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1588
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i <= arr.Length; i+=2)
            {
                for(int j = 0; j <= arr.Length-i; j++)
                {
                    for(int k = 0; k < i; k++)
                    {
                        sum += arr[j+k];
                    }
                }
            }
            return sum;
        }
    }
}
