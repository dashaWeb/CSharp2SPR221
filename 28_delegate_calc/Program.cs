using System;

namespace _28_delegate_calc
{
    delegate double CalcDelegate(double one, double two);
    class Calculator
    {
        public static double Add(double one, double two) => one + two;
        /*{
            return one + two;
        }*/
        public static double Sub(double one, double two) => one - two;
        /*{
            return one - two;
        }*/
        // No static
        private double lastResult = 1;
        public  double Mult(double one, double two) => lastResult = one * two;
        /*{
            return one * two;
        }*/
        public override string ToString()
        {
            return $"Last multiplication result = {lastResult}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalcDelegate deleg = Calculator.Add;
            Console.WriteLine($"Method {deleg.Method}");
            Console.WriteLine($"Result {deleg(2,3)}");
            Console.WriteLine();

            deleg += Calculator.Sub;
            Console.WriteLine($"Method {deleg.Method}");
            Console.WriteLine($"Result {deleg(2, 3)}");
            Console.WriteLine();

            Console.WriteLine("----- Get result from Invocation list -------");
            foreach (Delegate d in deleg.GetInvocationList())
            {
                Console.WriteLine($"Operation {d.Method.Name}  :: {d.DynamicInvoke(10,15)}");
            }

            Calculator calc = new Calculator();
            deleg = calc.Mult; // Target = Calc
            deleg(4, 10); // lastResult = 4 * 10
            Console.WriteLine(calc);
            Console.WriteLine($"Del Target :: {deleg.Target}");
        }
    }
}
