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
            Empleado e1 = new Empleado();
            Cliente c1 = new Cliente();
            e1.Nombre = "Empl";
            e1.Apellido = "E-Ado";
            e1.Clave = 1234;
            c1.Nombre = "Clii";
            c1.Apellido = "Ente";
            c1.Clave = 5678;
            e1.ObtenerDatosCompletos();
            c1.ObtenerDatosCompletos();

            Console.ReadKey();
            
        }
    }
}
