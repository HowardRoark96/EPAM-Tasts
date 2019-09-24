using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скобочную последовательность: ");

            string s = Console.ReadLine();

            if (Check(s))
            {
                Console.WriteLine("Верная последовательность");
            }
            else
            {
                Console.WriteLine("Неверная последовательность");
            }

            Console.ReadLine();
        }

        static char ResponseBracket(char ch)
        {
            switch (ch)
            {
                case '(': return ')';
                case '[': return ']';
                case '{': return '}';
            }
            return 'w';
        }
        static bool Check (string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    stack.Push(str[i]);
                }
                if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    if (ResponseBracket(stack.Pop()) != str[i])
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
