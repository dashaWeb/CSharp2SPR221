using System;

namespace _20_overload_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction one = new Fraction(1, 2);
            Fraction two = new Fraction(1, 3);

            Fraction sum = one + two;
            Console.WriteLine($"{one} + {two} = {sum}");

            sum += one;
            Console.WriteLine($"sum += one :: {sum}");

            Fraction three = new Fraction(1, 2);
            Console.WriteLine($"{one} == {three} ? {one == three}");
            Console.WriteLine($"{one} == {two} ? {one != two}");

            // true,false;
            //one.Num = 0;
            if (one)
            {
                Console.WriteLine($"{one} == true");
            }
            else
            {
                Console.WriteLine($"{one} == false");
            }

            //int value = sum; // так можна якщо перевантажили як implicit
            Console.WriteLine($"\n{sum} cast to int :: {(int)sum}");

            Console.WriteLine($"\n{sum} cast to double :: {(double)sum}");
            double dValue = sum;
            Console.WriteLine(($"\n{sum} cast to double :: {dValue}"));

            one[0] = -33;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"one[{i}] :: {one[i]}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Handled :: {ex.Message}"); ;
            }

            Console.WriteLine($"\n\n ++{one} :: {one++}");
            Console.WriteLine($"\n\n ++{one} ");
            Console.WriteLine($"\n\n ++{one} :: {++one}");
        }
    }
    // Визначити для Дробу операції ---> -, *, /, >, <, <=, >=;
}
