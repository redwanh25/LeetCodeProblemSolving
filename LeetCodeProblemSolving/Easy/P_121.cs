using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_121
    {
        public int MaxProfit(int[] prices)
        {
            int buy = int.MaxValue;
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                profit = Math.Max(profit, prices[i] - buy);
            }
            return profit;
        }
    }
}
