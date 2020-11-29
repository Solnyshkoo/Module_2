using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] lines = new string[] { "нуль", "один", "два",
                                         "три", "четыре",
                                         "пять", "шесть", "семь", "восемь",
                                         "девять", "десять" };
        Console.WriteLine("\nИсходный массив:");
        foreach (string s in lines)
            Console.Write(s + " ");
        Console.WriteLine();
        string[] res = RightOder(lines);
        foreach (string t in res)
            Console.Write(t + " ");

        Console.WriteLine("\nДля выхода нажмите любую клавишу.");
        Console.ReadKey(true);
    }
    /// <summary>
    /// Arrange words in the correct order
    /// </summary>
    /// <param name="lines"></param>
    /// <returns></returns>
    public static string[] RightOder(string[] lines)
    {
        int count = 100000;
        int index = -1;
        List<string> res = new List<string>();
        while (res.Count != lines.Length)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length < count)
                {
                    count = lines[i].Length;
                    index = i;

                }
            }
            res.Add(lines[index]);
            lines[index] = "qwertyuiopsdfghj";
            count = 100000;
        }
        return res.ToArray();
    }
}
