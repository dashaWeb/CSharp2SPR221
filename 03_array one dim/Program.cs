using System;
using System.Linq;
namespace _03_array_one_dim
{
    class Program
    {
        static void PrintArray<T>(T[] arr, string text = "") // масив - посилального типу, приходить копія ссилки на масив
        {
            /*for (auto & el:arr){}*/
            Console.WriteLine(text);
            foreach (var item in arr) // тільки читання
            {
                Console.Write($"{item,-12}");
            }
            Console.WriteLine();
        }
        static void FillArray(int[] arr, int left = 0, int right = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right + 1);
            }
        }
        static void PushBack(ref int[] arr, int elem) // param ref int[] arr : що мможна було б поміняти посилання на масив, буде інша память
        {
            int[] tmp = new int[arr.Length + 1];
            /*for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }*/
            /*arr.CopyTo(tmp, 0);
            tmp[tmp.Length - 1] = elem;
            arr = tmp;*/
            Array.Resize(ref arr, arr.Length + 1); // ref --> на нову ділянку більшого розміру, копіювання буде
            arr[tmp.Length - 1] = elem;
        }
        static void Main(string[] args)
        {
            /*int[] arr = *//*new int[5]*//*{ 10, 23, -5, 6, 11, };
            PrintArray(arr, "Array 1 :: ");

            Console.Write("\n Enter size of array :: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr2 = new int[size]; // {} => error
            FillArray(arr2);
            PrintArray(arr2, "Array 2 :: ");
            PushBack(ref arr2, 333);
            PrintArray(arr2, "Array 2 :: ");*/
            // class Array - абстрактний клас, від якого успадковуються масиви
            // бібліотека Linq - методи розширення роботи з маисивами

            Console.Write("\n Enter size of array :: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size]; // {} => error
            int left = -10;
            int right = 10;
            FillArray(arr, left, right);
            PrintArray(arr, "Array :: ");
            //int value;
            /*Console.Write("\nInput value for search :: ");
            value = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(arr, value);
            if (index != -1)
            {
                Console.WriteLine($"Value {value} was found in index {index}");
                int lastIndex = Array.LastIndexOf(arr, value);
                Console.WriteLine($"Value {value}(last occur) was found in index {lastIndex}");
            }
            else
            {
                Console.WriteLine($"Value {value} not found");
            }
            // Linq
            if (arr.Contains(value))
            {
                Console.WriteLine($"Value {value} was found");
            }
            else
            {
                Console.WriteLine($"Value {value} was NOT found");
            }*/
            Console.WriteLine("\n=============================================\n");
            int indFirstPositive = Array.FindIndex(arr, IsPositive);
            if(indFirstPositive != -1)
            {
                Console.WriteLine($"Fond positive (first occur) {indFirstPositive}");
            }
            else
            {
                Console.WriteLine($"Not found any positive in Array");
            }
            // Linq Count
            Console.WriteLine($"number of positive elements :: {arr.Count(IsPositive)}");
            int[] positives = Array.FindAll(arr, IsPositive);
            PrintArray(positives, "Find All positive elements (as new array)");

            // лямбда (formal param-list) => {...; return ...;}
            //int[] events = Array.FindAll(arr, (int e) => { return e % 2 == 0; });
            int[] events = Array.FindAll(arr,  e  =>  e % 2 == 0);
            PrintArray(events, "Find All even elements (as new array)");
            Console.WriteLine("\n=============================================\n");
            bool isAllPositive = Array.TrueForAll(arr, IsPositive);
            Console.WriteLine($"All positive elements :: {isAllPositive}");
            int div = 5;
            bool existsDivNumber = Array.Exists(arr, e => e % div == 0);
            Console.WriteLine($"Does exists divisable by {div} :: {existsDivNumber}");
            Array.Sort(arr);
            PrintArray(arr, "Sorted by abc");
            Array.Reverse(arr);
            PrintArray(arr, "Sorted by desc (reverse .... )");
            string[] words = { "jan", "feb", "april", "august", "sept", "nov" };
            Array.Sort(words);
            PrintArray(words, "Sorted string array ");
            Array.Sort(words, (s1, s2) => s1.Length.CompareTo(s2.Length));
            PrintArray(words, "Sorted string array by length ");
        }
        static bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
