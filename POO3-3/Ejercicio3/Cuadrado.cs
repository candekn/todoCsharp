using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Cuadrado
    {
        //Atributos necesarios
        //3 metodos: Inicializar, CalcularPerimetro, CalcularSuperficie
        private double lado;
        public double Lado { get { return lado; } set { lado = value; } }
        
        public void Inicializar(double lado)
        {
            this.lado = lado;
        }

        public double CalcularPerimetro()
        {
            return (this.lado * 4);
        }

        public double CalcularSuperficie()
        {
            return (this.lado*this.lado);
        }
    }
}
