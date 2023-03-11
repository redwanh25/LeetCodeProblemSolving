using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_48
    {
        public void Rotate(int[][] matrix)
        {
            int[][] mat = new int[matrix.Length][];
            mat = mat.Select(x => new int[matrix.Length]).ToArray();

            for (int i = 0; i < matrix.Length; i++)
                for (int j = matrix[i].Length - 1, k = 0; j >= 0; j--, k++)
                    mat[i][k] = matrix[j][i];

            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = mat[i][j];
        }
    }
}
