using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Estudiante:Persona
    {
        private int legajo;
        private string nombreMaterias;
        private int fechaIngreso;

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string NombreMaterias { get { return this.nombreMaterias; } set { this.nombreMaterias = value; } }
        public int FechaIngreso  { get { return this.fechaIngreso; } set { this.fechaIngreso = value; } }
        public Estudiante(string nombre, string apellido, long dni, int legajo, 
            string nombreMaterias, int fechaIngreso)
            :base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.nombreMaterias = nombreMaterias;
            this.fechaIngreso = fechaIngreso;
        }

        //Override para sobreescribir el metodo de la clase padre
        public override void Imprimir()
        {
            Console.WriteLine("El estudiante se llama " + Nombre + ", su apellido es " + Apellido
                + " y su dni es " + Dni + ".\nSu legajo es " + Legajo + ", cursa la materia " + NombreMaterias
                + ". Y su fecha de ingreso es " + FechaIngreso + ".\n\n");
        }
    }
}
