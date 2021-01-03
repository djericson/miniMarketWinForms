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
            if (_DataRow != "")
            {
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

}
