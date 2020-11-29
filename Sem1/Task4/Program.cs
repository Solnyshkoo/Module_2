using System;
class Program
{
    static void Main()
    {
        uint N, M;        // размеры массива
        int[,] ar;    // ссылка на массив
        do
        {
            Parser(out N, out M);
            ar = Constract(N, M);
            Console.WriteLine("ar.Length:  " + ar.Length);
            Console.WriteLine("ar.Rank:  " + ar.Rank);
            Print(ar);
            UpperTriangle(ar);
            Print(ar);
            Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
    /// <summary>
    /// Matrix output.
    /// </summary>
    /// <param name="ar">matrix</param>
    private static void Print(int[,] ar)
    {
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < ar.GetLength(0) - 1; i++, Console.WriteLine())
            for (int y = 0; y < ar.GetLength(1) - 1; y++)
                Console.Write("{0,3}", ar[i, y]);

    }
    /// <summary>
    /// Create matrix.
    /// </summary>
    /// <param name="N">number of lines</param>
    /// <param name="M">number of columns</param>
    /// <returns></returns>
    private static int[,] Constract(uint N, uint M)
    {
        int[,] ar = new int[N, M];
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < M - 1; j++)
            {
                ar[i, j] = (i + 1) * (2 * j + 1);
            }
        }

        return ar;
    }
    /// <summary>
    /// checking the reliability of data
    /// </summary>
    /// <param name="N">number of lines</param>
    /// <param name="M">number of columns</param>
    private static void Parser(out uint N, out uint M)
    {
        do
        {
            Console.WriteLine("Введите значение N и М каждое с новой строчки: ");
        } while (!(uint.TryParse(Console.ReadLine(), out N) && uint.TryParse(Console.ReadLine(), out M)));
    }
    /// <summary>
    /// Reduction of the matrix to the upper triangular form
    /// </summary>
    /// <param name="arr">matrix</param>
    static void UpperTriangle(int[,] arr)
    {
        if (arr.GetLength(0) != arr.GetLength(1))
        {
            return;
        }
        for (int i = 0; i < arr.GetLength(0) - 1; i++)
        {
            for (int q = 0; q < arr.GetLength(0) - 2 - i; q++)
            {
                arr[i, q] = 0;
            }
            // для нижнего треугольника
            /*for (int q = 0; q > arr.GetLength(0) - i; q++)
            {
                arr[i, q] = 0;
            }
            */
        }
    }
}

