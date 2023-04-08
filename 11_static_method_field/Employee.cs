using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_static_method_field
{
    enum Position
    {
        None, Manager, Developer, Economist, Director
    }
    class Employee
    {
        private static int lastId;
        public readonly int ID = ++lastId; // readonly поле тільки для читання, встановлюється 1 раз, в конструкторі або тут
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public Position Position { get; set; }
        public static int LastId { get => lastId; }
        public override string ToString()
        {
            return $"ID {ID}) Name :: {Name} \t Birth :: {Birth.ToShortDateString()} \t Position :: {Position}";
        }
        static Employee() // без параметрів, спрацює до першого використання
        {
            Console.WriteLine("\t Static ctor done");
            lastId = new Random().Next(1, 10) * 1000;
        }
        public int Age { get => (int)((DateTime.Today - Birth).TotalDays / 365.25);}
        public static bool SamePosition(Employee em1, Employee em2)
        {
            return em1.Position == em2.Position;
        }
    }
}
