using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;
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
            P_392 obj = new P_392();

            string s = "abc", t = "ahbgdc";
            var res = obj.IsSubsequence(s, t);

            Console.WriteLine(res);
        }
    }
}
