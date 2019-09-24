using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для поиска элемента в массиве можно воспользоваться методом Array.BinarySearch()

            int[] array = new int[] { 15, 11, 0, -6, 8, -95, 2, -1, 35 };

            Array.Sort(array);

            Console.Write("Массив чисел: ");

            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            Console.Write("Введите число, которое необходимо найти в массиве: ");

            int number = int.Parse(Console.ReadLine());

            if (SearchNumb(array, number))
            {
                Console.WriteLine("Такое число есть в массиве.");
            }
            else
            {
                Console.WriteLine("Такого числа нет в массиве.");
            }

            Console.ReadLine();
        }
        static bool SearchNumb(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
