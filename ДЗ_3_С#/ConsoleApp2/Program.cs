// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}

