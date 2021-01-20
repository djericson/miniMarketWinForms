using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.WinForms_Usuarios
{
    public partial class Rol_Usuario : Form
    {
        Service_User_Rol.Gestion_User_RolClient objwcf = new Service_User_Rol.Gestion_User_RolClient();
        DataSet dataSet = new DataSet();
        static int column = 0;
        public Rol_Usuario()
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
            if (dataset.Tables["list_roles"].Rows.Count != 0)
            {
                roles.DataSource = dataset.Tables["list_roles"];
                roles.DisplayMember = "nombre";
                roles.ValueMember = "codigo";
            }
            else
            {
                roles.DataSource = null;
            }


            list_user_rol.DataSource = dataset.Tables["list_User"];
            column = list_user_rol.Columns.Count;
            //list_user_rol.Columns[0].Visible = false;
        }

        private void update_rol_user_Click(object sender, EventArgs e)
        {
            if (column > 1)
            {

                if (roles.Items.Count != 0)
                {
                    var id_rol = Convert.ToInt32(roles.SelectedValue.ToString());
                    var id_user = Convert.ToInt32(list_user_rol.CurrentRow.Cells[0].Value);
                    objwcf.delete_rol_user(id_rol, id_user);
                    loadlist_Roles_user();
                }

            }
        }

        private void add_Rol_Click(object sender, EventArgs e)
        {
            if (column > 1)
            {

                if (roles.Items.Count != 0)
                {

                    var id_rol = Convert.ToInt32(roles.SelectedValue.ToString());
                    var id_user = Convert.ToInt32(list_user_rol.CurrentRow.Cells[0].Value.ToString());
                    objwcf.insert_rol_user(id_rol, id_user);
                    loadlist_Roles_user();
                }


                //var id_rol = Convert.ToInt32(roles.SelectedValue.ToString());
                //var id_user = Convert.ToInt32(list_user_rol.CurrentRow.Cells[0].Value.ToString());
                //objwcf.insert_rol_user(id_rol, id_user);
                //loadlist_Roles_user();

            }
        }

        private void list_user_rol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (list_user_rol.Columns.Count > 3)
            {
                var _roles = list_user_rol.CurrentRow.Cells[2].Value.ToString();
                roles.Text = _roles;
            }
        }

        private void Rol_Usuario_Load(object sender, EventArgs e)
        {
            loadlist_Roles_user();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Gestion_Roles_User _Gestion_Roles_User = new Gestion_Roles_User();
            _Gestion_Roles_User.Show();
            this.Hide();
        }
    }
}
