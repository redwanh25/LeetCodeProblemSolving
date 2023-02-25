using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1523
    {
        public int CountOdds(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++) { 
                if(i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
