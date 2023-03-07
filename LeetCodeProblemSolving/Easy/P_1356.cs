using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1356
    {
        public int[] SortByBits(int[] arr)
        {
            return arr.OrderBy(x => x)
                      .Select(x => new KeyValuePair<int, int>(x, Convert.ToString(x, 2).Count(y => y == '1')))
                      .OrderBy(x => x.Value)
                      .Select(x => x.Key).ToArray();
        }
    }
}
