using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("se calculara el total de la compra realizada");
            Console.WriteLine("Para terminar la factura ingrese un cero (0) dentro de la cantidad de compra");
            int total = 0, parcial = 0, cant = 0, prec = 0;
            do
            {
                cant = Ingresarcantidad();
                if (cant != 0)
                {
                    prec = Ingresarprecio();
                }
                parcial = cant * prec;
                total = total + parcial;
            }
            while (cant != 0);
            Console.WriteLine("El valor total a pagar es {0}", total);
            Console.ReadKey();
        }
        public static int Ingresarcantidad()
        {
            Console.WriteLine("Ingrese la cantidad del producto");
            string Cantidad = Console.ReadLine();
            bool error = int.TryParse(Cantidad, out int cantidad);
            if (!error)
            {
                Console.WriteLine("Ingrese una cantidad valida");
                cantidad = Ingresarcantidad();
            }
            if (cantidad<0)
            {
                Console.WriteLine("No puede ingresar una cantidad negativa, ingrese una cantidad valida");
                cantidad = Ingresarcantidad();
            }
            return cantidad;
        }
        public static int Ingresarprecio()
        {
            Console.WriteLine("Ingrese el precio del producto");
            string Precio = Console.ReadLine();
            bool error = int.TryParse(Precio, out int precio);
            if (!error)
            {
                Console.WriteLine("Ingrese un precio valido");
                precio = Ingresarprecio();
            }
            if (precio < 0)
            {
                Console.WriteLine("No puede ingresar una cantidad negativa, ingrese un precio valido");
                precio = Ingresarprecio();
            }
            return precio;
        }
    }
}