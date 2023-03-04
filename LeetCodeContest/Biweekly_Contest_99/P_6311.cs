using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeContest.Biweekly_Contest_99
{
    internal class P_6311
    {
        public long ColoredCells(int n)
        {
           return (long)(Math.Pow(n-1, 2) + Math.Pow(n, 2));
        }
    }
}
