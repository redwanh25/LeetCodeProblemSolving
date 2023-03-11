using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_109
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if(head == null)
                return null;

            var list = new List<int>();
            while(head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            return ArrayToBst(list, 0, list.Count - 1);
        }

        public TreeNode ArrayToBst(List<int> list, int left, int right)
        {
            if (left > right)
                return null;

            var mid = left + (right - left) / 2;
            var root = new TreeNode(list[mid])
            {
                left = ArrayToBst(list, left, mid - 1),
                right = ArrayToBst(list, mid + 1, right)
            };

            return root;
        }
    }
}
