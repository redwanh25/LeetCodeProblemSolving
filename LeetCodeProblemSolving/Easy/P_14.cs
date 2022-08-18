using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string str = "";
            foreach (char ch in strs[0])
            {
                str += ch;
                if(strs.Where(x => x.StartsWith(str)).Count() != strs.Length)
                {
                    return str.Substring(0, str.Length-1);
                }
            }

            return str;
        }
    }
}
