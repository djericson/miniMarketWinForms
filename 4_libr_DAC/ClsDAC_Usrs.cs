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
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=wilber;Password=$W012345");
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

        public DataTable getUsrCliente(string nombre)
        {
            DataTable schemaTable = new DataTable();
            SqlDataReader loDataReader;
            cmd = new SqlCommand("buscar_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr_nom", nombre);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            if (schemaTable.Rows.Count == 0)
            {
                cn.Close();
                return null;
            }

            cn.Close();

            return schemaTable;

        }



    }
    
}
