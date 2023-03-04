using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeContest.Biweekly_Contest_99
{
    internal class P_6312
    {
        public int SplitNum(int num)
        {
            char[] arr = num.ToString().OrderBy(x => x).ToArray();

            string str1 = "", str2 = "";
            for(int i = 0; i < arr.Length; i+=2)
                str1 += arr[i];
            for (int j = 1; j < arr.Length; j += 2)
                str2 += arr[j];

            return int.Parse(str1) + int.Parse(str2);
        }
    }
}
