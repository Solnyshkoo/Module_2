using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            int N;
            do
            {
                Console.Write("Введите число целое число N:");
            } while (!(int.TryParse(Console.ReadLine(), out N) && N > 0));
            Print(Create(N), N);
        }
        /// <summary>
        /// Create matrix.
        /// </summary>
        /// <param name="N"> matrix size </param>
        /// <returns> matrix </returns>
        public static int[,] Create(int N)
        {
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = ((i + j) % N + 1);
                }
            }
            return array;
        }
        /// <summary>
        /// Matrix output to console.
        /// </summary>
        /// <param name="array"> matrix </param>
        /// <param name="N"> matrix size </param>
        public static void Print(int[,] array, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int g = 0; g < N; g++)
                {
                    Console.Write($"{array[i, g]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
