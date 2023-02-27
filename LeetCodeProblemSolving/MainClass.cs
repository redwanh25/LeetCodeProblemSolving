using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_976 obj = new P_976();

            int[] arr = new int[] { 1, 2, 1, 10 };

            var res = obj.LargestPerimeter(arr);
            Console.WriteLine(res);
        }
    }
}
