using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDatosEF.EF;
using LibDatosEF.Entidades;

namespace LibDatosEF.Dal
{
    public static class AdminMedico
    {
        static ClinicaContext context = new ClinicaContext();

        /// <summary>
        /// Devuelve una lista de todos los medicos en la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Medico> traerTodosLosMedicos()
        {
            return (from med in context.Medicos select med).ToList();
        }
        /// <summary>
        /// Devuelve un medico en especifico, filtrado por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Medico traerMedico(int id)
        {
            return (from med in context.Medicos where med.Id == id select med).SingleOrDefault();
        }
        /// <summary>
        /// Agrega a la base de datos el medico ingresado por parametro.
        /// </summary>
        /// <param name="medico"></param>
        public static void insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            guardarCambios();
        }
        /// <summary>
        /// Modifica un medico por id, buscando al medico e igualando al objeto medico actualizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="medico"></param>
        public static void modificar(int id, Medico medico)
        {
            Medico medicoMod = context.Medicos.Find(id);
            medicoMod.Nombre = medico.Nombre;
            guardarCambios();
        }
        /// <summary>
        /// Elimina a un medico de la base de datos, buscandolo por ID
        /// </summary>
        /// <param name="id"></param>
        public static void eliminar(int id)
        {
            Medico medicoEliminar = traerMedico(id);
            context.Medicos.Remove(medicoEliminar);
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
