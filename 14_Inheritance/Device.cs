using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Inheritance
{
    public abstract class Device
    {
        // virtual методи, властивості, події
        // abstract - клас 1) не можна створити обєкт класу
        // можна працювати з похідними типами через посилання на абстр клас
        protected string brand; // буде видно у дочірному protected
        public string Brand
        {
            get => brand;
            set => brand = value == null ? "Nobrand" : value;
        }
        private int year;// не буде видно у дочірному типі
        public int Year
        {
            get => year;
            set
            {
                year = value <= DateTime.Today.Year ? value : throw new Exception("Bad year of device");
            }
        }
        public Device(string brand = "NoBrand", int year = 2000)
        {
            Brand = brand;
            Year = year;
        }
        //public virtual bool HasBattery { get => false; } // віртуальна властивість, зараз тільки для читання
        public abstract bool HasBattery { get; } // абстрактна властивість для читання, похідний тип буде реалізувати тільки get 
        protected internal int Price { get; set; } // internal - видимий в поточній збірці
        protected internal int Weight { get; set; }
        public override string ToString()
        {
            return $"Device : {this.GetType().Name, -10} Brand : {Brand, -15} Year : {Year,-10} Has Battery : {HasBattery,-10}";
        }
        public virtual void PrintModes()
        {
            Console.WriteLine($"{this.GetType().Name} {Brand} Device");
        }
    }
}
