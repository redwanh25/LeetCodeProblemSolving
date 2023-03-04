using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Hard
{
    internal class P_2444
    {
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long answer = 0;
            // minPos, maxPos : the most recent positions of minK and maxK.
            // leftBound      : the most recent value outside the range [minK, maxK].
            int minPos = -1, maxPos = -1, leftBound = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                // If the number is outside the range [minK, maxK], update the most recent leftBound.
                if (nums[i] < minK || nums[i] > maxK) leftBound = i;

                // If the number is minK or maxK, update the most recent position.
                if (nums[i] == minK) minPos = i;
                if (nums[i] == maxK) maxPos = i;

                // Number of valid subarrays == number of elements between leftBound and the smaller of the two most recent minPos and maxPos.
                answer += Math.Max(0, Math.Min(minPos, maxPos) - leftBound);
            }

            return answer;
        }
    }
}
