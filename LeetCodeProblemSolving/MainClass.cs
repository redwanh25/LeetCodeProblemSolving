using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_1790 obj = new P_1790();

            //int[] arr = new int[] { 13, 12, -12, 9, 9 };
            string s1 = "bank", s2 = "kanb";

            var res = obj.AreAlmostEqual(s1, s2);
            Console.WriteLine(res);
        }
    }
}
