using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Estudiante
    {
        //declarar atributos
        private string nombre;
        private string apellido;
        private int edad;

        //Constructor 
        public Estudiante()
        {
            this.nombre = "Juan";
            this.apellido = "Perez";
            this.edad = 32;
        }
        public Estudiante(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("Su nombre es "+this.nombre +". Su apellido es "+this.apellido +", y su edad es "+this.edad);
        }
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante();
            e1.Imprimir();
            Estudiante e2 = new Estudiante("Juan", "Gonzalez", 55);
            e2.Imprimir();
            Console.ReadKey();
        }
    }
}
