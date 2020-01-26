using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinMat4
{
    class ParserONP
    {
        public string ParseExample(string operacjaInfix)
        {
            string operacjaPostfix = "";
            char[] tymczasowaTablicaZnakow = operacjaInfix.ToCharArray();
            Stack<char> stack = new Stack<char>();


            for (int i = 0; i < tymczasowaTablicaZnakow.Length; i++)
            {
                if (IsOperand(tymczasowaTablicaZnakow[i]))
                {
                    operacjaPostfix += tymczasowaTablicaZnakow[i].ToString();
                }
                else if (tymczasowaTablicaZnakow[i] == '(')
                {
                    stack.Push(tymczasowaTablicaZnakow[i]);
                }
                else if (tymczasowaTablicaZnakow[i] == ')')
                {
                    do
                    {
                        operacjaPostfix += stack.Pop().ToString();
                    } while (stack.Peek() != '(' && stack.Count != 0);
                    if (stack.Peek() == '(')
                        stack.Pop();
                }
                else if (IsOperator(tymczasowaTablicaZnakow[i]))
                {
                    if (stack.Count != 0)
                    {
                        if (IsOperator(stack.Peek()))
                        {
                            if (GetOperatorLevel(stack.Peek()) > GetOperatorLevel(tymczasowaTablicaZnakow[i]))
                            {
                                operacjaPostfix += stack.Pop().ToString();
                            }
                        }
                    }
                    stack.Push(tymczasowaTablicaZnakow[i]);
                }
                else
                {
                    throw new SystemException();
                }



                if (i == tymczasowaTablicaZnakow.Length -1)
                {
                    while (stack.Count != 0)
                    {
                        operacjaPostfix += stack.Pop().ToString();
                    }
                }
            }

            return operacjaPostfix;
        }
        private enum Operator { Parenthesis = 0, AddSubtract = 1, MultiplyDivide = 2, Power = 3 };
        private bool IsOperand(char c)
        {
            char[] set = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (set.Contains(c))
                return true;
            else
                return false;
        }
        private bool IsOperator(char c)
        {
            char[] set = { '+', '-', '*', '/', '^' };
            if (set.Contains(c))
                return true;
            else
                return false;
        }
        private Operator GetOperatorLevel(char c)
        {
            if (c == '^')
                return Operator.Power;
            else if (c == '/' || c == '*')
                return Operator.MultiplyDivide;
            else if (c == '+' || c == '-')
                return Operator.AddSubtract;
            else
                return Operator.Parenthesis;
        }
    }
}
