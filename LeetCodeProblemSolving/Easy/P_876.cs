using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_876
    {
        public ListNode? MiddleNode(ListNode head)
        {
            int length = 0;
            ListNode? temp = head, temp1 = head;
            while (temp != null)
            {
                temp = temp.next;
                length++;
            }

            for (int i = 0; i < length / 2; i++)
                temp1 = temp1?.next;

            return temp1;
        }
    }
}
