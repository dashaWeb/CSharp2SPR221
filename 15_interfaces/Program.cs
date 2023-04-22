using System;

namespace _15_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck() { Weight = 4};
            Console.WriteLine("\n----------- Duck as IMove ---------------");
            Console.WriteLine($"Duck weight {duck.Weight}");
            duck.Move();
            duck.Fly();
            duck.Swim();
            //Console.WriteLine($"Speed :: {duck.Speed}"); // ок - якщо є неявна реалізація властивості, методу
            Console.WriteLine();
            Console.WriteLine("\n----------- Duck as IMove ---------------");
            IMove im = duck;
            Console.WriteLine($"Speed :: {im.Speed}");
            im.Move();
            Console.WriteLine();
            Console.WriteLine("\n----------- Duck as IFly ---------------");
            IFly ifl = duck;
            Console.WriteLine($"Speed :: {ifl.Speed}");
            ifl.Fly();
            Console.WriteLine();
            Console.WriteLine();


            StreamerDuck streamerDuck = new StreamerDuck();
            streamerDuck.Fly();

            Duck[] ducks =
            {
                duck,
                streamerDuck
            };
            Console.WriteLine();

            Console.WriteLine();

            foreach (var item in ducks)
            {
                item.Fly();
            }

        }
    }
}
