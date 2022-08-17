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
            P_3 obj = new P_3();

            string str = "abcabcbb";
            int res = obj.LengthOfLongestSubstring(str);

            Console.WriteLine(res);
        }
    }
}
