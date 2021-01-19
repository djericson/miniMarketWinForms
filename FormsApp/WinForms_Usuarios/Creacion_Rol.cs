using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FormsApp.WinForms_Usuarios
{
    public partial class Creacion_Rol : UserControl
    {
         

        DataSet dataSet = new DataSet();
        Service_User_Rol.Gestion_User_RolClient objWcf = new Service_User_Rol.Gestion_User_RolClient();
        public static int Column = 0;
        public Creacion_Rol()
        {
            InitializeComponent();
        }

        private void add_Rol_Click(object sender, EventArgs e)
        {
            var name = name_rol.Text;
            objWcf.insert(name);
            load_list_roles();
            //var data =  objWcf.List_User_rol();
            //Type type = dataSet.GetType();
            //var dataset = Deserialize(data, type);
            //dataGrid_Roles.DataSource = dataset.Tables["list_roles"];

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
        public void load_list_roles()
        {
            var data = objWcf.List_User_rol();
            Type type = dataSet.GetType();
            var dataset = Deserialize(data, type);
            dataGrid_Roles.DataSource = dataset.Tables["list_roles"];
            Column = dataGrid_Roles.Columns.Count;
        }
        private void Creacion_Rol_Load(object sender, EventArgs e)
        {

            load_list_roles();
        }

        private void dataGrid_Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Column > 0)
            {
                name_rol.Text = dataGrid_Roles.CurrentRow.Cells[1].Value.ToString();

            }
        }
    }
}
