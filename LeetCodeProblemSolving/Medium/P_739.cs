using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] arr = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                for (int j = i+1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        arr[i] = j - i;
                        break;
                    }
                }
            }

            return arr;
        }
    }
}
