using System;
using System.IO;
using System.Text;
namespace _35_Stream_write_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "info.txt";
            using (StreamWriter sw = new StreamWriter(fname))
            {
                string line = "Hello from C# Streams";
                int value = 45646;
                DateTime today = DateTime.Now;
                int[] array = { 10, 20, 30, 40, 50 };

                sw.WriteLine(line);
                sw.WriteLine($"Value :: {value}");
                sw.WriteLine(today);
                sw.WriteLine(array.Length);
                foreach (var item in array)
                {
                    sw.WriteLine(item);
                }
            }
            //way 1
            Console.WriteLine($"Content (File.ReadAllText):: \n\t {File.ReadAllText(fname)}");
            Console.WriteLine();

            //way 2
            Console.WriteLine("Content (File.ReadAllLines)\n");
            string[] lines = File.ReadAllLines(fname);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1} ::::: {lines[i]}");
            }

            //way 3
            using (StreamReader sr = new StreamReader(fname))
            {
                string line;
                Console.WriteLine("\n\n Content (line by line)");
                /*while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }*/
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // way 4
            using (StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine($"\n\n Content (ReadEnd) :: {sr.ReadToEnd()}");
            }

            //way 5 
            using (StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine($"\n\n Content (char by char) :: ");
                int symbol;
                while((symbol = sr.Read())!= -1)
                {
                    Console.WriteLine((char)symbol);
                }
            }
        }
    }
}
// Дано текстовий документ (створити у Блокноті чи студії). Знайти число рядків, кількість символів, число слів, 
// * кількість цифр
// * кількість голосних букв
// * кількість приголосних букв
