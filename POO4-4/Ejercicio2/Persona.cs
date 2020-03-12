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
        private int legajo;
        private int edad;

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value.ToLower(); } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value.ToUpper(); } }

        public void MostrarMensaje()
        {
            Console.WriteLine("Le srx " + Apellido + ", cuyo nombre es " + Nombre + 
                ". Su número de legajo es " + Legajo + " y tiene " + Edad + " años."); ;
        }

    }
}
