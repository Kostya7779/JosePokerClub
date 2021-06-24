using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество игроков");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];          
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество фишек для {0}-го игрока", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }          
            int count = 0;
            for (int k = 0; k < 100; k++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            a[i] = a[i] + 1;
                            a[j] = a[j] - 1;
                            count++;
                        }
                    }
                }              
            }
            Console.WriteLine("Количество ходов фишек = {0}", count);
            Console.ReadKey();
        }       
    }
}

