using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1290
    {
        public int GetDecimalValue(ListNode head)
        {
            string str = "";
            while (head != null)
            {
                str += head.val;
                head = head.next;
            }

            return Convert.ToInt32(str, 2);
        }
    }
}
