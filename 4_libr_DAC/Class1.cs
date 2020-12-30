using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;
using System.Data.Common;
 

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

        public DataTable search_product(string richTextBox1 , string _DataRow)
        {
            if(richTextBox1 != "")
            {
                cmd = new SqlCommand("Ayuda_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_producto", richTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
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
        public ClsUsuario validar_usuario(string xusuario, string xclave)
        {
            ClsUsuario x = new ClsUsuario();

            return x;
        }


    }

}
