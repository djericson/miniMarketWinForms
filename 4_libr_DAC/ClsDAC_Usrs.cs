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
    public class ClsDAC_Usuarios
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

        public DataTable search_(string rch_tb)
        {
            return null;       
        }

        public void eliminar(ClsUsuario xobj)
        {

        }
        public string  Login(string user, string pasword)
        {
            SqlCommand command = new SqlCommand("Select id_usr,rol_usr,usr_nom,usr_pass   from Usuario    where    usr_nom = '" + user + "' and usr_pass = '" + pasword + "'", cn);

            cn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            cn.Close();
            int count = ds.Tables[0].Rows.Count;

            if (count == 1) {
                var Rol_User = ds.Tables[0].Rows[0]["rol_usr"].ToString();
                //var f = ds.Tables[0].Rows[0]["usr_nom"].ToString();
                //int id_Rol = Int32.Parse(ds.Tables[0].Rows[0]["id_usr"].ToString());
                //id_Rol = id_Rol - 1;
                return Rol_User;
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
