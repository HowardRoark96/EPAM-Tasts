using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для сортировки массива можно воспользоваться методом Array.Sort()

            int[] array = new int[] { -1, 10, 15, 20, -9, 55, 0, -584 };

            Console.Write("Последовательность чисел:" + "\t");

            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            SortArray(array);

            Console.Write("Отсортированная последовательность чисел:" + "\t");

            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }

            Console.ReadLine();
        }
        static void SortArray(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
