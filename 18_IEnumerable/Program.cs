using System;
using System.Text;
namespace _18_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumerable - те, що перелічується, по ньому можна переміщатися
            //Enumerator - той, хто переміщається

            // низькорівневий обхід масиву
            int[] arr = { 10, 23, 44, -100, 77 };
            var enArr = arr.GetEnumerator(); // отримали перелічувач по масиву
            while(enArr.MoveNext())// якщо є наступний
            {
                Console.Write($"{enArr.Current, 10}"); // виводимо поточний елемент (у поточній позиції перелічувача)
            }
            Console.WriteLine();

            string str = "Hello from IEnumerable";
            var enStr = str.GetEnumerator();
            while(enStr.MoveNext())
            {
                Console.Write($"{enStr.Current,2}");
            }
            Console.WriteLine();
            StringBuilder sb = new StringBuilder("");
            enStr.Reset();
            while (enStr.MoveNext())
            {
                sb.Append(enStr.Current);
                sb.Append("_");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
