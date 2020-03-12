using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatosEF.Entidades
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
    }
}
