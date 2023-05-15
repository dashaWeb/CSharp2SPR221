using System;

namespace _30_Std_delegates
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Action act = Hello;
            act += () => Console.WriteLine("Studing gelegates");
            act();

            Action<string, int> act2 = (str, number) => Console.WriteLine($"{number} :: {str}");
            act2("Test", 10);
            Console.WriteLine();

            Func<int, int, double> funcAvg = (one, two) => (one + two) / 2.0;
            Console.WriteLine($"Func Average (10,11) :: {funcAvg(10,11)}");
            Console.WriteLine();

            Predicate<string> pred = s => char.IsUpper(s[0]);
            Console.WriteLine($"Has first upper letter :: {pred("Good")}");
            Console.WriteLine($"Has first upper letter :: {pred("error")}");

            Comparison<string> cmp = (s1, s2) => s1.Length.CompareTo(s2.Length);
            string wordA = "Program";
            string wordB = "Python";
            Console.WriteLine($"Test comparison by length :: {cmp(wordA,wordB)}");//1
            Console.WriteLine($"Test comparison by length :: {cmp(wordB,wordA)}");//-1

        }
        static void Hello()
        {
            Console.WriteLine("Hello from std delegates (Action)");
        }
    }
}
