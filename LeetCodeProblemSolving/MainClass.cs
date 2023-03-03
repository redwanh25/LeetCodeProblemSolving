using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_1309 obj = new P_1309();

            int[] arr2 = new int[] { 0, 1, 0, 3, 12 };
            char[] arr1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int[][] arr3 = new int[][] { new int[] { 1, 5, 2 }, new int[] { 7, 3, 2 }, new int[] { 3, 5, 2 } };
            string str1 = "10#11#12", str2 = "pq";
            int v1 = 1, v2 = 4;

            var res = obj.FreqAlphabets(str1);
            Console.WriteLine(res);

            //obj.MoveZeroes(arr1);
        }
    }
}
