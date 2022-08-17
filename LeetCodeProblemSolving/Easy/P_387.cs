using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_387
    {
        public int FirstUniqChar(string str)
        {
            char? ch = str.GroupBy(x => x).Where(y => y.Count() == 1).Select(z => z.Key).FirstOrDefault();
            return ch == null ? -1 : str.IndexOf((char) ch);
        }
    }
}
