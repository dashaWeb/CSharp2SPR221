using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_Inheritance;

namespace Use_device
{
    class Smartphone : Device
    {
        public Smartphone(string brand = "NoBrand", int year = 2015)
            :base(brand,year)
        {

        }
        public override bool HasBattery => true;
        public void demo()
        {
            Console.WriteLine($"Check access drom Smartphone to device {base.brand}");
            //Console.WriteLine(base.Price);
            //Console.WriteLine($"Check weight {base.Weight}");
        }
    }
}
