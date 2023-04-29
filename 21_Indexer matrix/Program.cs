using System;

namespace _21_Indexer_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(2, 3);
            try
            {
                m[0, 0] = 100;
                m[1, 2] = 200;
                Console.WriteLine($"Read [1][3] :: {m[1,2]}");
                Console.WriteLine();
                Console.WriteLine(m);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
