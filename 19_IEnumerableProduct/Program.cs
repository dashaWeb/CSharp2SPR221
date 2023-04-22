using System;

namespace _19_IEnumerableProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Item apple = new Item { Name = "Apple", Price = 20 };
            Item grapes = new Item { Name = "Grapes", Price = 40 };
            Item orange = new Item { Name = "Orange", Price = 50 };
            Item blueberry = new Item { Name = "Blueberry", Price = 70 };

            var bucket = new ShopBucket();
            bucket.AddItem(apple);
            bucket.AddItem(grapes);
            bucket.AddItem(orange);
            bucket.AddItem(blueberry);

            Console.WriteLine(bucket);
            Console.WriteLine();
            Console.WriteLine("==========================================");
            foreach (Item product in bucket.GetCheaperItems(40))
            {
                Console.WriteLine(product);
            }
        }
    }
}
