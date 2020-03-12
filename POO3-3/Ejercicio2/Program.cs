using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        //Generar clase cubo 3 atributos(lado area volumen)
        //No constructores
        //2 metodos CalcularVolumen y CalcularArea
        //Objeto micubo
        //Cargar datos en el main e imprimir resultados de los metodos
        static void Main(string[] args)
        {
            Cubo miCubito = new Cubo();
            
            double lado = 0.0;
        eti1:
            Console.WriteLine("Ingrese el lado del cubo: ");
            if (double.TryParse(Console.ReadLine(), out lado))
            {
                miCubito.Lado = lado;
                miCubito.CalcularArea();
                miCubito.CalcularVolumen();
                Console.WriteLine("El area es: " + miCubito.Area);
                Console.WriteLine("El volumen es: " + miCubito.Volumen);
            }
            else
            {
                Console.WriteLine("Ingrese un lado numero valido");
                goto eti1;
            }
            
            Console.ReadKey();
        }
    }
}
