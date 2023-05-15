using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EventHandler
{
    class Interviwer
    {
        public string Name { get; set; }
        // метод, що може бути обробником події під певний делегат
        public void DoSomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} Date ::  {args.Date.ToShortDateString()}");
        }
    }
}
