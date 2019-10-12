using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero \n" +
                "la primera columna lo contara de 1 en 1\n" +
                "la segunda de dos en dos\n" +
                "la tercera de 3 en tres ");
            Proceso();
            Console.ReadKey();
        }
        public static void Proceso()
        {

            int num = Ingresar(), c1 = 0, c2 = 0, c3 = 0;
            if (num > 0)
            {
                do
                {
                    if (c1 <= num)
                    {
                        Console.Write("{0}    ", c1);
                        c1++;
                    }
                    if (c2 <= num)
                    {
                        Console.Write("{0}    ", c2);
                        c2 = c2 + 2;
                    }
                    if (c3 <= num)
                    {
                        Console.Write("{0}    ", c3);
                        c3 = c3 + 3;
                    }
                    Console.Write("\n");
                    
                } while (c1 < num);
            }
           
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
            if(numero<0)
            {
                Console.WriteLine("No se aceptan numeros negativos, ingrese un numero valido");
                Ingresar();
            }
            return numero;
        }
    }
}
