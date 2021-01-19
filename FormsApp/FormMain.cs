using App;
using FormsApp.WinForms_Usuarios;
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

namespace FormsApp
{
    public partial class FormMain : Form
    {
        gestion_productos _gestion_Productos = new gestion_productos();
        FrmProveedores _FrmProveedores = new FrmProveedores();
        FrmPedido _FrmPedido = new FrmPedido();
        Rol_Usuario rol_Usuario = new Rol_Usuario();
        FrmUsrs frmUsrs = new FrmUsrs();


        DataTable dataTable = new DataTable();
        Service_User_Rol.Gestion_User_RolClient objwcf = new Service_User_Rol.Gestion_User_RolClient();
        public FormMain()
        {
            InitializeComponent();
        }
        DataTable Deserialize(string DataTable, Type type1)
        {

            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            StringReader sr = new StringReader(DataTable);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            //object result = json.Deserialize(reader, valueType);
            var result = json.Deserialize(reader, type1);
            reader.Close();

            return (DataTable)result;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            Usuario.Text = login.Usuario;
            Rol.Text = MasDeUnRol.Name_Rol;
            Type type = dataTable.GetType();
            var data = objwcf.Forms_For_User(MasDeUnRol.ID_ROL);
            dataTable = Deserialize(data, type);
            //MessageBox.Show(productos.Name.ToString());

            //var ID_User = dataTable.Rows[0]["Nombre"].ToString();
        }



        private void productos_Click(object sender, EventArgs e)
        {
            if (Acceso(Productos.Name.ToString()))
            {
                _gestion_Productos.Show();
                this.Hide();
            }
        }

        public Boolean  Acceso(string Butto_Form)
        {
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string Form = dataRow["Nombre"].ToString();
                if (Butto_Form == Form)
                {
                    return true;
                }
            }
            return false;
        }
        private void Provedores_Click(object sender, EventArgs e)
        {
            if(Acceso(Provedores.Name.ToString()))
            {
                _FrmProveedores.Show();
                this.Hide();
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            login gestion_cursos = new login();
            gestion_cursos.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventas_Click(object sender, EventArgs e)
        {

            if (Acceso(Ventas.Name.ToString()))
            {
                //_gestion_Productos.Show();
                //this.Hide();
            }

             
        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            if (Acceso(pedidos.Name.ToString()))
            {
                //_gestion_Productos.Show();
                //this.Hide();
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            if (Acceso(Usuarios.Name.ToString()))
            {
                frmUsrs.Show();
                this.Hide();
            }
        }

        private void Roles_Usuario_Click(object sender, EventArgs e)
        {
            if (Acceso(Provedores.Name.ToString()))
            {
                rol_Usuario.Show();
                this.Hide();
            }
        }
    }
}
