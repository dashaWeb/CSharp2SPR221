using System;

namespace _32_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Company softServe = new Company { Name = "SoftServe" };
            Company honeyComb = new Company { Name = "HoneyComb" };

            Interviwer ann = new Interviwer { Name = "Ann" };
            Interviwer ivan = new Interviwer { Name = "Ivan" };
            //subscribe
            softServe.NewPosition += ann.DoSomething;
            softServe.NewPosition += ivan.DoSomething;
           // softServe.NewPosition = ivan.DoSomething; // error if event

            honeyComb.NewPosition += ann.DoSomething;
            honeyComb.NewPosition += ivan.DoSomething;


            softServe.AddPosition("Intern C++");
            Console.WriteLine();
            honeyComb.AddPosition("Junior .NET");

            honeyComb.NewPosition -= ann.DoSomething;
            //honeyComb.NewPosition = null;// error if event
            Console.WriteLine();
            honeyComb.AddPosition("Middle Frontend");
        }
    }
}
