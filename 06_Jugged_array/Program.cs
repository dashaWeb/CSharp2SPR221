using System;
using System.Linq;
namespace _06_Jugged_array
{
    class Program
    {
        static void printJugged(int[][] m, string text = "")
        {
            /*for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write($"{m[i][j],10}");
                }
                Console.WriteLine();
            }*/
            Console.WriteLine($"\n============={text}===========\n");
            foreach (var line in m)
            {
                foreach (var item in line)
                {
                    Console.Write($"{item,10}");
                }
                Console.WriteLine();
            }
        }
        static void SwapRows(int[][] m, int row1, int row2)
        {
            if (row1 >= 0 && row2 >= 00 && row1 < m.Length && row2 < m.Length && row1 != row2)
            {
                int[] tmp = m[row1];
                m[row1] = m[row2];
                m[row2] = tmp;
            }
        }
        static void Reverse(int[][] m)
        {
            for (int i = 0; i < m.Length / 2; i++)
            {
                SwapRows(m, i, m.Length - 1 - i);
            }
        }
        static int[] SumRows(int[][] m)
        {
            int[] tmp = new int[m.Length];
            /*for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length ; j++)
                {
                    tmp[i] += m[i][j];
                }
            }*/
            /*int i = 0;
            foreach (var line in m)
            {
                foreach (var item in line)
                {
                    tmp[i] += item;
                }
                i++;
            }*/
            for (int i = 0; i < m.Length; i++)
            {
                tmp[i] = m[i].Sum();
            }
            return tmp;
        }
        static int[] MaxRows(int[][] m)
        {
            int[] tmp = new int[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                tmp[i] = m[i].Max();
            }
            return tmp;

        }
        static void Main(string[] args)
        {
            int[][] m = new int[5][];
            m[0] = new int[3] { 1, 2, 3 };
            m[1] = new[] { 10, 20, 30, 40 };
            m[2] = new[] { 100, 200, 300, 400, 500 };
            m[3] = new[] { 5, 8, 7, 9, 8, 9, 6, 5, 2 };
            m[4] = new[] { 10, 2, 58, 4, 7, 6, 23, 14 };
            printJugged(m, "Print Array");
            //SwapRows(m, 0, m.Length - 1);
            Reverse(m);
            printJugged(m, "Print Reverse Array");
            Console.WriteLine();

            //int[] res = SumRows(m);
            var res = SumRows(m);
            foreach (var item in res)
            {
                Console.Write($"{item, 10}");
            }
            Console.WriteLine();
            Console.WriteLine();
            var max = MaxRows(m);
            foreach (var item in max)
            {
                Console.Write($"{item,10}");
            }
            Console.WriteLine();

           
        }
    }
}
