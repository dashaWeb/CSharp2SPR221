using System;

namespace _10_static_class
{
    // static class - 
    // 1) може містити лише статичні методи та поля
    // 2) не можна створити екземпляр 
    static class AreaShapes
    {
        const double PI = 3.14; // константа у C# неявно статична
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;
        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius,2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //AreaShapes m = new AreaShapes(); // error
            Console.WriteLine($"Trian area :: {AreaShapes.TrianArea(10,20)}");
            Console.WriteLine($"Circle area :: {AreaShapes.CircleArea(10)}");
        }
    }
}
