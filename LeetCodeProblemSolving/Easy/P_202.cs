using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_202
    {
        public bool IsHappy(int n)
        {
            List<int> list = new List<int>();
            list.Add(n);

            while (n != 1)
            {
                int sum = 0;
                while (n != 0)
                {
                    int num = n % 10;
                    sum += (num * num);
                    n /= 10;
                }
                n = sum;

                if (list.Any(x => x == n))
                    return false;
                else
                    list.Add(n);       
            }
            return n == 1 ? true : false;
        }
    }
}
