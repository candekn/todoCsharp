using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Suma:Operacion
    {

        public Suma(double n1, double n2):base(n1,n2)
        {

        }
        public void Operar()
        {
            Resultado = Numero1 + Numero2;
        }
        public string Imprimir()
        {
            return Resultado.ToString();
        }
    }
}
