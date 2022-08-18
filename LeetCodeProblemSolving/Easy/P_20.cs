using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_20
    {
        public bool IsValid(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (stack.Count() > 0 && (stack.Peek() == (char) (c - 1) || stack.Peek() == (char)(c - 2)))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count() == 0 ? true : false;
        }
    }
}
