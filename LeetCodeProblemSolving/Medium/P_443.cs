using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_443
    {
        public int Compress(char[] chars)
        {
            if(chars.Length == 1)
                return 1;

            List<Tuple<char, int>> list = new List<Tuple<char, int>>();

            for (int i = 0, cnt = 1; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                    cnt++;
                if (chars[i] != chars[i + 1])
                {
                    list.Add(Tuple.Create(chars[i], cnt));
                    cnt = 1;
                }
                if (i + 1 == chars.Length - 1)
                    list.Add(Tuple.Create(chars[i + 1], cnt));
            }

            string str = "";
            foreach (Tuple<char, int> kv in list)
            {
                str += kv.Item1;
                if (kv.Item2 > 1) str += kv.Item2;
            }

            int j = 0;
            foreach (char ch in str.ToCharArray())
                chars[j++] = ch;

            return str.Length;
        }
    }
}
