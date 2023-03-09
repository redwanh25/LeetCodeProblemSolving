using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_459
    {
        public bool RepeatedSubstringPattern(string s)
        {
            for(int i = 1; i <= s.Length/2; i++)
            {
                string str = s.Substring(0, i);
                string[] arr = s.Split(str);
                if (arr.Count(x => x == "") == arr.Length)
                    return true;
            }
            return false;
        } 
    }
}
