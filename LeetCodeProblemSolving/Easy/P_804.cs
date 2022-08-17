using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_804
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            List<string> morseCodes = new List<string>() { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            HashSet<string> strings = new HashSet<string>();
            Dictionary<char, string> representations = new Dictionary<char, string>();

            char ch = 'a';
            foreach (string morseCode in morseCodes)
            {
                representations.Add(ch, morseCode);
                ch++;
            }

            foreach (string word in words)
            {
                string str = "";
                char[] chars = word.ToCharArray();
                foreach (char c in chars)
                {
                    str += representations[c];
                }
                strings.Add(str);
            }

            return strings.Count();
        }
    }
}
