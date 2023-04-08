using System;

namespace _08_Enum
{
    enum Color : byte // const int
    {
        Red = 12,
        Blue = 9,
        Black = 6,
        White = 15
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.Red;
            Console.WriteLine($"{color} = {(byte)color}");
            Console.WriteLine("\n\n" + new string('=',50));
            Console.WriteLine("Enter color (Red = 12, Blue = 9)");
            /*string cl = Console.ReadLine();
            color = (Color)Enum.Parse(typeof(Color),cl);
            Console.WriteLine($"{color} = {(byte)color}");*/

            /*if(Enum.TryParse<Color>(Console.ReadLine(),true,out color))
            {
                if (Enum.IsDefined(typeof(Color), color))
                {
                    Console.WriteLine($"{color} = {(byte)color}");
                }
                else
                {
                    Console.WriteLine($"Parse success but {color} does not exist in Color");
                }
            }
            else
            {
                Console.WriteLine("Parse not success");
            }*/
            Console.WriteLine("\n\n" + new string('=', 50));
            // get all names of enum constant
            Console.WriteLine("\n GetNames :: ");
            //var colors = Enum.GetNames(typeof(Color));
            string[] colors = Enum.GetNames<Color>();
            Console.WriteLine(String.Join("\t", colors));
            Console.WriteLine("\n\n" + new string('=', 50));
            Color[] colorValue = Enum.GetValues<Color>();
            foreach (var item in colorValue)
            {
                Console.WriteLine($"{item} = {(byte)item}");
            }
            Console.WriteLine("\n\n" + new string('=', 50));

            Console.WriteLine($"Enter color : \n\t{String.Join("\n\t",Enum.GetNames<ConsoleColor>())}");
            ConsoleColor setColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true);
            Console.BackgroundColor = setColor;
            Console.Clear();
            Console.ReadKey();
            
        }
    }
}
