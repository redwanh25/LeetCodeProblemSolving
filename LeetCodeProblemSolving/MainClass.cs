﻿using LeetCodeProblemSolving.Easy;
using LeetCodeProblemSolving.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            P_121 obj = new P_121();

            while (true)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var res = obj.MaxProfit(arr);

                Console.WriteLine(res);
            }
        }
    }
}
