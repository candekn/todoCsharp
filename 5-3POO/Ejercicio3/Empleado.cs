using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Empleado:Persona
    {
        private int claveEmpleado;
        public override int Clave { get {return this.claveEmpleado; } set {this.claveEmpleado=value; } }
        public override void ObtenerDatosCompletos()
        {
            Console.WriteLine(Nombre + " " + Apellido + ". Clave: "+Clave +".\n");
        }
    }
}
