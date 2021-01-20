 

using Newtonsoft.Json;
using NS_WinFormsApps;
using NS_WinFormsApps.WinForms_AccesosRolesUsrs;
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
using WcfService;

namespace FormsApp
{
    public partial class FormMain : Form
    {
        gestion_productos _gestion_Productos = new gestion_productos();
        FrmProveedores _FrmProveedores = new FrmProveedores();
        FrmPedido _FrmPedido = new FrmPedido();
        //Rol_Usuario rol_Usuario = new Rol_Usuario();
        FrmUsrs frmUsrs = new FrmUsrs();


        public static DataTable dataTable = new DataTable();
        SrvRef_UsrRol.Gestion_User_RolClient objwcf = new SrvRef_UsrRol.Gestion_User_RolClient();
        public FormMain()
        {
            InitializeComponent();
        }
        public DataTable Deserialize(string DataTable, Type type1)
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
            ID_usuario.Text = login.ID_Usuario.ToString();
            Usuario.Text = login.Usuario;
            //MessageBox.Show(""+ MasDeUnRol.Name_Rol);
            Rol.Text = MasDeUnRol.Name_Rol;
            Rol.Text = login.Rol;
            //Type type = dataTable.GetType();
            

            //var data = objwcf.Forms_For_User(login.Rol);

            //var data = objwcf.Forms_For_User(MasDeUnRol.ID_ROL);
            //dataTable = Deserialize(data, type);



            //if(dataTable == null )
            //{
            //    MessageBox.Show("");
            //    MasDeUnRol masDeUnRol = new MasDeUnRol();
            //    masDeUnRol.Show();
            //    this.Close();
            //}

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
            else
            {
                MessageBox.Show("No tienes acceso");
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
            else
            {
                MessageBox.Show("No tienes acceso");
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
            else
            {
                MessageBox.Show("No tienes acceso");
            }


        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            if (Acceso(pedidos.Name.ToString()))
            {
                //_gestion_Productos.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            
            if (Acceso(Usuarios.Name.ToString()))
            {
                frmUsrs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }
        }

        private void Roles_Usuario_Click(object sender, EventArgs e)
        {
            if (Acceso(Roles_Usuario.Name.ToString()))
            {
                Gestion_Roles_User gestion_Roles_User = new Gestion_Roles_User();
                gestion_Roles_User.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }
        }
    }
}
