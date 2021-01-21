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
    public class ClsDAC_Usuarios
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        
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
 


    }
    
}
