using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_1232 obj = new P_1232();

            //int[] arr1 = new int[] { 1, 3, 5, 2, 4 };
            int[][] coordinates = new int[][] { new int[] { -4, -3 }, new int[] { 1, 0 }, new int[] { 3, -1 }, new int[] { 0, -1 }, new int[] { -5, 2 } };
            //string s1 = "bank", s2 = "kanb";

            var res = obj.CheckStraightLine(coordinates);
            Console.WriteLine(res);
        }
    }
}
