using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeContest.Weekly_Contest_335
{
    internal class P_6307
    {
        public int PassThePillow(int n, int time)
        {
            List<int> list = new List<int>();
            list.Add(1);
            for(int i = 0; i <= time/n; i++)
            {
                for(int j = 2; j <= n; j++)
                {
                    list.Add(j);
                }
                for (int j = n-1 ; j >= 1; j--)
                {
                    list.Add(j);
                }
            }
            return list[time];
        }
    }
}
