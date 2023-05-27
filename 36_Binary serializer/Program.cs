using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace _36_Binary_serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, "Ford", 2.3);
            Car car2 = new Car(200, "Mitsubishi", 2.9);
            Console.WriteLine(car);
            Console.WriteLine(car2);
            Console.WriteLine("==============================\n");


            /*string fname = "car.dat";
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fs = new FileStream(fname, FileMode.Create))
            {
                bf.Serialize(fs, car);
                bf.Serialize(fs, car2);
            }

            using (FileStream fs = new FileStream(fname,FileMode.Open))
            {
                Car rCar =(Car) bf.Deserialize(fs);
                Console.WriteLine($"Recovered car : \n {rCar}");
                rCar =(Car) bf.Deserialize(fs);
                Console.WriteLine($"Recovered car : \n {rCar}");
            }*/

            Dictionary<int, Car> salon = new Dictionary<int, Car>
            {
                [100] = car,
                [200] = car2
            };
            BinaryFormatter bf = new BinaryFormatter();
            string fnameSalon = "carsalon.dat";
            using (FileStream fs = new FileStream(fnameSalon, FileMode.Create))
            {
                bf.Serialize(fs, salon);

                fs.Position = 0;

                //fs.Seek(0, SeekOrigin.Begin);

                Dictionary<int, Car> salonR = (Dictionary<int, Car>)bf.Deserialize(fs);
                Console.WriteLine("\n\n Recovered car salon");
                foreach (var p in salonR)
                {
                    Console.WriteLine($"{p.Key}\t{p.Value}");
                }
            }
        }
    }
}
