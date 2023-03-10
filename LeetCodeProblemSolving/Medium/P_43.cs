using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Medium
{
    internal class P_43
    {
        public string Multiply(string num1, string num2)
        {
            BigInteger bigInt1 = BigInteger.Parse(num1);
            BigInteger bigInt2 = BigInteger.Parse(num2);
            return (bigInt1 * bigInt2).ToString();
        }
    }
}
