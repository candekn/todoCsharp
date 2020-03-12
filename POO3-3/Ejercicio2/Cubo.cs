using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cubo
    {
        private double lado;
        private double area;
        private double volumen;

        //2 metodos CalcularVolumen y CalcularArea
        public double Lado{ get{ return lado; } set { lado = value; } }
        public double Area { get { return area; } set { area = value; } }
        public double Volumen { get { return volumen; } set { volumen = value; } }

        public void CalcularVolumen()
        {
            this.volumen = Math.Pow(this.lado, 3);
        }
        public void CalcularArea()
        {
            this.area = ((Math.Pow(this.lado,2)) * 6);
        }


    }
}
