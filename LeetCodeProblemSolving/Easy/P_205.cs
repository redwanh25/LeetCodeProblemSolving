using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dictionary1 = new Dictionary<char, char>();
            Dictionary<char, char> dictionary2 = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if ((dictionary1.ContainsKey(s[i]) && dictionary1[s[i]] != t[i]) || (dictionary2.ContainsKey(t[i]) && dictionary2[t[i]] != s[i]))
                {
                    return false;
                }
                if(!dictionary1.ContainsKey(s[i]) || !dictionary2.ContainsKey(t[i]))
                {
                    dictionary1.Add(s[i], t[i]);
                    dictionary2.Add(t[i], s[i]);
                }
            }
            return true;
        }
    }
}
