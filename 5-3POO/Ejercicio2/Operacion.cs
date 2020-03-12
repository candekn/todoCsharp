using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Operacion
    {
        private double numero1;
        private double numero2;
        private double resultado;
        public double Numero1 { get {return this.numero1; } set {this.numero1=value; } }
        public double Numero2 { get { return this.numero2; } set { this.numero2 = value; } }
        public double Resultado { get { return this.resultado; } set { this.resultado = value; } }

        public Operacion(double numero1,double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }
    }
}
