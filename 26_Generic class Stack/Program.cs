using System;

namespace _26_Generic_class_Stack
{
    class Program
    {
        static void Swap<T>(ref T one,ref T two)
        {
            T tmp = one;
            one = two;
            two = tmp;
        }
        static T Max<T>(T one, T two) where T: IComparable<T>
        {
            return one.CompareTo(two) > 0 ? one : two;
        }
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>(10);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            for (int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack[i]);
            }

            while(stack.Count > 0)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Capacity);

            int a = 5, b = 10;
            Console.WriteLine($"\n\nA = {a} \t B = {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"\n\nA = {a} \t B = {b}");

            int one = 10, two = 5;
            Console.WriteLine($"Max {one}, {two} = {Max(one,two)}");
        }
    }
}
