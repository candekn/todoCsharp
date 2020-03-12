using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private double sueldo;
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public double Sueldo { get { return this.sueldo; } set { this.sueldo = value; } }

        public Empleado(string nombre, string apellido, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
        }
    }
}
