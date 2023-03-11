using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Hard;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            ListNode lNode4 = new ListNode(9, null);
            ListNode lNode3 = new ListNode(5, lNode4);
            ListNode lNode2 = new ListNode(0, lNode3);
            ListNode lNode1 = new ListNode(-3, lNode2);
            ListNode lNode0 = new ListNode(-10, lNode1);
            ListNode lHead = lNode0;

            TreeNode tNode4 = new TreeNode(15, null, null);
            TreeNode tNode3 = new TreeNode(7, null, null);
            TreeNode tNode2 = new TreeNode(20, tNode4, tNode3);
            TreeNode tNode1 = new TreeNode(9, null, null);
            TreeNode tNode0 = new TreeNode(3, tNode1, tNode2);
            TreeNode tHead = tNode0;

            P_1886 obj = new P_1886();

            int[] arr1 = new int[] { 34, 80, 80, 34, 34, 80, 80, 80, 80, 34 };
            char[] arr2 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int[][] arrx = new int[][] { new int[] { 1, 1 }, new int[] { 0, 1 } };
            int[][] arry = new int[][] { new int[] { 1, 1 }, new int[] { 1, 0 } };
            int[][] arr3 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } };
            int[][] arr4 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } };
            string[] arr5 = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            string str1 = "luffy is still joyboy", str2 = "1";
            int v1 = 34, v2 = 6;

            var res = obj.FindRotation(arrx, arry);
            Console.WriteLine(res);

            //obj.Rotate(arr3);


            //MyQueue obj = new MyQueue();
            //obj.Push(1);
            //int param_2 = obj.Pop();
            //obj.Push(2);
            ////int param_3 = obj.Pop();
            //int param_3 = obj.Peek();
            //bool param_4 = obj.Empty();
            //Console.WriteLine(param_2 + " "+ param_3 + " " + param_4);

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
