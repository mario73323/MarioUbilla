using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso();
        }
        public static void Proceso()
        {

            int opcion = Opcion(), num = 0, sumatoria = 0, factorial = 1;
            if (opcion == 1)
            {

            }
            if (opcion == 2)
            {
                num = Ingresar();
                for (int i = 1; i <= num; i++)
                {
                    sumatoria = sumatoria + i;
                }
                Console.WriteLine("LA SUMATORIA DEL NUMERO ES {0}\n", sumatoria);
                Proceso();
            }
            if (opcion == 3)
            {
                num = Ingresar();
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("El factorial del numero es {0}\n", factorial);
                Proceso();
            }

        }
        public static int Opcion()
        {
            Console.WriteLine("escoja una opcion ingresando el numero del siguiente panel \n" +
                "1.- SALIR \n" +
                "2.- SUMATORIA NUMERO\n" +
                "3.- FACTORIAL DEL NUMERO\n");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese una opcion valido");
                numero = Opcion();
            }
            if (numero == 1 || numero == 2 || numero == 3)
                return numero;
            else
            {
                Console.WriteLine("Ingrese una opcion valida");
                numero = Opcion();
            }
            return numero;
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
            if (numero < 0)
            {
                Console.WriteLine("Ingrese un numero valido");
                numero = Ingresar();

            }
            return numero;
        }

    }

}