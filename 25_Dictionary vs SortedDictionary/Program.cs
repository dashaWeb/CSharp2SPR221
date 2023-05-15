using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _25_Dictionary_vs_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // впорядування НЕМАЄ, пари зберігаються на основі хеш-таблиці
            Dictionary<string, string> voc = new Dictionary<string, string>
            {
                ["hello"] = "привіт",
                ["bye"] = "бувай",
                ["program"] = "програма",
                ["developer"] = "програміст, розробник",
            };
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\t Print Dictionary");
            foreach (var p in voc)
            {
                Console.WriteLine($"\t\t{p.Key,-10} {p.Value}");
            }
            voc.Add("Key", "Value");
            Console.WriteLine(voc.TryAdd("hello", "привіт")); 
            Console.WriteLine(voc.TryGetValue("hello", out string text));
            voc.Remove("hello");
            Console.WriteLine("\t Print Dictionary");
            foreach (var p in voc)
            {
                Console.WriteLine($"\t\t{p.Key,-10} {p.Value}");
            }

            Console.WriteLine("\n\n\n");
            SortedDictionary<string, string> vocSorted = new SortedDictionary<string, string>(voc);
            Console.WriteLine("\t Print Dictionary Sort");
            foreach (var p in vocSorted)
            {
                Console.WriteLine($"\t\t{p.Key,-10} {p.Value}");
            }

            //Підрахувати, скільки разів кожне слово зустрічається в тексті. Результат записати до колекції Dictionary<TKey, TValue>. Вивести статистику за текстом у вигляді таблиці
        }
    }
}
