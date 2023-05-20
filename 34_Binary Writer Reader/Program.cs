using System;
using System.IO;

namespace _34_Binary_Writer_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string fname = "my.dat";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            {
                string test = "Test-line Тестовий рядок";
                double valueD = -23.456;
                int valueI = 45623;
                int[] array = { 10, 20, 30, 4, 55 };

                bw.Write(test);
                bw.Write(valueD);
                bw.Write(valueI);

                bw.Write(array.Length);
                foreach (var item in array)
                {
                    bw.Write(item);
                }

            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
            {
                string readStr = br.ReadString();
                Console.WriteLine($"Read str :: {readStr}");
                Console.WriteLine($"Double   :: {br.ReadDouble()}");
                Console.WriteLine($"int      :: {br.ReadInt32()}");

                Console.WriteLine("Recovered Array :: ");
                int[] readArray = new int[br.ReadInt32()];
                for (int i = 0; i < readArray.Length; i++)
                {
                    readArray[i] = br.ReadInt32();
                    Console.WriteLine($"{readArray[i],7}");
                }

            }*/
            int[] arr = new int[] { };

            Console.WriteLine($"Enter number(int(0-255)) :");
            int j = 0;
            do
            {
                Array.Resize<int>(ref arr, arr.Length + 1);
                arr[j] = Convert.ToInt32(Console.ReadLine());
                j++;
            } while (j <=10);
            //Console.WriteLine($"{arr.Length}");
            string filename = "myintarr.dat";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(filename, FileMode.Create)))
            {
                bw.Write(arr.Length);
                foreach (var item in arr)
                {
                    bw.Write(item);
                }

            }
            using (BinaryReader br = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {
                int[] readArray = new int[br.ReadInt32()];
                for (int i = 0; i < readArray.Length; i++)
                {
                    readArray[i] = br.ReadInt32();
                    Console.WriteLine($"{readArray[i],7}");
                }

            }
        }
    }
}
