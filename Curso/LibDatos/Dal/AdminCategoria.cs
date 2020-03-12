using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibDatos.Entidades;
using System.Data.SqlClient;
using LibDatos.DB;

namespace LibDatos.Dal //DAL = Data Access Layer
{
    public static class AdminCategoria
    {
        public static DataTable TraerTodos()
        {
            string consultaSQL = "sp_CategoriaTraerTodos"; //query o nombre de sp
            
            //1 adapter 1 query. Se pasa la consulta, la conexion.
            //Y devuelve el resultado
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL,AdminDB.conexion());
            
            //Por defecto, la consulta la toma como una query normal. 
            //Entonces hay que decirle al adaptador, 
            //que lo que pasamos anteriormente es un stored procedure
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            
            //El dataSet q vamos a usar, el nombre que queremos ponerle a la 
            //tabla en memoria, puede llamarse igual o diferente a la tabla posta
             adapter.Fill(ds, "Category"); 
             //adater.Fill: conecta a la db, ejecuta el sp, llena
            //el datatable y se desconecta

            //Devuelve la tabla que esta guardada en el dataSet, entre corchetes
            //Le decimos el nombre de la tabla a retornar
            return ds.Tables["Category"];
        }

        public static DataSet TraerTodosDataSet()
        {
            string consultaSQL = "sp_CategoriaTraerTodos"; //query o nombre de sp

            //1 adapter 1 query. Se pasa la consulta, la conexion.
            //Y devuelve el resultado
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.conexion());

            //Por defecto, la consulta la toma como una query normal. 
            //Entonces hay que decirle al adaptador, 
            //que lo que pasamos anteriormente es un stored procedure
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            //El dataSet q vamos a usar, el nombre que queremos ponerle a la 
            //tabla en memoria, puede llamarse igual o diferente a la tabla posta
            adapter.Fill(ds, "Category");
            //adater.Fill: conecta a la db, ejecuta el sp, llena
            //el datatable y se desconecta

            //En este caso devuelve el dataSet completo, con todas las tablas
            //que tiene dentro
            return ds;
        }

        //TODO Falta completar Insertar
        /// <summary>
        /// Metodo para insertar un registro en la tabla Categoria,
        /// de la base de datos dbCurso
        /// </summary>
        /// <param name="categoria">Requiere de un objeto Categoria</param>
        /// <returns></returns>
        public static int Insertar(Categoria categoria)
        {
            string sql = "sp_CategoriaInsertar";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = categoria.Nombre;
            comando.CommandType = CommandType.StoredProcedure;
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }
        public static int Actualizar(Categoria categoria)
        {
            string sql = "sp_CategoriaModificar";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = categoria.Nombre;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = categoria.Id;
            comando.CommandType = CommandType.StoredProcedure;
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas; 
        }
        public static int Eliminar(int idCategoria)
        {
            string sql = "sp_CategoriaEliminar";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = idCategoria;
            comando.CommandType = CommandType.StoredProcedure;
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }
    }
}
