using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            foreach (int i in nums1)
            {
                int index = Array.IndexOf(nums2, i);
                if(index < nums2.Length - 1)
                {
                    bool isFind = false;
                    for (int j = index; j < nums2.Length; j++)
                    {
                        if (nums2[index] < nums2[j])
                        {
                            result.Add(nums2[j]);
                            isFind = true;
                            break;
                        }
                    }
                    if(isFind == false)
                        result.Add(-1);
                }
                else
                    result.Add(-1);
            }
            return result.ToArray();
        }
    }
}
