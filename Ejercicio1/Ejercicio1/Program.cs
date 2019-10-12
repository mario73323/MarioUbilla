using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un total de 5 numeros, se le indicara cual es el de mayor valor");
            int mayor, num1 = 0;
            num1 = Ingresar();
            mayor = num1;
            for (int i = 0; i < 4; i++)
            {
                num1 = Ingresar();
                if (mayor < num1)
                {
                    mayor = num1;
                }

            }
            Console.WriteLine("El numero mayor ingresado es {0}", mayor);
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
            return numero;
        }

    }

}