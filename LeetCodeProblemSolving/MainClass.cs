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
            P_724 obj = new P_724();

            int[] arr = { 1, 7, 3, 6, 5, 6 };
            var res = obj.PivotIndex(arr);

            Console.WriteLine(res);
        }
    }
}
