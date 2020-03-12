using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private long dni;
        public string Nombre { get {return this.nombre; } set {this.nombre=value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public long Dni { get { return this.dni; } set { this.dni = value; } }

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        //Tiene que ser un metodo virtual para poder sobreescribirlo en la claseHija
        public virtual void Imprimir()
        {
            Console.WriteLine("El nombre de la persona es: " + Nombre
                + ". Su apellido es: " + Apellido + "\nY su DNI es: " + Dni +".\n\n");
        }
    }
}
