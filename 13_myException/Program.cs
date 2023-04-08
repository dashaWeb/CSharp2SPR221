using System;

namespace _13_myException
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            try
            {
                product.Name = "Bread";
                Console.WriteLine($"\n{product.Name}\n");
                product.DateIn = new DateTime(2023, 04, 09, 14, 0, 0);
            }
            catch (BadProductDateException ex)
            {
                Console.WriteLine($"Message   :: {ex.Message}");
                Console.WriteLine($"ErrorDate :: {ex.ErrorDate}");
            }
            product.InputName();
            Console.WriteLine($"\nProduct name :: {product.Name}");
        }
    }
}
