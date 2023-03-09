using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if ((Math.Abs(height(root.left) - height(root.right)) <= 1) && IsBalanced(root.left) && IsBalanced(root.right))
                return true;
            else
                return false;
        }
        public int height(TreeNode node)
        {
            if (node == null)
                return 0;
            return Math.Max(height(node.left), height(node.right)) + 1;
        }
    }
}
