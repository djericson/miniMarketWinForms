using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace DAC
{
    public class ClsDAC_Proveedores
    {
        SqlConnection cnn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");

        #region METODO INSERTAR
        public string Insertar(ClsProveedor Proveedor)
        {
            string rpta = "";
            try {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "insertar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdproveedor = new SqlParameter();
                parIdproveedor.ParameterName = "@id_proveedor";
                parIdproveedor.SqlDbType = SqlDbType.Int;
                parIdproveedor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdproveedor);

                SqlParameter parRazon_Social = new SqlParameter();
                parRazon_Social.ParameterName = "@razon_social";
                parRazon_Social.SqlDbType = SqlDbType.VarChar;
                parRazon_Social.Size = 150;
                parRazon_Social.Value = Proveedor.Id_usr;
                cmd.Parameters.Add(parRazon_Social);

                SqlParameter parSectorComercial = new SqlParameter();
                parSectorComercial.ParameterName = "@categoria";
                parSectorComercial.SqlDbType = SqlDbType.VarChar;
                parSectorComercial.Size = 50;
                parSectorComercial.Value = Proveedor.Categoria;
                cmd.Parameters.Add(parSectorComercial);

                SqlParameter parTipoDocumento = new SqlParameter();
                parTipoDocumento.ParameterName = "@tipo_documento";
                parTipoDocumento.SqlDbType = SqlDbType.VarChar;
                parTipoDocumento.Size = 20;
                parTipoDocumento.Value = Proveedor.Tipo_documento;
                cmd.Parameters.Add(parTipoDocumento);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 11;
                parNumDocumento.Value = Proveedor.Num_documento;
                cmd.Parameters.Add(parNumDocumento);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 100;
                parDireccion.Value = Proveedor.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 9;
                parTelefono.Value = Proveedor.Telefono;
                cmd.Parameters.Add(parTelefono);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Proveedor.Email;
                cmd.Parameters.Add(parEmail);

                SqlParameter parUrl = new SqlParameter();
                parUrl.ParameterName = "@pagina_web";
                parUrl.SqlDbType = SqlDbType.VarChar;
                parUrl.Size = 100;
                parUrl.Value = Proveedor.Pagina_web;
                cmd.Parameters.Add(parUrl);
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region METODO EDITAR
        public string Editar(ClsProveedor Proveedor)
        {
            string rpta = "";
            try {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "editar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdproveedor = new SqlParameter();
                parIdproveedor.ParameterName = "@id_proveedor";
                parIdproveedor.SqlDbType = SqlDbType.Int;
                parIdproveedor.Value = Proveedor.Id_proveedor;
                cmd.Parameters.Add(parIdproveedor);

                SqlParameter parRazon_Social = new SqlParameter();
                parRazon_Social.ParameterName = "@razon_social";
                parRazon_Social.SqlDbType = SqlDbType.VarChar;
                parRazon_Social.Size = 150;
                parRazon_Social.Value = Proveedor.Id_usr;
                cmd.Parameters.Add(parRazon_Social);

                SqlParameter parSectorComercial = new SqlParameter();
                parSectorComercial.ParameterName = "@categoria";
                parSectorComercial.SqlDbType = SqlDbType.VarChar;
                parSectorComercial.Size = 50;
                parSectorComercial.Value = Proveedor.Categoria;
                cmd.Parameters.Add(parSectorComercial);

                SqlParameter parTipoDocumento = new SqlParameter();
                parTipoDocumento.ParameterName = "@tipo_documento";
                parTipoDocumento.SqlDbType = SqlDbType.VarChar;
                parTipoDocumento.Size = 20;
                parTipoDocumento.Value = Proveedor.Tipo_documento;
                cmd.Parameters.Add(parTipoDocumento);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 11;
                parNumDocumento.Value = Proveedor.Num_documento;
                cmd.Parameters.Add(parNumDocumento);

                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 100;
                parDireccion.Value = Proveedor.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 9;
                parTelefono.Value = Proveedor.Telefono;
                cmd.Parameters.Add(parTelefono);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Proveedor.Email;
                cmd.Parameters.Add(parEmail);

                SqlParameter parUrl = new SqlParameter();
                parUrl.ParameterName = "@pagina_web";
                parUrl.SqlDbType = SqlDbType.VarChar;
                parUrl.Size = 100;
                parUrl.Value = Proveedor.Pagina_web;
                cmd.Parameters.Add(parUrl);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
            }
            catch (Exception ex) {
                Console.WriteLine("Excepcion en Editar Proveedor: ", ex.Message);
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region METODO ELIMINAR
        public string Eliminar(ClsProveedor Proveedor)
        {
            string rpta = "";
            try {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "eliminar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdproveedor = new SqlParameter();
                parIdproveedor.ParameterName = "@id_proveedor";
                parIdproveedor.SqlDbType = SqlDbType.Int;
                parIdproveedor.Value = Proveedor.Id_proveedor;
                cmd.Parameters.Add(parIdproveedor);

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";
            }
            catch (Exception ex) {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region METODO MOSTRAR
        public DataTable Mostrar()
        {

            DataTable dtResultado = new DataTable("proveedor");
            try {                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "mostrar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
                dtAdapter.Fill(dtResultado);
            }
            catch (Exception ex) {
                Console.WriteLine("Excepcion en Mostrar proveedor: ", ex.Message);
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
        #region METODO BUSCAR NOMBRE
        public DataTable BuscarRazonSocial(ClsProveedor Proveedor)
        {
            DataTable dtResultado = new DataTable("proveedor");
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "buscar_proveedor_razon";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = Proveedor.Texto_buscar;
                cmd.Parameters.Add(parTextoBuscar);

                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex) {
                Console.WriteLine("Excepcion en BuscarRazonSocial proveedor: ", ex.Message);
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
        #region METODO BUSCAR DOCUMENTO
        public DataTable BuscarNum_Documento(ClsProveedor Proveedor)
        {
            DataTable dtResultado = new DataTable("proveedor");
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "buscar_proveedor_num";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 11;
                parTextoBuscar.Value = Proveedor.Texto_buscar;
                cmd.Parameters.Add(parTextoBuscar);

                SqlDataAdapter datAdapter = new SqlDataAdapter(cmd);
                datAdapter.Fill(dtResultado);
            }
            catch (Exception ex) {
                Console.WriteLine("Excepcion en BuscarNum_Documento Proveedor: " + ex.Message);
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
    }
}
