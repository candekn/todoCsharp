using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDatos.DB;
using LibDatos.Entidades;

namespace LibDatos.Dal
{
    public static class AdminProducto
    {
        #region "Metodos SELECT"
        public static DataTable TraerTodo()
        {
            string consulta = "Select Id,Nombre,CategoriaID,Proveedor FROM Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, AdminDB.conexion());
            DataSet ds = new DataSet();
            try
            {
                adaptador.Fill(ds, "Producto");
                return ds.Tables["Producto"];
            }
            catch
            {
                return null;
            }   
        }
        public static DataTable TraerTodo(string proveedor)
        {
            string consulta = "sp_ProductoTraerPorProveedor";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, AdminDB.conexion());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50).Value=proveedor;
            DataSet ds = new DataSet();
            try
            {
                adaptador.Fill(ds, "Producto por Proveedor");
                return ds.Tables["Producto por Proveedor"];
            }
            catch
            {
                return null;
            }
        }
        public static DataTable TraerTodo(int categoriaID)
        {
            string consulta = "sp_ProductoTraerPorCategoria";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, AdminDB.conexion());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = categoriaID;
            DataSet ds = new DataSet();
            try
            {
                adaptador.Fill(ds, "Producto por Categoria");
                return ds.Tables["Producto por Categoria"];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region "Metodos ABM"
        public static int Insertar(Producto producto)
        {
            string sql = "INSERT INTO Producto(Nombre,CategoriaID,Proveedor)" +
                "VALUES (@nombre,@catID,@proveedor)";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = producto.Nombre;
            comando.Parameters.Add("@catID", SqlDbType.Int).Value = producto.CategoriaID;
            comando.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = producto.Proveedor;
            return comando.ExecuteNonQuery();
        }
        public static int Actualizar(Producto producto) {
            string sql = "UPDATE Producto SET Nombre = @nombre, " +
                "CategoriaID = @catid, Proveedor = @proveedor " +
                "WHERE Id = @id";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = producto.Nombre;
            comando.Parameters.Add("@catID", SqlDbType.Int).Value = producto.CategoriaID;
            comando.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = producto.Proveedor;
            comando.Parameters.Add("@id", SqlDbType.Int).Value = producto.Id;
            return comando.ExecuteNonQuery();
        }

        public static int Eliminar(int productoId)
        {
            string sql = "DELETE FROM Producto WHERE id=@idProducto";
            SqlCommand comando = new SqlCommand(sql, AdminDB.conexion());
            comando.Parameters.Add("@idProducto", SqlDbType.Int).Value=productoId;
            return comando.ExecuteNonQuery();
        }
        #endregion
    }
}
