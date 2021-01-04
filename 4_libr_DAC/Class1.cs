using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;
using System.Data.Common;
using System.Windows.Forms;

namespace DAC
{
    public class ClsDAC_Usuario
    {
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
      
        DataTable schemaTable = new DataTable();
        public List<ClsUsuario> lista()
        {
            List<ClsUsuario> x=new List<ClsUsuario>();

            return x;
        }
        public void insertar(ClsUsuario xobj )
        {
            cmd = new SqlCommand("[seguridad].[usuario_insert]", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario",xobj.Usuario );
            cmd.Parameters.AddWithValue("@clave", xobj.clave);
            cmd.Parameters.AddWithValue("@nombres", xobj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", xobj.Apellidos);
            cmd.Parameters.AddWithValue("@correo", xobj.Correo);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminar(ClsUsuario xobj)
        {

        }
        public int  Login(string user, string pasword)
        {

            
                SqlCommand command = new SqlCommand("Select id_usr,rol_usr,usr_nom,usr_pass   from Usuario    where    usr_nom = '" + user + "' and usr_pass = '" + pasword + "'", cn);

                cn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                cn.Close();
                int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {

              

                var s = ds.Tables[0].Rows[0]["rol_usr"].ToString();
                var f = ds.Tables[0].Rows[0]["usr_nom"].ToString();
                MessageBox.Show("rol: "+s +" user: "+f);

                int id_Rol = Int32.Parse(ds.Tables[0].Rows[0]["id_usr"].ToString());
                id_Rol = id_Rol - 1;
                return id_Rol;


            }
                return 0;
        }

        public DataTable search_product(string richTextBox1 , string _DataRow)
        {
            if(richTextBox1 != "")
            {
                cmd = new SqlCommand("Ayuda_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name_product", richTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                if(schemaTable.Rows.Count ==  0)
                {
                    cn.Close();
                    return null;

                }
                //DataTable schemaTable = loDataReader.GetSchemaTable();
                cn.Close();
                return schemaTable;

            }
            if (_DataRow != "") {
                cmd = new SqlCommand("Seleccionar_UnProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PROD_ID",  _DataRow);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                //DataTable schemaTable = loDataReader.GetSchemaTable();
                cn.Close();
                return schemaTable;

            }
            return null;
             


        }
        public void insert_product()
        {

        }
        public int update_producto(string objProducto)
        {
            cmd = new SqlCommand("update_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_product", objProducto);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return 1;

            }
            //DataTable schemaTable = loDataReader.GetSchemaTable();
            cn.Close();
            return 0;
        }
        public void delete_producto()
        {

        }
        public ClsUsuario validar_usuario(string xusuario, string xclave)
        {
            ClsUsuario x = new ClsUsuario();

            return x;
        }


    }
    public class clsDAProveedor
    {
        SqlConnection cnn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");
        #region METODO INSERTAR
        public string Insertar(clsProveedores Proveedor)
        {
            string rpta = "";
            try
            {   
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
                parRazon_Social.Value = Proveedor.Razon_social;
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
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region METODO EDITAR
        public string Editar(clsProveedores Proveedor)
        {
            string rpta = "";
            try
            {
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
                parRazon_Social.Value = Proveedor.Razon_social;
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
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            cnn.Close();
            return rpta;
        }
        #endregion
        #region METODO ELIMINAR
        public string Eliminar(clsProveedores Proveedor)
        {
            string rpta = "";
            try
            {
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
            catch (Exception ex)
            {
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
                MessageBox.Show("Excepcion en Mostrar proveedor: ", ex.Message);
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
        #region METODO BUSCAR NOMBRE
        public DataTable BuscarRazonSocial(clsProveedores Proveedor)
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
                MessageBox.Show("Excepcion en BuscarRazonSocial proveedor: ", ex.Message);
                dtResultado = null;
            }

            return dtResultado;
        }
        #endregion
        #region METODO BUSCAR DOCUMENTO
        public DataTable BuscarNum_Documento(clsProveedores Proveedor)
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
                MessageBox.Show("Excepcion en BuscarNum_Documento Proveedor: ", ex.Message);
                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion
    }
}
