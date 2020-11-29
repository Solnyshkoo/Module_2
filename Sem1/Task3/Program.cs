using System;

namespace Seminar2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] ch = CreateMatrix();
            Info(ch);
            Print(ch);
            Console.WriteLine("Для выхода из программы нажмите ENTER.");
            Console.ReadLine();
        }
        /// <summary>
        /// Create matrix.
        /// </summary>
        /// <returns> matrix </returns>
        private static char[][][] CreateMatrix()
        {
            char[][][] ch = { // элементы массива – массивы ссылок на массивы
                   new char [][] { new char [] {'a', 'b'}, // у массива 
                     new char [] {'c', 'd', 'e'},    // элемент -  ссылка на массив
                     new char  [] {'f', 'g', 'h', 'i'}
                   },
                   new char [][] { new char [] {'j', 'k'},
                                   new char [] {'l', 'm', 'n'}
                   },
                   new char [][] { new char [] {'o', 'p', 'q', 'r'}, }
            };
            return ch;
        }
        /// <summary>
        /// All information about matrix.
        /// </summary>
        /// <param name="ch"> matrix </param>
        private static void Info(char[][][] ch)
        {
            Console.WriteLine("ch.Rank = " + ch.Rank);
            Console.WriteLine("ch[0].Rank = " + ch[0].Rank);
            Console.WriteLine("ch[0][0].Rank = " + ch[0][0].Rank);
            Console.WriteLine("ch.GetType() = " + ch.GetType());
            Console.WriteLine("ch[1][1][2] = " + ch[1][1][2]);
            Console.WriteLine("ch.Length = " + ch.Length);

            Console.WriteLine("ch.GetLength(0) = " + ch.GetLength(0));
            Console.WriteLine("ch[1].GetLength(0) = " + ch[1].GetLength(0));
            Console.WriteLine("ch[2].GetLength(0) = " + ch[2].GetLength(0));

            Console.WriteLine("ch[0].GetUpperBound(0) = " + ch[0].GetUpperBound(0));
            Console.WriteLine("ch[1].GetUpperBound(0) = " + ch[1].GetUpperBound(0));
            Console.WriteLine("ch[2].GetUpperBound(0) = " + ch[2].GetUpperBound(0));
        }
        /// <summary>
        /// Matriz output to console.
        /// </summary>
        /// <param name="ch">matrix</param>
        private static void Print(char[][][] ch)
        {
            foreach (char[][] memb1 in ch)
            {
                Console.WriteLine("Уровень 1:");
                foreach (char[] memb2 in memb1)
                {
                    Console.Write("\tУровень 2:\t");
                    foreach (char memb3 in memb2)
                        Console.Write("{0,3}", memb3);
                    Console.WriteLine();
                }
            }
        }
    }

}

