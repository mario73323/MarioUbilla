using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una serie de numeros, se le indicara cual es el de mayor valor\n");
            int mayor, num1 = 0,cant=0;
            cant = Ingresarcantidad();
            num1 = Ingresar();
            mayor = num1;
            for (int i = 1; i < cant; i++)
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
        public static int Ingresarcantidad()
        {
            Console.WriteLine("¿Cuantos numeros desea comparar?");
            string can = Console.ReadLine();
            bool error = int.TryParse(can, out int cantidad);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero valido");
                cantidad=Ingresarcantidad();
            }
            if (!error)
            {
                Console.WriteLine("No se aceptan numeros negativos ni cero, ingrese un numero valido");
                cantidad = Ingresarcantidad();
            }
            return cantidad;
        }

    }

}