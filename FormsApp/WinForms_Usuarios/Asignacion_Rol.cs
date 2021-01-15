using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace FormsApp.WinForms_Usuarios
{
    public partial class Asignacion_Rol : UserControl
    {


        Service_User_Rol.Gestion_User_RolClient objwcf = new Service_User_Rol.Gestion_User_RolClient();
        DataSet dataSet = new DataSet();
        public Asignacion_Rol()
        {
            InitializeComponent();
        }
        DataSet Deserialize(string DataTable, Type type1)
        {
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            StringReader sr = new StringReader(DataTable);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            var result = json.Deserialize(reader, type1);
            reader.Close();
            return (DataSet)result;
        }
        public void loadlist_Roles_user()
        {
            var data = objwcf.List_User_rol();
            Type type = dataSet.GetType();
            var dataset = Deserialize(data, type);
            roles.DataSource = dataset.Tables["list_roles"];
            roles.DisplayMember = "nombre";
            roles.ValueMember = "codigo"; 

            list_user_rol.DataSource = dataset.Tables["list_User"];
            list_user_rol.Columns[0].Visible = false;
        }
        private void Asignacion_Rol_Load(object sender, EventArgs e)
        {

            

        }

        private void add_Rol_Click(object sender, EventArgs e)
        {
            var id_rol = Convert.ToInt32(roles.SelectedValue.ToString());
            var id_user = Convert.ToInt32(list_user_rol.CurrentRow.Cells[0].Value.ToString());
            objwcf.insert_rol_user(id_rol, id_user);
            loadlist_Roles_user();


        }

        

        private void delete_user_rol_Click(object sender, EventArgs e)
        {


            var id_rol = Convert.ToInt32(roles.SelectedValue.ToString());
            var id_user = Convert.ToInt32(list_user_rol.CurrentRow.Cells[0].Value);
            objwcf.delete_rol_user(id_rol, id_user);
            loadlist_Roles_user();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = (string)roles.Items[roles.SelectedIndex];

            //string name = (string)((DataRowView)roles.Items[roles.SelectedIndex])["id"];
            //MessageBox.Show("" + roles.Items[2].ToString());
            //MessageBox.Show(name);
        }

        private void roles_DrawItem(object sender, DrawItemEventArgs e)
        {
              
        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void list_user_rol_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var data = list_user_rol.CurrentRow.Cells[2].Value.ToString();
            roles.Text = data;

            //MessageBox.Show(roles.SelectedValue.ToString());

            //int codigo = (int)((DataRowView)roles.Items[roles.SelectedIndex])["codigo"];

        }
    }
}
