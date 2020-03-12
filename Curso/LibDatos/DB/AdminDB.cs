using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatos.DB
{
    //internal: Su visibilidad es a nivel de componente (assembly, dll)
    //static: Todos sus miembros deben ser estaticos. Sirve para crear una sola vez una 
    //clase y todos usen esa misma "instanciacion" 
    internal static class AdminDB
    {
        internal static SqlConnection conexion()
        {
            //El @ es por el \, cuando ponemos @, c# entiende que es una cadena de conexion
            string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbCurso;Integrated Security=True";
            SqlConnection objConexion = new SqlConnection(cadena);
            objConexion.Open();
            return objConexion;
        }
    }
}
