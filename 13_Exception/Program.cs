using System;
using System.Collections;
namespace _13_Exception
{
    class ExceptionTestClass
    {
        public static double Div(double a, double b)
        {
            if(b==0)
            {
                var ex = new DivideByZeroException("Divide by zero");
                ex.Data.Add("TimeStamp", DateTime.Now);
                ex.HelpLink = "google.com";
                ex.Data["Value"] = a;
                throw ex;
            }
            if(b > 100_000/*double.MaxValue*/)
            {
                throw new OverflowException("Too big number");
            }
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 100, y = 20;
            try
            {
                Console.WriteLine($"Div :: {ExceptionTestClass.Div(x,y)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivByZero   :: {ex.Message}");
                Console.WriteLine($"Source      :: {ex.Source}");
                Console.WriteLine($"StackTrace  :: {ex.StackTrace}");
                Console.WriteLine($"TargetSite  :: {ex.TargetSite}");
                Console.WriteLine($"HelpLink    :: {ex.HelpLink}");
                Console.WriteLine("\n\n========== Data ==========\n\n");
                Console.WriteLine($"TimeStamp   :: {ex.Data["TimeStamp"]}");
                Console.WriteLine($"Value       :: {ex.Data["Value"]}");
                Console.WriteLine("\n\n========== or Data ==========\n\n");

                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key} :: {item.Value}");
                }
                Console.WriteLine("\n\n========== or Data ==========\n\n");
                foreach (var item in ex.Data.Keys)
                {
                    Console.WriteLine($"{item} :: {ex.Data[item]}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Message :: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message :: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nFinally always works");
            }
        }
    }
}
