﻿using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Hard;
using LeetCodeProblemSolving.Medium;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_242 obj = new P_242();

            int[] arr1 = new int[] { 1, 2, 1, 1 };
            char[] arr2 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int[][] arr3 = new int[][] { new int[] { 1, 5, 2 }, new int[] { 7, 3, 2 }, new int[] { 3, 5, 2 } };
            string[] arr4 = new string[] { "word", "world", "row" };
            string str1 = "anagram", str2 = "nagaram";
            int v1 = 5, v2 = 6;

            ListNode lNode4 = new ListNode(5, null  );
            ListNode lNode3 = new ListNode(4, lNode4);
            ListNode lNode2 = new ListNode(3, lNode3);
            ListNode lNode1 = new ListNode(2, lNode2);
            ListNode lNode0 = new ListNode(1, lNode1);
            ListNode lHead = lNode0;

            TreeNode tNode4 = new TreeNode(15, null, null);
            TreeNode tNode3 = new TreeNode(7, null, null);
            TreeNode tNode2 = new TreeNode(20, tNode4, tNode3);
            TreeNode tNode1 = new TreeNode(9, null, null);
            TreeNode tNode0 = new TreeNode(3, tNode1, tNode2);
            TreeNode tHead = tNode0;

            var res = obj.IsAnagram(str1, str2);
            Console.WriteLine(res);

            //obj.MoveZeroes(arr1);
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
