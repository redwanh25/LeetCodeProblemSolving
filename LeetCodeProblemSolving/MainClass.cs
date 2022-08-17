using LeetCodeProblemSolving.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_804 obj = new P_804();
            string[] str = { "gin", "zen", "gig", "msg" };
            int res = obj.UniqueMorseRepresentations(str);
            Console.WriteLine(res);
        }
    }
}
