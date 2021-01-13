using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;


namespace DAC
{
    public class ClsDAC_Categoria
    {
        SqlConnection cnn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");
        #region ......................METODO INSERTAR
        public string Insertar(ClsCategoria Categoria)
        {
            string rpta = "";
            try
            {
                cnn.Open();
              
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "insertar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcategoria";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Categoria.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 256;
                parDescripcion.Value = Categoria.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region........................... METODO EDITAR
        public string Editar(ClsCategoria Categoria)
        {
            string rpta = "";
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "editar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcategoria";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Categoria.IdCategoria;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Categoria.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 256;
                parDescripcion.Value = Categoria.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region .............................METODO ELIMINAR
        public string Eliminar(ClsCategoria Categoria)
        {
            string rpta = "";
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "eliminar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcategoria";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Categoria.IdCategoria;
                cmd.Parameters.Add(parId);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region ..............................METODO MOSTRAR
        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("categoria");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "mostrar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
                dtAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
        #region ........................METODO BUSCAR NOMBRE DE LA CATEGORIA
        public DataTable BuscarNombre(ClsCategoria categoria)
        {
            DataTable dtResultado = new DataTable("categoria");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "buscar_categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = categoria.TextoBuscar;
                cmd.Parameters.Add(parTextoBuscar);

                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }
        #endregion
    }
}
