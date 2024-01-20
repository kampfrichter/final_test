using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = CreatArray();
            string[] resultArray = FilterArray(inputArray);
            Console.WriteLine("Результат: [" + string.Join(", ", resultArray) + "]");
        }
        static string[] FilterArray(string[] inputArray)
        {
            int count = 0;

            // Подсчет количества строк, удовлетворяющих условию
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    count++;
                }
            }
            string[] resultArray = new string[count];
            int index = 0;

            // Заполнение результирующего массива
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    resultArray[index] = inputArray[i];
                    index++;
                }
            }

            return resultArray;
        }

        static string[] CreatArray()
        {
            Console.Write("Введите количество элементов массива: ");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] inputArray = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите элемент массива: ");
                inputArray[i] = Console.ReadLine();
            }

            return inputArray;

        }

    }
}