using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Inheritance
{
    class SmartTV : TV
    {
        //new string brand
        public SmartTV(string brand = "NoBrand", int year = 2000, int diagonale = 42)
            :base(brand,year,diagonale)
        {

        }
        public override void PrintModes() // new- для вказання, що наш перекриває метод з базового класу
        {
            //Console.WriteLine("TV can show tv-channels");
            //base.PrintModes(); // викликаємо метод з базового класу
            Console.WriteLine($"Smart TV {Brand} can surf in internet");
        }
    }
}
