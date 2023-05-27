using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _37_Xml
{
    // клас для серіалізації - public 
    // серіалізувати можна public поля - властивості
    // явний конструктор по замовчуванню
    public class Engine
    {
        public double Power { get; set; }
        public Engine()
            :this(1.0)
        {}
        public Engine(double power)
        {
            Power = power;
        }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }
    public class Car
    {
        //[XmlAttribute("Number")]
        public int id;
        [XmlIgnore()]
        public string brand;
        public Car()
            :this(0,"Nobrand",1.0)
        { }
        public Car(int id, string brand, double power)
        {
            Brand = brand;
            Engine = new Engine(power);
            this.id = id;
        }
        [XmlIgnore()]
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public override string ToString()
        {
            return $"Id {id}. \t Car brand {Brand ?? "NoBrand"}. \t {Engine}";
        }
    }
}
