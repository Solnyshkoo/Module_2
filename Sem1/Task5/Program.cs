using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[][] paskal; // ссылка на массив ссылок на массив
        int n;
        do                  // цикл для повторения решения
        {
            do Console.Write("Введите n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            paskal = new int[n + 1][]; // объект - массив пустых ссылок

            Console.WriteLine("paskal.GetType()=" + paskal.GetType());
            CreateTriangle(paskal);

            var toFile = Beautiful(paskal);
            Console.WriteLine(toFile);
            FileOutput(toFile);

            Console.WriteLine(Environment.NewLine + "Другой вид:");
            Console.WriteLine(TriToStr(paskal));

            Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        Console.WriteLine();
    }
    /// <summary>
    /// Create Paskal triangle.
    /// </summary>
    /// <param name="paskal"> array for triangle values </param>
    private static void CreateTriangle(int[][] paskal)
    {
        for (int i = 0; i < paskal.Length; i++)
        {
            paskal[i] = new int[i + 1]; // объект - массив элементов типа int
            paskal[i][0] = paskal[i][i] = 1;
            for (int j = 1; j < i; j++)
                paskal[i][j] = paskal[i - 1][j - 1] + paskal[i - 1][j];
        }
    }
    /// <summary>
    /// Beautiful triangle inference.
    /// </summary>
    /// <param name="pascal"> array with triangle values </param>
    /// <returns> written regular form of a triangle</returns>
    static string Beautiful(int[][] pascal)
    {
        //Находим ширину поля для вывода.
        int width = pascal[pascal.Length - 1][pascal[pascal.Length - 1].Length / 2].ToString().Length + 1;
        var mtx = new string[pascal.Length];
        for (int i = pascal.Length - 1; i >= 0; i--)
        {
            mtx[i] = String.Empty;
            for (int j = 0; j < pascal[i].Length; j++)
            {
                mtx[i] += String.Format("{0," + width + "}", pascal[i][j]);
            }
            int l = mtx[mtx.Length - 1].Length;
            mtx[i] = new string(' ', (l - mtx[i].Length) / 2) + mtx[i];
        }

        var output = string.Join(Environment.NewLine, mtx);
        return output;
    }
    /// <summary>
    /// Аnother triangle lead.
    /// </summary>
    /// <param name="paskal"> array with triangle values </param>
    /// <returns> final triangle appearance</returns>
    private static string TriToStr(int[][] paskal)
    {
        var toFile = String.Empty;
        foreach (int[] ar in paskal) // перебор ссылок типа int[] 
        {
            foreach (int cnk in ar)
            {
                toFile += String.Format("{0,4}", cnk);
            }
            toFile += Environment.NewLine;
        }

        return toFile;
    }
    /// <summary>
    /// Цrite triangle to file
    /// </summary>
    /// <param name="fileName"> triangle </param>
    static void FileOutput(string fileName)
    {
        File.WriteAllText("input.txt", fileName);
    }

}
