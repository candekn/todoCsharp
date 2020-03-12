using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDatosEF.EF;
using LibDatosEF.Entidades;

namespace LibDatosEF.Dal
{
    class AdminPaciente
    {
        static ClinicaContext context = new ClinicaContext();

        /// <summary>
        /// Devuelve una lista de todos los pacientes en la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Paciente> traerTodosLosPacientes()
        {
            return (from pac in context.Pacientes select pac).ToList();
        }
        /// <summary>
        /// Devuelve un paciente en especifico, filtrado por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Paciente traerPaciente(int id)
        {
            return (from pac in context.Pacientes where pac.PacienteID == id select pac).SingleOrDefault();
        }
        /// <summary>
        /// Agrega a la base de datos el paciente ingresado por parametro.
        /// </summary>
        /// <param name="paciente"></param>
        public static void insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            guardarCambios();
        }
        /// <summary>
        /// Modifica un paciente por id, buscando al paciente e igualando al objeto paciente actualizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paciente"></param>
        public static void modificar(int id, Paciente paciente)
        {
            Paciente pacienteMod = context.Pacientes.Find(id);
            pacienteMod.Nombre = paciente.Nombre;
            guardarCambios();
        }
        /// <summary>
        /// Elimina a un paciente de la base de datos, buscandolo por ID
        /// </summary>
        /// <param name="id"></param>
        public static void eliminar(int id)
        {
            Paciente pacienteEliminar = traerPaciente(id);
            context.Pacientes.Remove(pacienteEliminar);
            guardarCambios();
        }
        /// <summary>
        /// Guarda los cambios hechos en la base de datos
        /// </summary>
        public static void guardarCambios()
        {
            context.SaveChanges();
        }
    }
}
