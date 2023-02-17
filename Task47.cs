using System;

namespace ArrayRandomFill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем размеры массива. 
            int m = 3; 
            int n = 4;

            // Создаем двумерный массив. 
            double[,] array = new double[m, n];

            // Заполняем массив случайными вещественными числами. 
            Random random = new Random();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) 
                    array[i, j] = random.NextDouble();

            // Выводим массив. 
            Console.WriteLine("Array:");

            for (int i = 0; i < m; i++) {

                for (int j = 0; j < n; j++) {

                    Console.Write(array[i,j] + " ");

                }

                Console.WriteLine();

            }

        }   // Main() end  

    }   // Program end  
}