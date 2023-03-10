using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_150
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            int res = 0;
            foreach (string str in tokens)
            {
                if(str == "+" || str == "-" || str == "*" || str == "/")
                {
                    int x = stack.Pop();
                    int y = stack.Pop();
                    if (str == "+")
                        res = y + x;
                    if (str == "-")
                        res = y - x;
                    if (str == "*")
                        res = y * x;
                    if (str == "/")
                        res = y / x;
                    
                    stack.Push(res);
                }
                else
                {
                    stack.Push(Convert.ToInt32(str));
                }
            }
            return stack.Peek();
        }
    }
}
