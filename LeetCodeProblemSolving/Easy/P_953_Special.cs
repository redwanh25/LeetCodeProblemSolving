using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_953_Special
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var alphabet = Enumerable.Range(0, 26).ToDictionary(i => order[i], i => (char)('a' + i));
            //foreach (var word in alphabet.Keys)
            //    Console.WriteLine(word + " " + alphabet[word]);

            var translated = words.Select(w => string.Concat(w.Select(c => alphabet[c])));
            //foreach (var word in translated)
            //    Console.WriteLine(word);

            return translated.OrderBy(x => x).SequenceEqual(translated);
        }
    }
}

//https://leetcode.com/problems/verifying-an-alien-dictionary/solutions/3130961/short-and-easy-three-lines-of-linq-with-explanation/