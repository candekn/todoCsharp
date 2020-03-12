using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cliente:Persona
    {
        private string tipoContrato;
        private int ventasRealizadas;
        public string TipoContrato { get {return this.tipoContrato; } set {this.tipoContrato=value; } }
        public int VentasRealizadas {get { return this.ventasRealizadas; } set { this.ventasRealizadas = value; } }
        
        public Cliente(string nombre, string apellido, int dni, string tipoContrato, int ventasRealizadas) : base(nombre, apellido, dni)
        {
            this.tipoContrato = tipoContrato;
            this.ventasRealizadas = ventasRealizadas;
        }

        public string GenerarCodigo()
        {
            return (Nombre.Substring(0,3))+(Apellido.Substring(0,3))+"2019";
        }

        public int CalcularSueldo()
        {
            if (TipoContrato.ToUpper().Equals("COMUN"))
            {
                return 4500;
            }
            else if (TipoContrato.ToUpper().Equals("NORMAL"))
            {
                return 7500;
            }
            else
            {
                return 0;
            }
            //CalcularBono, cuyo bono será 80 si la  venta a realizada es mayor o igual a
            // 50 sino el valor del bono será 45.
        }
    
    }
}
