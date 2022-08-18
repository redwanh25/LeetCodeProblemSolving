using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_1338
    {
        public int MinSetSize(int[] arr)
        {
            int half = arr.Length / 2;
            int[] groupBySortedArr = arr.GroupBy(x => x).Select(y => y.Count()).OrderByDescending(z => z).ToArray();

            for(int i = 0, sum = 0; i < arr.Length; i++)
            {
                sum += groupBySortedArr[i];
                if(sum >= half)
                {
                    return i+1;
                }
            }

            return 0;
        }
    }
}

