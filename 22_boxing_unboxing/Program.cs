using System;

namespace _22_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing (упаковка обєкта типу значення у обєкт типу посилання) value type ---> ref type
            // boxing можемо виконувати неявно
            //int value = 12; // stack
            double value = 46.67;
            object obj = value; // boxing obj ---> heap 
            Console.WriteLine($"obj = {obj} has type {obj.GetType()}");

            // unboxing (розпакрвка з обєкту типу посилання у обєкт типу значення) ref type ----> value type
            // треба робити явно (int)obj

            if(obj is int)
            {
                int value2 = (int)obj;
                Console.WriteLine($"Unboxing from obj into int {value2}");
            }
            else if(obj is double)
            {
                double value2 = (double)obj;
                Console.WriteLine($"Unboxing from obj into double {value2}");
            }
            else
            {
                Console.WriteLine("Not int and not double");
            }
            object[] arr = { "Hello", 123, 5.6 };
            // Визначити статичний методи у класі Program, який отримує масив типу object, i обчислює суму цілих чисел(int), кількість дробових (double,float,decimal) та конкатенує рядки. І виводить на екран результат
        }
    }
}

// 
