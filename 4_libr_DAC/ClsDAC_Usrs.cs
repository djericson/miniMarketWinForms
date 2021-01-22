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
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net;Initial Catalog=miniMarket;User ID=adm_ea;Password=$Developer");
        SqlCommand cmd;
        
        public List<ClsUsuario> lista()
        {
            List<ClsUsuario> x=new List<ClsUsuario>();

            return x;
        }
        public void insUsr(ClsUsuario objClsUsr )
        {
            cmd = new SqlCommand("[AccesosRolesUsrs_Usr_ins]", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@usr_nick", objClsUsr.nick_usr );
            cmd.Parameters.AddWithValue("@usr_pass", objClsUsr.pass_usr);
            cmd.Parameters.AddWithValue("@usr_tipo_doc", objClsUsr.tipoDoc_usr);
            cmd.Parameters.AddWithValue("@usr_numDoc", objClsUsr.nroDoc_usr);
            cmd.Parameters.AddWithValue("@usr_ruc", objClsUsr.ruc_usr);
            cmd.Parameters.AddWithValue("@usr_nom", objClsUsr.nom_usr);
            cmd.Parameters.AddWithValue("@usr_ap_pater", objClsUsr.apePat_usr);
            cmd.Parameters.AddWithValue("@usr_ap_mater", objClsUsr.apeMat_usr);
            cmd.Parameters.AddWithValue("@usr_email", objClsUsr.email_usr);
            cmd.Parameters.AddWithValue("@usr_dir", objClsUsr.dir_usr);
            cmd.Parameters.AddWithValue("@usr_tlf", objClsUsr.tlf_usr);

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
