using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] splitChars = { ' ', '.', ',', '?', '!', ':', ';' };

            string srt = "Привет Привет привет как  дела  у КАК   .зов!небо?небо!";
            
            string[] array = srt.ToLower().Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            // Программа производит сравнение слов в строке 
            // не учитывая регистр слов. При условии, что 
            // регистр должен быть учтен, нужно убрать ToLower()

            int count;
            
            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
            
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            
                if (count == 1) Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
