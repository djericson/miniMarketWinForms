using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAC
{
    public class DAC_Login
    {
        SqlConnection cn = new SqlConnection("Data Source= sql-srv2.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();
        DataSet dataSet = new DataSet();
        //List<string> DatosUsuario = new List<string>();
        List<List<string>> DatosUsuario = new List<List<string>>();
        //public static string[] DatosUsuario = new string[10];
         
         

        
         
        public List<List<string>> Login(string user, string pasword)
        {
            try
            {
                DatosUsuario.Clear();
                cmd = new SqlCommand("Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Usuario", user);
                cmd.Parameters.AddWithValue("@Pasword", pasword);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "Usuario", "roles_user" });
                if (dataSet.Tables["Usuario"].Rows.Count == 1)
                {
                    var ID_User = dataSet.Tables[0].Rows[0]["id_usr"].ToString();
                    var Name_User = dataSet.Tables[0].Rows[0]["usr_nom"].ToString();
                    DatosUsuario.Add(new List<string> { ID_User, Name_User });
                    if (dataSet.Tables["roles_user"].Rows.Count >= 1)
                    {

                        foreach (DataRow dataRow in dataSet.Tables["roles_user"].Rows)
                        {

                            DatosUsuario.Add(new List<string> { dataRow["id_rol"].ToString(), dataRow["Nombre"].ToString() });

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            cn.Close();

            return DatosUsuario;
        }


         
        public DataTable Forms_For_User(int ID_Rol)
        {
            cmd = new SqlCommand("Forms_For_User", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID_Rol", ID_Rol);
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
