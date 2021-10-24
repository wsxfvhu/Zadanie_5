using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            array[0, 0] = 1;
            Console.Write("{0,2}", 1);
            for (int i = 1; i < N; i++)
            {
                if (array[0, i - 1] == 1)
                    array[0, i] = 0;
                else array[0, i] = 1;
                Console.Write("{0,2}", array[0, i]);
            }
            Console.WriteLine();
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i - 1, j] == 1)
                        array[i, j] = 0;
                    else array[i, j] = 1;
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
