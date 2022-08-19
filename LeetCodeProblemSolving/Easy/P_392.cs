using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_392
    {
        public bool IsSubsequence(string s, string t)
        {
            int m = s.Length, n = t.Length, idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (idx < m && s[idx] == t[i])
                    idx++;
            }
            if (idx == m) return true;
            return false;
        }
    }
}
