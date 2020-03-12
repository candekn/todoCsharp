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
            Persona p1 = new Persona("Carla", "Persona", 22567567);
            Estudiante e1 = new Estudiante("Jorge", "Estudiante", 41234234, 1969, "Contabilidad", 2016);
            p1.Imprimir();
            e1.Imprimir();
            Console.ReadKey();
        }
    }
}
