using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_66 obj = new P_66();

            int[] arr = new int[] { 4, 3, 2, 1 };

            var res = obj.PlusOne(arr);
            Console.WriteLine(res);
        }
    }
}
