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
            P_1480 obj = new P_1480();

            int[] arr = { 3, 1, 2, 10, 1 };
            var res = obj.RunningSum(arr);

            Console.WriteLine(res);
        }
    }
}
