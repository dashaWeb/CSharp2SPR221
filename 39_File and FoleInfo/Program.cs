using System;
using System.IO;

namespace _39_File_and_FoleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string fname = "../../../my.txt";
            string[] lines = { "First line", "Second Line" };
            //Console.WriteLine(File.Exists(fname));
            if (!File.Exists(fname))
            {
                File.Delete(fname);
                Console.WriteLine($"File '{fname}' was deleted\n\n");
            }
            File.AppendAllLines(fname, lines);
            File.AppendAllText(fname, "Third line \nFourth line \n");

            Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");

            string fname2 = "../../../copy_my.txt";
            //File.Copy(fname, fname2); // exception якщо файл вже існує fname2
            //File.Copy(fname, fname2, true); // дозвіл на перезапис у файл копію
            *//*var fs = File.CreateText(fname);
            fs.WriteLine("Write something");
            fs.Dispose();

            File.AppendAllText(fname, "New Line");
            Console.WriteLine($"Content :: {File.ReadAllText(fname)}");
            Console.WriteLine($"Create time :: {File.GetCreationTime(fname)}");
            Console.WriteLine($"Last write time :: {File.GetLastWriteTime(fname)}");
            Console.WriteLine("\n");*/

            string fname3 = "../../../third.txt";
            FileInfo fi = new FileInfo(fname3);
            Console.WriteLine($"Is exists file :: {fi.Exists}");

            if(!fi.Exists)
            {
                using (var tw = fi.CreateText())
                {
                    tw.WriteLine("It is third file");
                }
            }
            Console.WriteLine($"Content of file third :: {File.ReadAllText(fname3)}");
            //fi.MoveTo("./third.txt");
            Console.WriteLine($"Length :: {fi.Length}");
            Console.WriteLine($"Extension of file :: {fi.Extension}");
            Console.WriteLine($"GetAttributes of file :: {File.GetAttributes(fname3)}");
            File.SetAttributes(fname3, FileAttributes.ReadOnly);
            Console.WriteLine($"GetAttributes of file :: {File.GetAttributes(fname3)}");
            var res = File.GetAttributes(fname3);
            Console.WriteLine(res);

        }
    }
}
