using System;
using System.IO;

namespace _40_Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine($"Current path : \n\t{Directory.GetCurrentDirectory()}");
             Directory.CreateDirectory("A");
             Directory.SetCurrentDirectory("A");
             Console.WriteLine($"Current path : \n\t{Directory.GetCurrentDirectory()}");

             Directory.CreateDirectory("A1");
             Directory.CreateDirectory("A2");
             File.WriteAllText("a.txt", "File a.txt content");
             File.WriteAllText("b.txt", "File b.txt content");

             File.WriteAllText("A1/a.txt", "File a.txt content");
             File.WriteAllText("A2/a2.txt", "File a2.txt content");

             //string[] fnames = Directory.GetFiles("A1");
             //Console.WriteLine(String.Join("\n",fnames));

             string[] fnames = Directory.GetFiles(".","*.*",SearchOption.AllDirectories);
             Console.WriteLine(String.Join("\n", fnames));
             foreach (var item in fnames)
             {
                 Console.WriteLine(Path.GetFileName(item) + "  " + Path.GetDirectoryName(item));
             }

             string[] dir = Directory.GetDirectories(".");
             foreach (var item in dir)
             {
                 Console.WriteLine(Path.GetFileName(item));
             }*/

            /*string path = @"D:\Даша\дз";
            string[] entries = Directory.GetFileSystemEntries(path);
            Console.WriteLine($"\n\n ------------ {path}");
            foreach (var item in entries)
            {
                FileInfo fi = new FileInfo(item);
                string info = "<DIR>";
                if (!fi.Attributes.HasFlag(FileAttributes.Directory))
                    info = fi.Length.ToString();
                Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-30} {info,-15}");
            }*/

            string path = "B";
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }
            Console.WriteLine($"Attrib of 'B' {di.Attributes}");
            File.WriteAllText("B/b1.txt", "Hello from b1");
            File.WriteAllText("B/b2.txt", "Hello from b2");
            FileInfo[] list = di.GetFiles();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Length}");
            }
        }
    }
}
