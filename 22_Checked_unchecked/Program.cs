using System;

namespace _22_Checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {

            //byte = 0 - 255
            /*byte b = 100;
            b = (byte)(b + 200);
            Console.WriteLine(b);*/

            // режим контролю переповнення можна задати за допомогою ключових слів checked || unchecked
            // checked - задає режим контролю переповнення з генерацією винятку типу OverflowException
            // unchecked - задає ігнорування виникнення переповнення
            byte bb = 255;
            try
            {
                checked
                {
                    bb++; // throw OverflowException
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                foreach (var item in ex.Data.Keys)
                {
                    Console.WriteLine($"{item} :: {ex.Data[item]}");
                }
                
            }
            try
            {
                unchecked
                {
                    bb++; // throw OverflowException
                    Console.WriteLine(bb);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                foreach (var item in ex.Data.Keys)
                {
                    Console.WriteLine($"{item} :: {ex.Data[item]}");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            byte bbb = 100;
            try
            {
                Console.WriteLine(checked((byte)(bbb + 200)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(unchecked((byte)(bbb + 200)));
        }

    }
}
