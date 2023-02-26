using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_26 obj = new P_26();

            while (true)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                //int x = Convert.ToInt32(Console.ReadLine());
                var res = obj.RemoveDuplicates(arr);

                Console.WriteLine(res);
            }
        }
    }
}
