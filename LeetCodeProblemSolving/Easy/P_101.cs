using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_101
    {
        bool Dfs(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null)
                return true;

            if (root1?.val != root2?.val)
                return false;

            return Dfs(root1?.left, root2?.right) && Dfs(root1?.right, root2?.left);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return Dfs(root.left, root.right);
        }
    }
}
