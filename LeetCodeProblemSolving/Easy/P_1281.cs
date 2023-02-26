using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1281
    {
        public int SubtractProductAndSum(int n)
        {
            List<int> list = n.ToString().Select(x => x - '0').ToList();
            return list.Aggregate((a, b) => a * b) - list.Aggregate((a, b) => a + b);
        }
    }
}
