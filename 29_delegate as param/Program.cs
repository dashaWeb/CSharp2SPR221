using System;
using System.Linq;
namespace _29_delegate_as_param
{
    delegate bool Condition<T>(T data); // узагальнений делегат
    
    class Program
    {
        static int CountInArray<T>(T[] arr, Condition<T> func) // func - перевірка умови
        {
            int counter = 0;

            foreach (var e in arr)
            {
                if (func(e))
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, -23, 45, 100, -34, -5, -99 };
            /*int[] result = Array.FindAll<int>(arr, e => e > 0); // 2 parametr = delegate;
            Console.WriteLine($"Only > 0 :: {String.Join(",",result)}");*/

            string[] words = { "Note", "Book", "Ruler", "Rubber" };
            /*Console.WriteLine(words.All(str => str.Length < 7));*/

            Console.WriteLine($"Negative elements = {CountInArray(arr,x => x < 0)}");
            char letter = 'e';
            Console.WriteLine($"\nCount of words with letter '{letter}' = {CountInArray(words,s => s.Contains(letter))}");
        }
    }
}
