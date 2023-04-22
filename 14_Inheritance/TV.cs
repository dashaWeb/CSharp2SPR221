using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Inheritance
{
    // успадкування тільки одиночне від класу, але можнареалізувати багато інтерфейсів
    // є тільки відкритий тобто public
    public class TV : Device
    {
        public int Diagonale { get; set; } = 42;
        //public override bool HasBattery => false;
        public override bool HasBattery => false;
        public TV(string brand = "NoBrand", int year = 2000, int diagonale = 42)
            :base(brand,year) // виклик к-ра базовго класу
        {
            Diagonale = diagonale;
        }
        
        public override void PrintModes()
        {
            Console.WriteLine($"{this.GetType().Name} {Brand} can show tv-channels");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Diagonale : {Diagonale}"; // base.ToString() тобто ToString() з класу Device
        }
    }
}
