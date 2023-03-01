using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1232
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            List<double> points = new List<double>();
            int cntX = 0, cntY = 0;
            for (int i = 1; i < coordinates.Length; i++)
            {
                if (coordinates[i - 1][0] == coordinates[i][0])
                    cntX++;
                if (coordinates[i - 1][1] == coordinates[i][1])
                    cntY++;
            }
            if (cntX == coordinates.Length - 1 || cntY == coordinates.Length - 1)
                return true;

            for (int i = 1; i < coordinates.Length; i++)
            {
                try
                {
                    points.Add((double)(coordinates[i][1] - coordinates[i - 1][1]) / (coordinates[i][0] - coordinates[i - 1][0]));
                }
                catch (DivideByZeroException) { }
            }
            return points.Count(x => x == points[0]) == coordinates.Length - 1 ? true : false;
        }
    }
}
