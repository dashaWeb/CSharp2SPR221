using System;

namespace _11_static_method_field
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Man started .... ");
            Console.WriteLine($"Last id {Employee.LastId}");
            Employee employee1 = new Employee()
            {
                Name = "Denis",
                Birth = DateTime.Parse("30/10/2000"),
                Position = Position.Developer
            };
            Console.WriteLine(employee1);
            Console.WriteLine($"Age :: {employee1.Age}");
            Employee employee2 = new Employee()
            {
                Name = "Ivan",
                Birth = new DateTime(1990,9,16),
                Position = Position.Developer
            };
            Console.WriteLine(employee2);
            Console.WriteLine($"Age :: {employee2.Age}");
            Console.WriteLine($"Same Position :: {Employee.SamePosition(employee1,employee2)}");
        }
    }
}
