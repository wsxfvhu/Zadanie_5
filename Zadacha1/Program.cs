using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float s = 0;
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s +=array[i];
            }
            Console.WriteLine("Среднее арафметическое={0}",s/n);
            Console.ReadKey();
        }
    }
}