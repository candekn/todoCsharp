using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado miCuadrado = new Cuadrado();
            double lado = 0.0;
            eti1:
            Console.WriteLine("Ingrese lado del cuadrado: ");
            string ladotxt = Console.ReadLine();
            if(double.TryParse(ladotxt, out lado))
            {
                miCuadrado.Lado = lado;
                Console.WriteLine("El perimetro es: ",+miCuadrado.CalcularPerimetro());
                Console.WriteLine("El lado es: ", +miCuadrado.CalcularSuperficie());
            }
            else
            {
                Console.WriteLine("Escriba un numero valido!");
                goto eti1;
            }
        }
    }
}
