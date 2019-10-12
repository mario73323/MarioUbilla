using System;

namespace Ejercicio6
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
                controlespacios = 0;
                controlasteriscos = (alto * 2) - 3;
                for (int alt = 1; alt < alto; alt++)
                {
                    Console.Write("    ");
                    control = 0;
                    while (control < controlespacios)
                    {
                        Console.Write("  ");
                        control++;
                    }
                    controlespacios++;
                    control = 0;
                    while (control < controlasteriscos)
                    {
                        Console.Write("* ");
                        control++;
                    }
                    controlasteriscos = controlasteriscos - 2;
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
            Console.WriteLine("Ingrese la magnitud para el rombo");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero valido");
                numero = Ingresaralto();
            }
            if (!error)
            {
                Console.WriteLine("No se aceptan numeros negativos ni cero, ingrese numero valido");
                numero = Ingresaralto();
            }
            return numero;
        }
    }
}