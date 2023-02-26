using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_1281 obj = new P_1281();

            while (true)
            {
                //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int x = Convert.ToInt32(Console.ReadLine());
                var res = obj.SubtractProductAndSum(x);

                Console.WriteLine(res);
            }
        }
    }
}
