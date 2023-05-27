using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Binary_serializer
{
    [Serializable]
    class Engine
    {
        public double Power { get; set; }
        public Engine(double power)
        {
            Power = power;
        }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }
    [Serializable] //атрибут позначає можливість серіалізувати об'єкт типу Car
    class Car
    {
        private int id;
        //[NonSerialized]
        private string brand;
        public Car(int id, string brand, double power)
        {
            Brand = brand;
            Engine = new Engine(power);
            this.id = id;
        }
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public override string ToString()
        {
            return $"Id {id}. \t Car brand {Brand ??"NoBrand"}. \t {Engine}";
        }
    }
    // Виконати серіалізацію масиву або списку обєктів машин(5). Перевірити, що приватні поля теж серіалізуються
}
