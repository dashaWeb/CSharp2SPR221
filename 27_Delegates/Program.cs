using System;

namespace _27_Delegates
{

    // визначити тип делегату, делегат = тип (компілятор створить нам клас), який містить у собі посилання на метод(лямбда) з певною сигнатурою 
    delegate void MsDelegates(string message); // object MsDelegates може посилатися на (static, no static) void - метод з параметром типу string
    static class Greeting
    {
        public static void Hello(string name) // цей метод підходить під наш делегат MsDelegates
        {
            Console.WriteLine($"Hello, {name}");
        }
        public static void Bye(string name) // цей метод підходить під наш делегат MsDelegates
        {
            Console.WriteLine($"Bye, {name}");
        }
        public static void HowAreYou(string name) // цей метод підходить під наш делегат MsDelegates
        {
            Console.WriteLine($"How Are You, {name}");
        }
        public static void HowAreYou(string name, string surname) // цей метод НЕ підходить під наш делегат MsDelegates
        {
            Console.WriteLine($"How Are You, {name} {surname}");
        }
        public static void DrawLine(int len, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string('-', len));
            Console.WriteLine();
            Console.ResetColor();
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Greeting.DrawLine(40,ConsoleColor.Red);
            Greeting.Hello("Ivan"); // явний виклик(invoke) статичного метода 

            MsDelegates del = new MsDelegates(Greeting.Hello); // створили обєкт делегату та пов'язали з методом (Greeting.Hello)
            Console.WriteLine($"_______ Del references to method :: {del.Method}");
            Console.WriteLine($"_______ Del targets to object    :: {del.Target}"); // Target - цільовий обєкт, для якого буде працювати метод (зараз null, бо static метод)
            del.Invoke("Ivan"); // неявний виклик (Invoke) статичного методу через делегат
            del("Maria"); // неявний виклик (Invoke) статичного методу через делегат

            del = Greeting.HowAreYou; // пов'язали делегат з методом Greeting.HowAreYou
            Console.WriteLine($"_______ Del references to method :: {del.Method}");
            //del = null;
            /*if(del != null)
            {
                del.Invoke("Ivan");
            }*/
            // ?? ? 
            del?.Invoke("Ivan");
            Console.WriteLine();

            MsDelegates groupDel = Greeting.Hello; // посилається на Hello
            // += - add method
            // -= - remove method
            groupDel += Greeting.HowAreYou;// посилається на Hello та HowAreYou
            groupDel += Greeting.HowAreYou;// посилається на Hello та HowAreYou
            groupDel += Greeting.Bye;// посилається на Hello та HowAreYou
            // groupDel - це груповий делегат(мультиадресний, multiaddress, multicast) містить масив посилань га методи
            groupDel("Olia"); // запускається група методів

            groupDel -= Greeting.Bye; // відєднали від делегату метод Greeting.Bye
            groupDel -= Greeting.HowAreYou; // відєднали від делегату метод Greeting.HowAreYou (1 штука)
            Console.WriteLine();
            groupDel("Dmytro");
            Console.WriteLine($"_______ Del references to method :: {groupDel.Method}");

            Console.WriteLine();
            groupDel = new MsDelegates(Greeting.Hello) + Greeting.HowAreYou;
            groupDel("Vitaliy");

        }
    }
}
