using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se creara una piramide de asteriscos");
            Proceso();
            Console.ReadKey();
        }
        public static void Proceso()
        {
            int alto = Ingresaralto(), controlespacios = 0, controlasteriscos = 0, control = 0;
            controlespacios = alto;
            controlasteriscos = 1;
            if (alto > 0)
            {
                for (int alt = 1; alt <= alto; alt++)
                {
                    control = 0;
                    while (control < controlespacios)
                    {
                        Console.Write("  ");
                        control++;
                    }
                    controlespacios--;
                    control = 0;
                    while (control < controlasteriscos)
                    {
                        Console.Write("* ");
                        control++;
                    }
                    controlasteriscos = controlasteriscos + 2;
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("no se ha podido elaborar la piramide ingrese un numero valido");
                Proceso();
            }
        }
        public static int Ingresaralto()
        {
            Console.WriteLine("Ingrese el numero de filas para la piramide");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero valido");
                numero = Ingresaralto();
            }
            if (numero<=0)
            {
                Console.WriteLine("No se aceptan numeros negativos ni cero ingrese un numero valido");
                numero = Ingresaralto();
            }
            return numero;

        }
    }
}
