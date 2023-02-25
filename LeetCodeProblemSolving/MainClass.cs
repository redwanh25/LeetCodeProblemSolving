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
            P_1523 obj = new P_1523();

            while (true)
            {
                //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                //var res = obj.CountOdds(arr);
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                var res = obj.CountOdds(x, y);

                Console.WriteLine(res);
            }
        }
    }
}
