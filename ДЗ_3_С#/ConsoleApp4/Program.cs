//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 100000);
            string STRnum = number.ToString();
            int len = STRnum.Length;
            Console.WriteLine(STRnum);
            char[] array = new char[len];
            
            for (int i = 0; i < len; i++)
            {
                array[i] = STRnum[i];
            }

            for (int i = 0; i < len; i++) 
            {
                Console.Write(array[i] + " ");
                
            }

            
        }
    }
}
