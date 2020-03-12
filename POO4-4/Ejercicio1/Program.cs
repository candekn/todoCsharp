using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase alumno nombre apellido legajo edad cuota
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno(23, "Elsa", "Pallo", 22789, 12812);
            Console.WriteLine(a1.Imprimir()+"\n");
            Console.WriteLine(a2.Imprimir());

            Console.ReadKey();
        }
    }
}
