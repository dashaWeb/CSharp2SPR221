//using Newtonsoft.Json; !!!
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
namespace _38_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "car.json";
            Car car = new Car(122, "Toyota", 2.3);
            Car car2 = new Car(300, "Peguot", 2.7);

            /* string json = JsonConvert.SerializeObject(car);
             File.WriteAllText(fname, json);
             Console.WriteLine(json);*/

            /*Car rcar = JsonConvert.DeserializeObject<Car>(json);
            Console.WriteLine($"Parse string :: \n{rcar}");*/

            //string res = File.ReadAllText(fname);
            /*Car rcar = JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname));
            Console.WriteLine($"Recovered car :: \n{rcar}");*/

            /*List<Car> cars = new()
            {
                car,
                car2
            };
            string json = JsonConvert.SerializeObject(cars);
            Console.WriteLine(json);

            List<Car> rList = JsonConvert.DeserializeObject<List<Car>>(json);
            foreach (var item in rList)
            {
                Console.WriteLine(item);
            }*/

            Dictionary<int, Car> dictCars = new()
            {
                [car.id] = car,
                [car2.id] = car2
            };
            /*string json = JsonConvert.SerializeObject(dictCars);
            Console.WriteLine(json);

            Dictionary<int, Car> resCar = JsonConvert.DeserializeObject<Dictionary<int, Car>>(json);
            foreach (var item in resCar)
            {
                Console.WriteLine(item);
            }*/

            /*string json = JsonSerializer.Serialize<Car>(car); // only property !!!!
            Console.WriteLine(json);

            Car res = JsonSerializer.Deserialize<Car>(json);
            Console.WriteLine(res);*/


            /*string json = JsonSerializer.Serialize<Dictionary<int, Car>>(dictCars);
            Console.WriteLine(json);

            Dictionary<int, Car> resL = JsonSerializer.Deserialize<Dictionary<int, Car>>(json);
            foreach (var item in resL)
            {
                Console.WriteLine($"{item.Key}  :: {item.Value}");
            }*/


            WebClient wc = new WebClient();
            string json = wc.DownloadString("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
            Console.WriteLine(json);
        }
    }
}
