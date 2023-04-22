using System;

namespace _17_ICloneable
{
    class Student :ICloneable
    {
        public string Name { get; set; }
        public int[] marks;
        public Student(string name ="NoName", int marks = 5)
        {
            Name = name;
            this.marks = new int[marks]; // default (0);
        }
        public Student(string name = "NoName", params int[] marks) // Student("Olia",1,2,5,5,4,8);
        {
            Name = name;
            //this.marks = marks;
            this.marks =(int[]) marks.Clone();
        }
        public override string ToString()
        {
            return $"Name :: {Name, -10} Marks :: {String.Join<int>(",",marks)}";
        }

        public object Clone()
        {
            //return new Student(this); // copy ctor
            return new Student(Name, marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ann = new Student("Anna", 10, 5, 8, 9, 6, 5, 4); 
            Console.WriteLine(ann);

            Student clone = (Student)ann.Clone();
            clone.Name = "Denis";
            Console.WriteLine();
            Console.WriteLine(ann);
            Console.WriteLine(clone);
            Console.WriteLine();
            clone.marks[0] = 999;
            Console.WriteLine(ann);
            Console.WriteLine(clone);
        }
    }
}
