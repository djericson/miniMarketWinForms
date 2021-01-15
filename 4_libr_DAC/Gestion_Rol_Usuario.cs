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
    public class DacGestion_Rol_Usuario
    {
        SqlConnection cn = new SqlConnection("Data Source=srv-bd-sql-server.database.windows.net; User ID =edgar; Password =$E012345; Initial Catalog=miniMarket");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();
        DataSet dataSet = new DataSet();

        public DataSet list_Forms_Rol()
        {
            dataSet.Clear();
            cmd = new SqlCommand("select id as codigo, nombre from forms  select r.id as codigo_rol,r.Nombre Name_Rol,f.Nombre as Name_Form,rf.Fecha_Asignacion   from roles r full join Roles_Forms rf on r.id = rf.id_rol full join Forms f on f.id = rf.id_Form", cn);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "list_forms", "list_Roles_forms" });
            cn.Close();
            return dataSet;
        }
        public DataSet List_User_rol()
        {
                dataSet.Clear();
                cmd = new SqlCommand("select id as codigo , nombre  from roles select u.id_usr as codigo_User ,u.usr_nom as Usuario,ro.Nombre as Rol_name,ru.fecha_activa as Fecha_Asignacion from Usuario u full join Roles_Usuarios ru on u.id_usr = ru.id_usuario full join roles ro on ro.id = ru.id_rol", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "list_roles", "list_User" });
                cn.Close();
                return dataSet;

           
        }
        public void insert_Rol(string name)
        {
            cmd = new SqlCommand("insert_rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_Rol", name);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void update_Rol(int id, string name)
        {
            cmd = new SqlCommand("update_rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", id);
            cmd.Parameters.AddWithValue("@name_rol", name);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_Rol(int id)
        {
            cmd = new SqlCommand("delete_rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void insert_Rol_user(int rol, int user)
        {
            
            cmd = new SqlCommand("insert_rol_user", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", rol);
            cmd.Parameters.AddWithValue("@id_user", user);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_Rol_user(int rol, int user)
        {
            cmd = new SqlCommand("delete_rol_user", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", rol);
            cmd.Parameters.AddWithValue("@id_user", user);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public int get_id_rol(string rol)
        {
            schemaTable.Clear();
            cmd = new SqlCommand("select id from roles where nombre = '"+ rol+"'", cn);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            cn.Close();
            int id_rol = Convert.ToInt32(schemaTable.Rows[0]["id"].ToString());
            //schemaTable.Rows[0].Field();
            return id_rol;
        }

        public void insert_Forms_rol(int rol, int form)
        {

            cmd = new SqlCommand("insert_Forms_rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", rol);
            cmd.Parameters.AddWithValue("@id_Form", form);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_Forms_rol(int rol, int form)
        {
            cmd = new SqlCommand("delete_Forms_rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_rol", rol);
            cmd.Parameters.AddWithValue("@id_Form", form);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public int get_id_Form(string form)
        {
            schemaTable.Clear();
            cmd = new SqlCommand("select id from forms where nombre = '" + form + "'", cn);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            cn.Close();
            int id_rol = Convert.ToInt32(schemaTable.Rows[0]["id"].ToString());
            return id_rol;
        }


    }
}
