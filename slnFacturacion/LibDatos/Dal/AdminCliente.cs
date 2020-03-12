using LibDatos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.Dal
{
    public static class AdminCliente
    {
        /// <summary>
        /// Retorna un DataTable con todos los registros de la tabla Clientes
        /// </summary>
        /// <returns></returns>
        public static DataTable TraerTodos()
        {
            string consulta = "SELECT id, nombre, apellido, ciudad FROM Cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,AdminDB.Conexion());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Cliente");
            return ds.Tables["Cliente"];
        }
        public static DataTable TraerTodos(string ciudad)
        {
            string consulta = "SELECT id, nombre, apellido, ciudad FROM Cliente WHERE ciudad=@ciudad";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.Conexion());
            adapter.SelectCommand.Parameters.Add("@ciudad", SqlDbType.VarChar, 50).Value = ciudad;
            string nombreTabla = "Clientes de la ciudad: " + ciudad;

            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, nombreTabla);
                return ds.Tables[nombreTabla];
            }
            catch
            {
                return null;
            }
        }
        public static DataTable TraerCiudades()
        {
            string consulta = "SELECT DISTINCT(Ciudad) FROM Cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, AdminDB.Conexion());
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Ciudad");
            return ds.Tables["Ciudad"];
        }
    }
}
