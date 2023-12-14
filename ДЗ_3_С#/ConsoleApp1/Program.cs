// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(1,101);

            for (int i = 0;i < array.Length; i++) 
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine("\n");

            for (int i = 0;i < array.Length; i++)
            {
                if (array[i]>19 && array[i]<91) 
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
