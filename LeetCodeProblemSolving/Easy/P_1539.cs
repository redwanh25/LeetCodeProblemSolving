using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1539
    {
        public int FindKthPositive(int[] arr, int k)
        {
            List<int> list = Enumerable.Range(1, 2000).Except(arr).ToList();
            return list[k-1];
        }
    }
}
