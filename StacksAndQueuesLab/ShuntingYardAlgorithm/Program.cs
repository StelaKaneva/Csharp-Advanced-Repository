using System;
using System.Collections.Generic;

namespace ShuntingYardAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 + 4 * 2 / ( 1 - 5 )

            Console.WriteLine(ShuntingYard("3 + 4 * 2 / ( 1 - 5 )"));
        }

        static string ShuntingYard(string input)
        {
            string[] expression = input.Split();
            Stack<string> operatorStack = new Stack<string>();
            string output = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperator(expression[i]))
                {
                    if (operatorStack.Count > 0)
                    {
                        var oldElementArity = OperatorPrecedence(operatorStack.Peek());
                        var elementArity = OperatorPrecedence(expression[i]);

                        if (oldElementArity >= elementArity)
                        {
                            output += operatorStack.Pop() + " ";
                        }

                        operatorStack.Push(expression[i]);
                    }
                }
                else if (expression[i] == "(")
                {
                    operatorStack.Push(expression[i]);
                }
                else if (expression[i] == ")")
                {
                    while (operatorStack.Peek() != "(")
                    {
                        output += operatorStack.Pop() + " ";
                    }

                    operatorStack.Pop();
                }
                else
                {
                    output += expression[i] + " ";
                }
            }

            while (operatorStack.Count > 0)
            {
                output += operatorStack.Pop() + " ";
            }

            return output;
        }
        static int OperatorPrecedence(string input)
        {
            switch (input)
            {
                case "+":
                    return 2;
                case "-":
                    return 2;
                case "*":
                    return 3;
                case "/":
                    return 3;
                case "(":
                    return 1;
                default:
                    break;
            }

            throw new ArgumentException();
        }

        static bool IsOperator(string input)
        {
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                default:
                    break;
            }

            return false;
        }
    }
}
