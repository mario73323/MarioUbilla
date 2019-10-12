using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int c =Ingresar();
            for (int i = 0; i <= 15; i++)
            {
                    Console.WriteLine("{0} x {1} = {2}", c, i, c * i);
            }
            Console.ReadKey();
        }
        public static int Ingresar()
        {
            Console.WriteLine("Ingrese un numero para generar su tabla de multiplicar");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero valido");
                numero = Ingresar();
            }
            return numero;
        }
    }
}