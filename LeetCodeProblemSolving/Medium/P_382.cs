using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    public class Solution
    {
        private readonly ListNode _head;
        public Solution(ListNode head)
        {
            _head = head;
        }

        public int GetRandom()
        {
            int cnt = 0;
            ListNode temp = _head;
            while(temp != null)
            {
                temp = temp.next;
                cnt++;
            }

            Random random = new Random();
            int val = random.Next(cnt);

            ListNode temp1 = _head;
            for (int i = 0; i < val; i++)
                temp1 = temp1.next;

            return temp1.val;
        }
    }

    internal class P_382
    {
    }
}
