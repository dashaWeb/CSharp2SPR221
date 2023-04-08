using System;
using static System.Console;
using System.Linq;
using System.Text;

namespace _04_2DArray
{
    class Program
    {
        static void Print2DArray(int[,] arr)
        {
            /*foreach (var item in arr)
            {
                Write($"{item,10}");
            }
            WriteLine("\n");*/
            Write("\n ================================== \n");
            for (int i = 0; i < arr.GetLength(0); i++) // кількість рядків (перший вимір з номером 0)
            {
                Write("\t");
                for (int j = 0; j < arr.GetLength(1); j++) // кількість колонок (другий вимір з номером 1
                {
                    Write($"{arr[i, j],-10}");
                }
                WriteLine("\n");
            }
        }
        static void Fill2DArray(int[,] arr, int min = 1, int max = 10)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(min, max + 1);
                }
            }
        }
        static int[] Sum(int[,] arr)
        {
            int[] mas = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    mas[i] += arr[i, j];
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3]
                {
                    {10,20,30 },
                    { 1,2,3}
                };
            int[,,] arr2 = new int[2, 3, 5]
                {
                    {
                        {1,2,3,5,6 },
                        {7,8,9,10,11 },
                        { 9,5,4,7,8}
                    },
                    {
                        {5,8,7,9,6 },
                        {5,8,7,9,6 },
                        {5,8,7,9,6 }
                    }
                };
            Print2DArray(arr);
            Fill2DArray(arr);
            Print2DArray(arr);
            WriteLine(arr.Rank);
            int[] mas = Sum(arr);
            foreach (var item in mas)
            {
                Write($"{item,10}");
            }
            WriteLine();
           }

        
    }
}
