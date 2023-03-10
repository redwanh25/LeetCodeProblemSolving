using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    internal class P_67
    {
        public string AddBinary(string a, string b)
        {
            if(a.Length > b.Length)
                b = b.PadLeft(a.Length, '0');
            else
                a = a.PadLeft(b.Length, '0');

            char[] chars1 = a.ToCharArray(), chars2 = b.ToCharArray();
            Array.Reverse(chars1);
            Array.Reverse(chars2);

            string str = "";
            char inHand = '0';

            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                if (chars1[i] == '0' && chars2[i] == '0')
                {
                    if (inHand == '0')
                        str += '0';
                    else if (inHand == '1')
                        str += '1';
                    inHand = '0';
                }
                else if (chars1[i] == '0' && chars2[i] == '1')
                {
                    if (inHand == '0')
                    {
                        str += '1';
                        inHand = '0';
                    }
                    else if (inHand == '1')
                    {
                        str += '0';
                        inHand = '1';
                    }
                }
                else if (chars1[i] == '1' && chars2[i] == '0')
                {
                    if (inHand == '0')
                    {
                        str += '1';
                        inHand = '0';
                    }
                    else if (inHand == '1')
                    {
                        str += '0';
                        inHand = '1';
                    }
                }
                else if (chars1[i] == '1' && chars2[i] == '1')
                {
                    if (inHand == '0')
                    {
                        str += '0';
                        inHand = '1';
                    }
                    else if (inHand == '1')
                    {
                        str += '1';
                        inHand = '1';
                    }
                }
            }

            char[] chars3 = inHand == '1' ? (str + inHand).ToCharArray() : str.ToCharArray();
            Array.Reverse(chars3);
            string res = new string(chars3);

            return res;
        }
    }
}
