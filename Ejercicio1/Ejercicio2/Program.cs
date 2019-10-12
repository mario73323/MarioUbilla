using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se generara un cuadrado de asteriscos");
            Console.WriteLine("Por favor ingrese el tamaño del cuadrado");
            int num1 = 0;
            num1 = Ingresar();
            for (int i = 0; i < num1; i++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
            for (int i = 0; i < num1 - 2; i++)
            {
                for (int j = 0; j < num1; j++)
                {
                    if (j > 0 && j < num1 - 1)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write("\n");
            }
            for (int i = 0; i < num1; i++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();

        }
        public static int Ingresar()
        {
            Console.WriteLine("Ingrese un numero");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero valido");
                numero = Ingresar();
            }
            if (numero <= 0)
            {
                Console.WriteLine("No se aceptan numeros negativos ni cero, ingrese un numero valido");
                numero = Ingresar();
            }
            return numero;
        }
    }
}
