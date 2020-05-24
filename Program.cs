using System;

namespace FourCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int N = Convert.ToInt32(Console.ReadLine());
            N += 5;
            Console.WriteLine(Convert.ToString(N));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello there");
            }
        }

    }
}
