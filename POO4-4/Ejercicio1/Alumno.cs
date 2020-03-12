using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Alumno
    {
        private int edad;
        private string nombre;
        private string apellido;
        private int legajo;
        private int cuota;
        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Cuota { get { return this.cuota; } set { this.cuota = value; } }
        //constructor por defecto con edad19, 
        //javier perez legajo 2109 cuota2896
        //segundo constructor con parametros
        public Alumno()
        {
            this.edad = 19;
            this.nombre = "Javier";
            this.apellido = "Perez";
            this.legajo = 2109;
            this.cuota = 2896;
        }
        public Alumno(int edad, string nombre, string apellido, int legajo, int cuota)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.cuota = cuota;
        }

        //metodo MostrarEdad, que diga si es mayor o menor de edad

        public string MostrarEdad()
        {
            if (this.edad >= 18)
            {
                return "mayor de edad";
            }
            else
            {
                return "menor de edad";
            }
        }
        //Mostrar cuota: mayor a cero y menor a 5000: Accesible
        //5000-10000: Cara
        //sino muy cara
        public string MostrarCuota()
        {
            if (this.cuota > 0 && this.cuota < 5000)
            {
                return "accesible";
            }
            else if (this.cuota >= 5000 && this.cuota < 10000)
            {
                return "cara";
            }
            else if (this.cuota >= 10000)
            {
                return "muy cara";
            }
            else
            {
                return "un error";
            }
        }

        //Imprimir: El alumno se llama y su apellido es y su eda es por lo 
        //tanto es (mayor/menor) y la cuota que paga es (mostrarCuota)

        public string Imprimir()
        {
            return "Le alumnx se llama " + this.nombre + ", su apellido es " + this.apellido
                + " y su edad es " + this.edad + ", por lo tanto es " + this.MostrarEdad()
                + ", y la cuota que paga es " + this.MostrarCuota() +".";
        }

    }
}
