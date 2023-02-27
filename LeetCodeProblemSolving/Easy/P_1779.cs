using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1779
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int xy = 0, minDistance = int.MaxValue, index = -1;
            for (int i = 0; i < points.Length; i++)
            {
                bool isValid = true;
                if (points[i][0] == x || points[i][1] == y)
                {
                    xy = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
                }
                else
                    isValid = false;

                if (minDistance > xy && isValid)
                {
                    minDistance = xy;
                    index = i;
                }
            }
            return index;
        }
    }
}
