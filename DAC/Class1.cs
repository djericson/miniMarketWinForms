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
    public class clsDAUsario
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Pachacamac;Integrated Security=True");
        SqlCommand cmd;
        public List<clsUsuario> lista()
        {
            List<clsUsuario> x=new List<clsUsuario>();

            return x;
        }
        public void insertar(clsUsuario xobj )
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[seguridad].[usuario_insert]";
            cmd.Parameters.AddWithValue("@usuario",xobj.Usuario );
            cmd.Parameters.AddWithValue("@clave", xobj.clave);
            cmd.Parameters.AddWithValue("@nombres", xobj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", xobj.Apellidos);
            cmd.Parameters.AddWithValue("@correo", xobj.Correo);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminar(clsUsuario xobj)
        {
            

        }
        public clsUsuario validar_usuario(string xusuario, string xclave)
        {
            clsUsuario x = new clsUsuario();

            return x;
        }


    }
    public class clsDAAplicaciones
    { }

}
