using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_1367
    {
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            if (root is null)
                return false;

            if (Solve(head, root))
                return true;

            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }

        public bool Solve(ListNode head, TreeNode root)
        {
            if (head is null)
                return true;

            if (root is null)
                return false;

            if (head.val != root.val)
                return false;

            return Solve(head.next, root.left) || Solve(head.next, root.right);
        }
    }
}
