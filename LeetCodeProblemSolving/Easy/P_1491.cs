using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1491
    {
        public double Average(int[] salary)
        {
            return (salary.Sum() - salary.Max() - salary.Min()) / Convert.ToDouble(salary.Length - 2);
        }
    }
}
