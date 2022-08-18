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
            P_1338 obj = new P_1338();

            int[] arr = { 7, 7, 7, 7, 7, 7 };
            int res = obj.MinSetSize(arr);

            Console.WriteLine(res);
        }
    }
}
