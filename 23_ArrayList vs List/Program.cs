using System;
using System.Collections;
using System.Collections.Generic;
namespace _23_ArrayList_vs_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 2, 3, 5 };
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = 111;
            Console.WriteLine(String.Join(" ", arr));*/

            // System.Collections - Неузагальнені колекції = елементи типу object
            // непродуктивно для value  - типів (boxing - unboxing);
            ArrayList al = new ArrayList() { 10, 20, 56.3, "test", true, 900 };
            al[0] = 10.7;
            PrintList(al, "Print ArrayList");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.Add(456);
            PrintList(al, "Print ArrayList Add  ");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);
            al.AddRange(new int[] { 2, 5, 8, 7 });
            PrintList(al, "Print ArrayList AddRange");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.Insert(2, "orange");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);
            PrintList(al, "Print ArrayList Insert [2]");
            al.InsertRange(1, new ArrayList() { "one", false, 10.7,16,22 });
            PrintList(al, "Print ArrayList InsertR [1]");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.Remove("one");
            PrintList(al, "Print ArrayList Remove element value [one]");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.RemoveRange(0, 3);
            PrintList(al, "Print ArrayList RemoveRange 0, 3");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.RemoveAt(3);
            PrintList(al, "Print ArrayList RemoveAt [3]");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            al.Clear();
            PrintList(al, "Print ArrayList Clear");
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);

            Console.WriteLine("\n");
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                al.Add((char)rnd.Next(65, 91));
            }
            Console.WriteLine("Capacity :: " + al.Capacity);
            Console.WriteLine("Count :: " + al.Count);
            PrintList(al, "Print ArrayList New ");
            Console.WriteLine("\n");

            al.Sort();
            PrintList(al, "Print ArrayList Sort");

            Console.WriteLine("\n\n" + new string('=',50) + "\n\n");
            List<string> li = new List<string>(10) { "pen", "book", "bag", "study", "copybook" };
            PrintList(li, "Print List ");

            /*li.Add("value");
            li.AddRange(new[] { "ruler","pupil"});*/
            li.InsertRange(0,new[] { "ruler", "pupil" });
            PrintList(li, "Print List Add");

            //li.RemoveAt(2)
            /*li.RemoveAll(w => w.Contains('o'));
            PrintList(li, "Print List Add");*/

            li.Sort();
            PrintList(li, "Print List Sort");

            li.Sort((s1, s2) => s1.Length.CompareTo(s2.Length));
            PrintList(li, "Print List Sort");


        }

        private static void PrintList(IEnumerable al, string text = "")
        {
            Console.Write(text + " :: \t");
            foreach (var item in al)
            {
                Console.Write($"{item, 10}");
            }
            Console.WriteLine();
        }
    }
    
    // Створити список List<> з випадковими словами. Спочатку підготувати базу зі слів.
    // Знайти усі слова (FindAll), які містять цифри. 
    // Вилучити усі слова, що починаються з великої букви.
}
