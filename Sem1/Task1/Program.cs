using System;
class Program
{
    static void Main()
    {
        int[,] matr = new int[3, 4] { { 0, 1, 3, 4 }, { 5, 6, 7, 8 },
        { 9, -1, -2, -3 } };
        Console.WriteLine("Для выхода из программы нажмите ENTER.");
        Console.ReadLine();
        Console.WriteLine("matr.GetType() = " + matr.GetType());
        Console.WriteLine("matr.IsFixedSize = " + matr.IsFixedSize);
        Console.WriteLine("matr.Rank = " + matr.Rank);
        Console.WriteLine("matr.Length = " + matr.Length);
        Console.WriteLine("matr.GetLength(1) = " + matr.GetLength(1));
        Console.WriteLine("matr.GetUpperBound(1) = " + matr.GetUpperBound(1));

        foreach (int memb in matr) // все элементы матрицы подряд
            Console.Write("{0,3}", memb);

        Console.WriteLine("\n");

        // вывод по строкам!!!
        for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("{0,3}", matr[i, j]);

    }
}
