using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
namespace _24_FileStream_Demo
{
    class Program
    {
        static void writeString(string value, string path)
        {
            using(FileStream fs = new FileStream(path,FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = Encoding.Unicode.GetBytes(value); // повернули масив з байтів, що відповідає рядку value  у кодуванні UTF8
                Console.WriteLine($"Test byte array :: {String.Join<byte>(" ",bytes)}");
                fs.Write(bytes, 0, bytes.Length);
            }
        }
        static string readString(string path)
        {
            string value = String.Empty;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                value = Encoding.Unicode.GetString(bytes);
            }
            return value;
        }
        static void writeInt(int value, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = BitConverter.GetBytes(value);
                fs.Write(bytes, 0, bytes.Length);
            }
        }
        static int readInt(string path)
        {
            int value = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[sizeof(int)];
                fs.Read(bytes, 0, bytes.Length);
                value = BitConverter.ToInt32(bytes, 0);
            }
            return value;
        }
        static void Main(string[] args)
        {
            string fname = "string.dat";
            writeString("Hello-привіт", fname);

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Read string from file :: {readString(fname)}");
            Console.WriteLine();
            string fname2 = "number.dat";
            writeInt(-10222, fname2);
            Console.WriteLine($"Read int from file :: {readInt(fname2)}");
            //string fname = "bytes.dat";
            /*using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                byte byteValue = 65;
                fs.WriteByte(byteValue);
                byte[] arr = { 10, 11, 12, 13, 14, 15 };
                fs.Write(arr, 0, arr.Length);

                //fs.Position = 0; // файловий курсор перемістили на початок файлу
                fs.Seek(0, SeekOrigin.Begin); // те саме
                //fs.Seek(-2, SeekOrigin.End); // перемістили на другий з кінця
                Console.WriteLine($"File size in bytes :: {fs.Length}");
                byte[] result = new byte[fs.Length];
                fs.Read(result, 0, result.Length);
                Console.WriteLine($"Read array :: {String.Join<byte>("\t",result)}");
                //fs.Close();
            }*/
           
        }
    }
}
