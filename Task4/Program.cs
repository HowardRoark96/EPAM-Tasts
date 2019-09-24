using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int s = int.Parse(Console.ReadLine());

            Console.Write("Факториал {0} равен {1}", s, Factorial(s));

            Console.ReadLine();
        }

        static int Factorial(int a)
        {
            if (a == 0 || a == 1)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
            }
        }
    }
}
