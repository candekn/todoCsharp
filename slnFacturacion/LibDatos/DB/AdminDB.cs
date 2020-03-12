using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.DB
{
    internal static class AdminDB
    {
        internal static SqlConnection Conexion()
        {
            string conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbFacturacion;Integrated Security=True";
            SqlConnection sqlConexion = new SqlConnection(conexion);
            sqlConexion.Open();
            return sqlConexion;
        }
    }
}
