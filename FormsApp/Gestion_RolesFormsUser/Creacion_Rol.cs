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
using System.IO;
using Newtonsoft.Json;
using FormsApp.SrvRef_UsrRol;
using FormsApp;

namespace FormsApp
{
    public partial class Creacion_Rol : Form
    {
        DataSet dataSet = new DataSet();
        FormsApp.SrvRef_UsrRol.Gestion_User_RolClient objWcf = new FormsApp.SrvRef_UsrRol.Gestion_User_RolClient();
        public static int Column = 0;
        public Creacion_Rol()
        {
            InitializeComponent();
        }
        public void load_list_roles()
        {
            var data = objWcf.List_User_rol();
            Type type = dataSet.GetType();
            var dataset = Deserialize(data, type);
            dataGrid_Roles.DataSource = dataset.Tables["list_roles"];
            Column = dataGrid_Roles.Columns.Count;
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
        private void delete_rol_Click(object sender, EventArgs e)
        {
            if (Column > 0)
            {
                var id = Convert.ToInt32(dataGrid_Roles.CurrentRow.Cells[0].Value);
                objWcf.delete(id);
                load_list_roles();
                //var data = objWcf.List_User_rol();
                //Type type = dataSet.GetType();
                //var dataset = Deserialize(data, type);
                //dataGrid_Roles.DataSource = dataset.Tables["list_roles"];


            }
            //var data = objWcf.List_User_rol();
            //Type type = dataSet.GetType();
            //var dataset = Deserialize(data, type);
            //dataGrid_Roles.DataSource = dataset.Tables["list_roles"];
            //Column = dataGrid_Roles.Columns.Count;
        }
        
        
         
        private void add_Rol_Click(object sender, EventArgs e)
        {
            if (name_rol.Text != "")
            {
                var name = name_rol.Text;
                objWcf.insert(name);
                load_list_roles();
                //var name = name_rol.Text;
                //objWcf.insert(name);
                load_list_roles();
                //var data =  objWcf.List_User_rol();
                Type type = dataSet.GetType();
                //var dataset = Deserialize(data, type);

                //dataGrid_Roles.DataSource = dataset.Tables["list_roles"];

            }
            else
            {
                MessageBox.Show("Ingrese Nombre del Rol");
            }

        }

        private void delete_rol_Click_1(object sender, EventArgs e)
        {
            
            if (Column > 0)
            {
                var id = Convert.ToInt32(dataGrid_Roles.CurrentRow.Cells[0].Value);
                if (FormMain.ID_Rol == id)
                {
                    MessageBox.Show("seras direccionado a la ventana de login");
                    objWcf.delete(id);
                    login _login = new login();
                    _login.Login(login.Name_Usuario, login.Pasword);
                    this.Hide();
                }
                else
                {
                    objWcf.delete(id);
                    load_list_roles();
                }
               
                
                //var data = objWcf.List_User_rol();
                //Type type = dataSet.GetType();
                //var dataset = Deserialize(data, type);
                //dataGrid_Roles.DataSource = dataset.Tables["list_roles"];


            }

        }

        private void Creacion_Rol_Load_1(object sender, EventArgs e)
        {
            load_list_roles();
           
        }

        private void Atras_Click_1(object sender, EventArgs e)
        {
            Gestion_RolesFormsUser _Gestion_Roles_User = new Gestion_RolesFormsUser();
            _Gestion_Roles_User.Show();
            this.Close();
        }

        private void dataGrid_Roles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Column > 0)
            {
                if (Column > 0)
                {
                    name_rol.Text = dataGrid_Roles.CurrentRow.Cells[1].Value.ToString();

                }
            }
        }
    }
}