using System;
using System.Linq;
namespace _05_params_parameters
{
    
    class Program
    {
        /*static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }*/
        static int Sum(int a, params int[] arr)
        {
            /*int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;*/
            return arr.Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"{Sum(2,5,8,7)}");
            Console.WriteLine($"{Sum(2,5,8,7,4,58)}");
            Console.WriteLine($"{Sum(2,5,8)}");
        }
    }
}
