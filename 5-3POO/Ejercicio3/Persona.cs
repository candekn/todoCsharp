using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    abstract class Persona
    {
        private string nombre;
        private string apellido;
        public string Nombre { get {return this.nombre; } set {this.nombre=value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public abstract int Clave
        {
            get;set;
        }
        public abstract void ObtenerDatosCompletos();
    }
}
