using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _37_Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "car.xml";
            Car car = new Car(122, "Toyota", 2.3);
            Car car2 = new Car(300, "Peguot", 2.7);

            //XmlSerializer xs = new XmlSerializer(typeof(Car));
            /*using ( FileStream fs = new FileStream(fname,FileMode.Create))
            {
                xs.Serialize(fs, car);
            }*/
            /*using (FileStream fs = new FileStream(fname,FileMode.Open))
            {
                Car recCar = xs.Deserialize(fs) as Car;
                Console.WriteLine($"Recovered car :: {recCar}");
            }*/
            string fnameCars = "listCars.xml";
            List<Car> cars = new List<Car>()
            {
                car,
                car2
            };
            XmlSerializer xsl = new XmlSerializer(typeof(List<Car>));
            using (TextWriter tw = new StreamWriter(fnameCars))
            {
                xsl.Serialize(tw, cars);
            }

            /*using (TextReader tr = new StreamReader(fnameCars))
            {
                var listCar = xsl.Deserialize(tr) as List<Car>;
                Console.WriteLine($"\n\n Recovered list of cars \n{String.Join<Car>("\n",listCar)}");
            }*/
        }
    }
}
