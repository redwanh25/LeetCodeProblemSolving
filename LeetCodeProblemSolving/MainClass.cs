using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_443 obj = new P_443();

            char[] arr1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            //int[][] coordinates = new int[][] { new int[] { -4, -3 }, new int[] { 1, 0 }, new int[] { 3, -1 }, new int[] { 0, -1 }, new int[] { -5, 2 } };

            var res = obj.Compress(arr1);
            Console.WriteLine(res);
        }
    }
}
