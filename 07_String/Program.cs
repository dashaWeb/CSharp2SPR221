using System;

namespace _07_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*System.String m = "test";
            System.Text.StringBuilder mm = new System.Text.StringBuilder("test");*/

            //m[0] = char.ToUpper(m[0]);  // comple error string - immutable
            //mm[0] = char.ToUpper(mm[0]); // mutable;

            /*string path = @"D:\
                    Даша\

                дз"; // raw string
            Console.WriteLine(path);*/
            string str = "A string is a     sequential - collection  ....... of character that's used to represent text.";
            Console.WriteLine(str);
            char[] arrChar = str.ToCharArray();
            arrChar[0] = char.ToLower(arrChar[0]);
            str = new string(arrChar);
            Console.WriteLine(str);
            Console.WriteLine("\n\n");

            string word = "is";
            Console.WriteLine($"\n Contains {word} :: {str.Contains(word)}");
            Console.WriteLine($"\n IndexOf {word} :: {str.IndexOf(word)}"); // -1 not found
            Console.WriteLine($"\n StartWith {word} :: {str.StartsWith("a")}"); // -1 not found
            Console.WriteLine($"\n EndsWith {word} :: {str.EndsWith(".")}"); // -1 not found

            Console.WriteLine("\n\n");
            string letters = "bcd";
            int index = str.IndexOfAny(letters.ToCharArray());
            if(index != -1)
            {
                Console.WriteLine($"\n Index of first from {letters} :: {index}. Letter {str[index]}");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.WriteLine("\n\n");
            string one = "ABc", two = "Abc";
            Console.WriteLine($"\n {one} == {two} :: {one == two}");
            Console.WriteLine($"\n {one} CompareTo {two} :: {one.CompareTo(two)}");
            Console.WriteLine($"\n {one} CompareTo {two} :: {String.CompareOrdinal(one,two)}"); // a(97), A(65)

            Console.WriteLine($"\n {one} CompareTo {two} :: {String.Compare(one,two)}"); // a(97), A(65)


            // 
            Console.WriteLine("\n\n");
            Console.WriteLine($"Origin text  -----> {str}");
            Console.WriteLine($"Remove       -----> {str.Remove(10)}");
            Console.WriteLine($"Remove       -----> {str.Remove(10,5)}");
            Console.WriteLine($"Replace      -----> {str.Replace('a','/')}");
            Console.WriteLine($"Insert       -----> {str.Insert(1, "new text ")}");
            Console.WriteLine($"Substring    -----> {str.Substring(0,10)}");

            string[] words = str.Split(" /\n\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string[] hkeys = { "int", "double", "float" };
            string allKeys = String.Join(",", hkeys);
            Console.WriteLine(allKeys);

        }
    }
}
