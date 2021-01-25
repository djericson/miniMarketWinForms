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
        SqlConnection objConn;
        SqlCommand obj_cmd;
        SqlDataReader obj_dr;
        List<ClsUsuario> lst_objUsrs;

        public ClsDAC_Usuarios()
        {
            objConn = new SqlConnection();
            objConn.ConnectionString =
            //"Data Source = srv-bd-sql-server.database.windows.net; Initial Catalog = miniMarket; User ID = adm_ea; Password =$Developer";
            "Data Source = sql-srv2.database.windows.net; Initial Catalog = miniMarket; User ID = ea_Adm; Password =$Developer";
            obj_cmd = new SqlCommand();
            obj_cmd.Connection = objConn;
            obj_cmd.CommandType = CommandType.StoredProcedure;

        }
        public List<ClsUsuario> getListUsrs()
        {
            lst_objUsrs = new List<ClsUsuario>();
            try {
                objConn.Close();
                obj_cmd.CommandText = "AccesosRolesUsrs_Usr_getUsrs";
                obj_cmd.Parameters.Clear();
                objConn.Open();
                obj_dr = obj_cmd.ExecuteReader();

                while (obj_dr.Read()) {
                    ClsUsuario tmp_objUsr = new ClsUsuario();
                    tmp_objUsr.id_usr = int.Parse(obj_dr[0].ToString());
                    tmp_objUsr.nick_usr = obj_dr[1].ToString();
                    tmp_objUsr.pass_usr = obj_dr[2].ToString();
                    tmp_objUsr.tipoDoc_usr = int.Parse(obj_dr[3].ToString());
                    tmp_objUsr.nroDoc_usr = obj_dr[4] == null ? int.Parse(obj_dr[4].ToString()) : 0;
                    tmp_objUsr.ruc_usr = obj_dr[5] == null ? int.Parse(obj_dr[5].ToString()) : 0;
                    tmp_objUsr.nom_usr = obj_dr[6].ToString();
                    tmp_objUsr.apePat_usr = obj_dr[7].ToString();
                    tmp_objUsr.apeMat_usr = obj_dr[8].ToString();
                    tmp_objUsr.email_usr = obj_dr[9].ToString();
                    tmp_objUsr.dir_usr = obj_dr[10].ToString();
                    tmp_objUsr.tlf_usr = obj_dr[11] == null ? int.Parse(obj_dr[11].ToString()) : 0;

                    lst_objUsrs.Add(tmp_objUsr);
                }
                return lst_objUsrs;
            }
            catch (SqlException sqlex) {
                Console.WriteLine(sqlex.Message);
                //return sqlex.Message, "Aviso", );
                return null;
            }
            finally { objConn.Close(); }
        }

        public void insUsr(ClsUsuario objClsUsr)
        {
            try {
                obj_cmd = new SqlCommand("[AccesosRolesUsrs_Usr_ins]", objConn);
                obj_cmd.CommandType = CommandType.StoredProcedure;
                obj_cmd.Parameters.Clear();

                obj_cmd.Parameters.AddWithValue("@usr_nick", objClsUsr.nick_usr);
                obj_cmd.Parameters.AddWithValue("@usr_pass", objClsUsr.pass_usr);
                obj_cmd.Parameters.AddWithValue("@usr_tipo_doc", objClsUsr.tipoDoc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_numDoc", objClsUsr.nroDoc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ruc", objClsUsr.ruc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_nom", objClsUsr.nom_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ap_pater", objClsUsr.apePat_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ap_mater", objClsUsr.apeMat_usr);
                obj_cmd.Parameters.AddWithValue("@usr_email", objClsUsr.email_usr);
                obj_cmd.Parameters.AddWithValue("@usr_tlf", objClsUsr.tlf_usr);
                obj_cmd.Parameters.AddWithValue("@usr_dir", objClsUsr.dir_usr);

                objConn.Open();
                obj_cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex) {
                Console.WriteLine(sqlex.Message);
                //return sqlex.Message, "Aviso", );
            }
            finally { objConn.Close(); }

        }

        public void updUsr(ClsUsuario objClsUsr)
        {
            try {
                obj_cmd = new SqlCommand("[AccesosRolesUsrs_Usr_upd]", objConn);
                obj_cmd.CommandType = CommandType.StoredProcedure;
                obj_cmd.Parameters.Clear();
                obj_cmd.Parameters.AddWithValue("@id_usr", objClsUsr.id_usr);
                obj_cmd.Parameters.AddWithValue("@usr_nick", objClsUsr.nick_usr);
                obj_cmd.Parameters.AddWithValue("@usr_pass", objClsUsr.pass_usr);
                obj_cmd.Parameters.AddWithValue("@usr_tipo_doc", objClsUsr.tipoDoc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_numDoc", objClsUsr.nroDoc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ruc", objClsUsr.ruc_usr);
                obj_cmd.Parameters.AddWithValue("@usr_nom", objClsUsr.nom_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ap_pater", objClsUsr.apePat_usr);
                obj_cmd.Parameters.AddWithValue("@usr_ap_mater", objClsUsr.apeMat_usr);
                obj_cmd.Parameters.AddWithValue("@usr_email", objClsUsr.email_usr);
                obj_cmd.Parameters.AddWithValue("@usr_tlf", objClsUsr.tlf_usr);
                obj_cmd.Parameters.AddWithValue("@usr_dir", objClsUsr.dir_usr);

                objConn.Open();
                obj_cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex) {
                Console.WriteLine(sqlex.Message);
                //return sqlex.Message, "Aviso", );
            }
            finally { objConn.Close(); }
        }

        public void delUsr(int id_usr)
        {
            try {
                obj_cmd = new SqlCommand("[AccesosRolesUsrs_Usr_del]", objConn);
                obj_cmd.CommandType = CommandType.StoredProcedure;
                obj_cmd.Parameters.Clear();

                obj_cmd.Parameters.AddWithValue("@usr_id", id_usr);

                objConn.Open();
                obj_cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex) {
                Console.WriteLine(sqlex.Message);
                //return sqlex.Message, "Aviso", );
            }
            finally { objConn.Close(); }
        }

        /*
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

            return objDT_Usrs;
        }
        */

    }
    
}
