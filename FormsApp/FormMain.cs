using Newtonsoft.Json;
using NS_WinFormsApps;
using NS_WinFormsApps.Ventas_pagos;
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

        public static int ID_Usuario;
        public static string NameUsuario;
        public static string NameRol;
        public static int ID_Rol;

        FrmProveedores _FrmProveedores = new FrmProveedores();
        FrmPedido _FrmPedido = FrmPedido.GetInstancia();        
        gestion_productos _gestion_Productos = new gestion_productos();
        FrmUsrs frmUsrs = new FrmUsrs();

 
       


        public static string Form_For_Adm = "";
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
            var result = json.Deserialize(reader, type1);
            reader.Close();

            return (DataTable)result;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ID_Rol = 0;

            ID_Usuario =  login.ID_Usuario;
            Usuario.Text = login.Usuario;
            NameUsuario = login.Usuario;
            if (login.Name_Rol != "" && login.ID_Rol != 0)
            {
                NameRol = login.Name_Rol;
                Rol.Text = login.Name_Rol;
                ID_Rol = login.ID_Rol;
            }
            else
            {
                NameRol = MasDeUnRol.Name_Rol;
                Rol.Text = MasDeUnRol.Name_Rol;
                ID_Rol = MasDeUnRol.ID_Rol;
            }

             
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
                    if (Butto_Form == dataRow["Nombre"].ToString())
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
                //MessageBox.Show("Form provedores");

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
            //dataTable.Clear();
            login _login = new login();
            _login.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void ventas_Click(object sender, EventArgs e)
        {

            if (Acceso(Ventas.Name.ToString()))
            {
                Ventas ventas = new Ventas(login.ID_Usuario,login.Name_Usuario);
                ventas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }


        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            if (Acceso(Pedidos.Name.ToString()))
            {
                MessageBox.Show("Form pedidos");
                _FrmPedido.Show();
                this.Hide();
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

                MessageBox.Show("Form Usuarios");

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
            if (Acceso(GestionRolesUser.Name.ToString()))
            {
                Form_For_Adm = GestionRolesUser.Name.ToString();

                Gestion_RolesFormsUser gestion_Roles_User = new Gestion_RolesFormsUser();
                gestion_Roles_User.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }
        }

        private void ProductosDescuento_Click(object sender, EventArgs e)
        {
            if (Acceso(ProductosDescuento.Name.ToString()))
            {


                ProductoDescuento _ProductoDescuento = new ProductoDescuento();
                _ProductoDescuento.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No tienes acceso");
            }
        }
    }
}
