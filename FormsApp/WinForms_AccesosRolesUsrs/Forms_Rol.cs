using FormsApp;
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

 

namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
{
    public partial class Forms_Rol : Form
    {

        FormsApp.SrvRef_UsrRol.Gestion_User_RolClient objWcf = new FormsApp.SrvRef_UsrRol.Gestion_User_RolClient();
        DataSet dataSet = new DataSet();

        public Forms_Rol()
        {
            InitializeComponent();
        }

       

        private void add_Forms_Rol_Click(object sender, EventArgs e)
        {
            if (list_Form_rol.Columns.Count != 0 && Forms.Items.Count != 0)
            {
                var id_form = Convert.ToInt32(Forms.SelectedValue.ToString());
                var id_rol = Convert.ToInt32(list_Form_rol.CurrentRow.Cells[0].Value.ToString());
                objWcf.insert_Forms_rol(id_rol, id_form);
                load_forms_rol();
            }
        }

        public void load_forms_rol()
        {
            var data = objWcf.List_Forms_rol();
            Type type = dataSet.GetType();
            var dataset = Deserialize(data, type);
            Forms.DataSource = dataset.Tables["list_forms"];
            Forms.DisplayMember = "nombre";
            Forms.ValueMember = "codigo";

            list_Form_rol.DataSource = dataset.Tables["list_Roles_forms"];
            if (list_Form_rol.Columns.Count != 0)
            {

                //var dataset = Deserialize(data, type);
                //Forms.DataSource = dataset.Tables["list_forms"];
                Forms.DisplayMember = "nombre";
                Forms.ValueMember = "codigo";

                //list_Form_rol.DataSource = dataset.Tables["list_Roles_forms"];
                if (list_Form_rol.Columns.Count != 0)
                {
                    list_Form_rol.Columns[0].Visible = false;
                    list_Form_rol.CurrentCell = list_Form_rol.Rows[0].Cells[1];

                }
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
        private void Atras_Click(object sender, EventArgs e)
        {
            Gestion_Roles_User _Gestion_Roles_User = new Gestion_Roles_User();
            _Gestion_Roles_User.Show();
            this.Hide();
 
            if(list_Form_rol.Columns.Count != 0 && Forms.Items.Count != 0) {
                var id_form = Convert.ToInt32(Forms.SelectedValue.ToString());
                var id_rol = Convert.ToInt32(list_Form_rol.CurrentRow.Cells[0].Value.ToString());
                //objwcf.insert_Forms_rol(id_rol, id_form);
                load_forms_rol();
            }
           
        }

        private void delete_Forms_rol_Click(object sender, EventArgs e)
        {
            if (list_Form_rol.Columns.Count != 0 && Forms.Items.Count != 0) {
                var id_form = Convert.ToInt32(Forms.SelectedValue.ToString());
                var id_rol = Convert.ToInt32(list_Form_rol.CurrentRow.Cells[0].Value);
                //objwcf.delete_Forms_rol(id_rol, id_form);
                load_forms_rol();
            }
        }

        private void Forms_Rol_Load(object sender, EventArgs e)
        {
            load_forms_rol();
        }

        private void list_Form_rol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (list_Form_rol.Columns.Count > 2 && Forms.Items.Count != 0)
            {

            }
            if (list_Form_rol.Columns.Count > 2 && Forms.Items.Count != 0) {
                var data = list_Form_rol.CurrentRow.Cells[2].Value.ToString();
                Forms.Text = data;
            }
        }
    }
            
}
