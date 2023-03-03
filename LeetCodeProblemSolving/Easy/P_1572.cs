using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1572
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0, len = mat.Length;
            for (int i = 0, j = len - 1; i < len; i++, j--)
                sum += mat[i][i] + mat[i][j];

            return len % 2 == 0 ? sum : sum - mat[len / 2][len / 2];
        }
    }
}
