using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Cliente:Persona
    {
        private int claveCliente;
        public override int Clave { get {return this.claveCliente; } set {this.claveCliente=value; } }
        public override void ObtenerDatosCompletos()
        {
            Console.WriteLine(Nombre + " " + Apellido + " Codigo cliente: " + Clave + ".\n");
        }
    }
}
