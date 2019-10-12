using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = 1, c2 = 100;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}       {1}", c1, c2);
                c1++;
                c2--;
            }
            Console.ReadKey();
        }
    }
}