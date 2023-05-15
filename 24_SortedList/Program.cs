using System;
using System.Collections;
using System.Collections.Generic;
namespace _24_SortedList
{
    class Program
    {
        static void SortedListDemo()
        {
            SortedList sl = new SortedList() // object key, object value, впорядкування по ключах
            {
                { 10,"ten"},
                { 5,"five"},
                { 7,"seven"},
                { 0,"false"},
                //{ 1.0,"one"}, exception ключі повинні бути однакового типу
            };
            PrintSl(sl, " Print SortedList ::");

            sl.Add(2, "two");
            PrintSl(sl, " Print SortedList ::");
            sl[7] = "SEVEN"; // міняємо значення (value) із пари по ключу 7
            sl[8] = "eight";
            PrintSl(sl, " Print SortedList ::");

            int key = 3;
            Console.WriteLine($"Get access for key {key} ::: {sl[key] ?? "Null" }");

            if (!sl.Contains(key))
            {
                sl.Add(key, "Something");
                Console.WriteLine($"Key {key} was added !!!");
            }
            PrintSl(sl, " Print SortedList ::");

            key = 100;
            sl.Remove(key);
            PrintSl(sl, $"After remove pair with key {key}");

            int index = 0;
            if(index < sl.Count)
            {
                sl.RemoveAt(index);
                PrintSl(sl, $"After remove pair with index {index}");
            }
            Console.WriteLine($"Index {index} \t Key : {sl.GetKey(index)} \t Value :: {sl.GetByIndex(index)}");
        }
        static void PrintSl(IDictionary slist, string text = "")
        {
            Console.WriteLine(text);
            foreach (DictionaryEntry item in slist)
            {
                Console.WriteLine($"\t{item.Key, -5} {item.Value,-10}");
            }
            Console.WriteLine($"\n {new string('=',100)}\n\n");
        }
        static void DemoSortedListGen()
        {
            SortedList<int, string> sl = new SortedList<int, string>
            {
                [1000] = "Olena",
                [777] = "Ivan",
                [555] = "Dmytro",
            };
            PrintSl(sl, " Print SortedList ");
            //Console.WriteLine(sl.TryAdd(1000, ""));;
            sl.Add(233, "Vasil");
            PrintSl(sl, " Print SortedList ");
            int id = 555;
            if(sl.TryGetValue(id,out string name))
            {
                Console.WriteLine($"Get name by id {id} :: {name}");
            }
            else
            {
                Console.WriteLine($"Bad access by id {id}");
            }
            //sl.RemoveAt(0);
            sl.Remove(1000);
            PrintSl(sl, " Print SortedList ");
            foreach (var k in sl.Keys)
            {
                Console.WriteLine($"Code :: {k} \t Name {sl[k]}");
            }
            

        }
        static void Main(string[] args)
        {
            // SortedList - колекція організована як два паралельних масиви (масив Ключів та масив Значень)
            // Ключі унікальні!!!
            //SortedListDemo();
            DemoSortedListGen();
        }
    }
}
