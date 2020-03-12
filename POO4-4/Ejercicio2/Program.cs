using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Adam";
            p1.Apellido = "West";
            p1.Edad = 52;
            p1.Legajo = 116907;
            p1.MostrarMensaje();

            Console.ReadKey();
        }
    }
}
