using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO1
{
    class Estudiante
    {
        private int legajo;
        private string nombre;
        private string apellido;
        public int Legajo { get {return this.legajo; } set {this.legajo=value; } }
        public string Nombre { get {return this.nombre; } set {this.nombre=value; } }
        public string Apellido { get { return this.apellido.ToUpper(); } set { this.apellido = value; } }

        //Otras propiedades
        public string Concat { get {return (String.Concat(this.nombre," ",this.apellido)); }}
        public int LargoApellido { get { return (this.apellido.Length);} }
   

        public Estudiante(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido; 
        }

        public string LargoDelApellido()
        {
            if (this.apellido.Length > 10)
            {
                return "apellido largo";
            }
            else
            {
                return "apellido corto";
            }
        }
        public string Imprimir()
        {
            return "Su nombre es " + Nombre + " y su legajo es: " + Legajo
                + ".\nSu apellido en mayúsculas es: " + Apellido
                + ".\nSu nombre y apellido concatenado es: " + Concat
                + ".\nEl largo del apellido es " + LargoApellido
                + ", por lo que es un " + this.LargoDelApellido() + ".\n\n";

        }

    }
}
