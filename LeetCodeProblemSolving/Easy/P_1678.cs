using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_1678
    {
        public string Interpret(string command)
        {
            Dictionary<string, string> result = new Dictionary<string, string> {
                { "G", "G" },
                { "()", "o" },
                { "(al)", "al" }
            };

            foreach(string key in result.Keys)
                command = command.Replace(key, result[key]);

            return command;
        }
    }
}
