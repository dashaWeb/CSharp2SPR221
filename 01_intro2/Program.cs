using System;
using System.Text;
namespace _01_intro2
{
    class Program
    {
        static void testConsole()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("\t\"C# language - популярна мова під .NET\" \n\n");
            Console.ReadKey();
            Console.Clear();
            Console.CursorLeft = 20;
            Console.CursorTop = 10;
            Console.WriteLine("Hello World");
        }
        static void writeText()
        {
            double d = 2.3D;
            float f = 5.3F;
            //float ff = (float)5.3;
            decimal money = 45.36M;
            // 1) write
            Console.WriteLine("Money :: " + money + " $\t " + (money + 5));

            // 2) format line
            Console.WriteLine("Money :: {0} $\t {0}", money);
            int a = 2, b = 10, c = 12;
            Console.WriteLine("A = {0} \t B = {1} \t C = {2}; \n C = {2}; \t B = {1}; \t A = {0};", a, b, c);
            // 3) interpolation line
            Console.WriteLine($"Money :: {money}");
            Console.WriteLine($"More number :: {(a > b ? a : b)};");

            System.String str = "C# Language";
            string line = "Hello !!! ";
            Console.Write(str);
            Console.Write(line);

        }
        static void InputNumber()
        {
            //1) convert string ---> double
            /* double value;
             try
             {
                 value = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine($"Double value {value,-20}");
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Message :: {ex.Message}");
             }*/
            /*//2) type.Parse()
            Console.WriteLine($"Input int number ({int.MinValue} - {int.MaxValue})");
            int value;
            value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Int value {value}");*/
            //2) type.tryParse()
            Console.WriteLine($"Input int number ({int.MinValue} - {int.MaxValue})");
            int value;
            if (int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine($"Int value {value}");
            }
            else
            {
                Console.WriteLine("Unsuccess parse to int");
            }
        }
        static void Main(string[] args)
        {
            //testConsole();
            //writeText();
            //InputNumber();
            // () , *, /, + , - , %
            // || , && , !
            // >, < , ==, !=, <=, >=
            // a++, b--, --b, ++a;
            // a = a+5; a+=5, a-=5; a*=5, a/=5; a%=5;
            // a ? b : c;

            // if, else if, else
            /*int a = 49;
            switch (a)
            {
                case < 50: case 51:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 50:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }*/
            /*for (int i = 0; i < 5; i++)
            {

            }*/
            /*while (true)
            {

            }
            do
            {

            } while (true);
            foreach (var item in collection)
            {

            }*/

        }
    }
}
