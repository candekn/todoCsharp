using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        public string Nombre { get {return this.nombre; } set {this.nombre=value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre.ToLower();
            this.apellido = apellido.ToUpper();
            this.edad = edad;
        }
    }
}
