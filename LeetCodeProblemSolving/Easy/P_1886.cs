using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1886
    {
        public bool FindRotation(int[][] mat, int[][] target)
        {
            int n = 4, len = mat.Length;
            int[][] matN = new int[len][];
            matN = matN.Select(x => new int[len]).ToArray();

            while (n > 0)
            {
                int cnt = 0;
                for (int i = 0; i < len; i++)
                    for (int j = len - 1, k = 0; j >= 0; j--, k++)
                        matN[i][k] = mat[j][i];
                for (int i = 0; i < len; i++)
                    if (matN[i].SequenceEqual(target[i]))
                        cnt++;

                if (cnt == len)
                    return true;

                for (int i = 0; i < len; i++)
                    for (int j = 0; j < len; j++)
                        mat[i][j] = matN[i][j];
                n--;
            }

            return false;
        }
    }
}
