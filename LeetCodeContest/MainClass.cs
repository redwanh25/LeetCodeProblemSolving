﻿using LeetCodeContest.Biweekly_Contest_99;
using LeetCodeContest.Weekly_Contest_335;

namespace LeetCodeContest
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_6307 obj = new P_6307();

            int[] arr2 = new int[] { 1, 3, 5, 2, 1, 5 };
            char[] arr1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int[][] arr3 = new int[][] { new int[] { 1, 5, 2 }, new int[] { 7, 3, 2 }, new int[] { 3, 5, 2 } };
            string[] arr4 = new string[] { "word", "world", "row" };
            string str1 = "hlabcdefgijkmnopqrstuvwxyz", str2 = "pq";
            int v1 = 25, v2 = 10;

            var res = obj.PassThePillow(v1, v2);
            Console.WriteLine(res);

            //obj.MoveZeroes(arr1);
        }
    }
}
