using System;
using System.Collections.Generic;

namespace Number2_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> parentheses = new Stack<char>();
            Console.WriteLine("Введите выражение: ");
            string MathExpression = Console.ReadLine();
            try
            {
                for (int i = 0; i < MathExpression.Length; i++)
                {
                    if (MathExpression[i] == '(')
                    {
                        parentheses.Push(MathExpression[i]);
                    }
                    if (MathExpression[i] == ')')
                    {
                        parentheses.Pop();
                    }
                }
                if (parentheses.Count == 0)
                {
                    Console.WriteLine("Выражение корректно.");
                }
                else
                {
                    Console.WriteLine("Выражение некорректно.");
                }
            }
            catch
            {
                Console.WriteLine("Выражение некорректно.");
            }
        }
    }
}
