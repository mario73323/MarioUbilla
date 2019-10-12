using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 15; i++)
            {
                for (int h = 0; h <= 12; h++)
                {
                    Console.WriteLine("{0} * {1} = {2}", c, h, c * h);
                }
                c++;
                Console.WriteLine("\n \n");
            }
            Console.ReadKey();
        }
    }
}