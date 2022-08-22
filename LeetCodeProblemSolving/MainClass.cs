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
            P_342 obj = new P_342();

            int x = 16;
            var res = obj.IsPowerOfFour(x);

            Console.WriteLine(res);
        }
    }
}
