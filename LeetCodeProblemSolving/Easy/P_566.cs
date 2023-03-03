using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_566
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length, n = mat[0].Length;
            if (m * n != r * c)
                return mat;

            int[][] arr = new int[r][];
            arr = arr.Select(x => new int[c]).ToArray();

            for (int i = 0; i < m * n; i++)
                arr[i / c][i % c] = mat[i / n][i % n];

            return arr;
        }
    }
}
