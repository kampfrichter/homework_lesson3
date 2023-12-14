// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[10];
            Random rand = new Random();
            double min = array[0], max = array[0];


            for (int i = 0; i < array.Length; i++)
                array[i] = rand.NextDouble() + rand.Next(1, 10);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            min = array.Min();
            max = array.Max();

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(max - min);

        }
    }
}
