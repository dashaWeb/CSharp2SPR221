using System;

namespace _16_IComparable
{
    class Person : IComparable, IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Person))
            {
                throw new ArgumentException("CompareTo :: object is not Person");
            }
            return this.Age.CompareTo(((Person)obj).Age);
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Age :: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Misha", 20),
                new Person("Masha", 15),
                new Person("Anna", 36),
                new Person("Denis", 25)
            };
            Console.WriteLine("\n--------People---------");
            foreach (var item in people)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine("\n--------People Sort---------");
            Array.Sort(people);
            foreach (var item in people)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
