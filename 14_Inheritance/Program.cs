using System;
using _14_Inheritance;
namespace Use_device
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tV = new TV("LG");
            //TV.Price = 15_000 = // internal
            //TV.Weight = 4; // protected
            Console.WriteLine(tV.ToString());
            SmartTV smartTV = new SmartTV();
            Console.WriteLine(smartTV.ToString());
            Smartphone smartphone = new Smartphone();
            smartphone.demo();
            Console.WriteLine("\n\n");
            Device[] devices =
            {
                tV,
                smartTV,
            };

            foreach (var item in devices)
            {
                item.PrintModes();
                // way 1
                /*try
                {
                    ((TV)item).PrintModes();
                }
                catch (Exception)
                {
                }*/
                // way 2
                /*TV alltv = item as TV;
                if(alltv != null)
                {
                    alltv.PrintModes();
                }
                Smartphone smartphone1 = item as Smartphone;
                if(smartphone1 != null)
                {
                    smartphone1.demo();
                }*/

                /*if(item is TV)
                {
                    ((TV)item).PrintModes();

                }
                if(item is Smartphone)
                {
                    ((Smartphone)item).demo();
                    
                }*/
            }
        }
    }
}
