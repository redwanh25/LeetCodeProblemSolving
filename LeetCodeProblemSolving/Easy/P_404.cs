using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_404
    {
        public int Recursion(TreeNode? root, char dir)
        {
            if (root == null) return 0;
            int leftSum = Recursion(root.left, 'l');
            int rightSum = Recursion(root.right, 'r');

            int leftLeafValue = 0;
            if (root.left == null && root.right == null && dir == 'l')
                leftLeafValue = root.val;

            return leftLeafValue + leftSum + rightSum;
        }

        public int SumOfLeftLeaves(TreeNode? root)
        {
            return Recursion(root, 'x');
        }
    }
}
