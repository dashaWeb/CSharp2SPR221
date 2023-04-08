using System;

namespace _02_ref_out_params
{
    class Program
    {
        static void BadSwap(int a, int b) // параметри передаються за значенням (приходить копія значень)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        // ref, out => передача за посиланням
        // ref - передає фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
        // out - передає фактичний параметр може  БУТИ НЕ ПРОІНІЦІАЛІЗОВАНИЙ, параметр для збереження результату
        static void Swap(ref int a,ref int b) // параметри передаються за посиланням 
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            /*int a = 5, b = 9;
            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a,ref b);
            Console.WriteLine($"a = {a}\t b = {b}");
            // value types {struct, enum, int, double, char} = копіювання значень
            // reference types {class, string, BuilderString, interface, delegate, array}
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(9));*/
            /*char s = Convert.ToChar(Console.Read());
            Console.WriteLine(s);
            int ss = Console.Read();
            Console.WriteLine(ss);*/
            var res = Console.ReadKey();
            Console.WriteLine(res.KeyChar);
        }
    }
}
