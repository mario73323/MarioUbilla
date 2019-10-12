using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se calculara el sueldo del empleado a partir de las horas trabajadas \n" +
                "cada hora trabajada (hasta 35) tiene un valor de $15 \n " +
                "si supera las 35 horas las demas seran consideradas extra con un valor de $22 \n ");
            int horas = 0, sueldo = 0, extra = 0, total = 0;
            horas = Ingresarhoras();
            if (horas <= 35)
            {
                sueldo = horas * 15;
            }
            else
            {
                sueldo = 35 * 15;
                extra = (horas - 35) * 22;
            }
            total = sueldo + extra;
            Console.WriteLine("Sus horas trabajadas son {0} \nSu sueldo es {1}\n" +
                "Su pago por horas extras es {2}\nSu sueldo total a recibir es {3}", horas, sueldo, extra, total);
            Console.ReadKey();
        }
        public static int Ingresarhoras()
        {
            Console.WriteLine("Ingrese horas trabajadas");
            string num = Console.ReadLine();
            bool error = int.TryParse(num, out int numero);
            if (!error)
            {
                Console.WriteLine("Ingrese un numero de horas valido");
                numero = Ingresarhoras();
            }
            if (numero<0)
            {
                Console.WriteLine("No puede ingresar horas negativas, ingrese horas trabajadas validas");
                numero = Ingresarhoras();
            }
            return numero;
        }
    }
}
