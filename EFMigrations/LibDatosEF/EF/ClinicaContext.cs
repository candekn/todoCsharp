using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;//entityframework

namespace LibDatosEF.EF
{
    public class ClinicaContext: DbContext
    {
        public ClinicaContext() : base("KeyClinicaDB") { }

        public DbSet<Entidades.Medico> Medicos { get; set; }

        public DbSet<Entidades.Paciente> Pacientes { get; set; }
    }
}
