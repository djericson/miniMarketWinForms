
using FormsApp.WinForms_AccesosRolesUsrs;
using NS_WinFormsApps.WinForms_AccesosRolesUsrs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Gestion_Roles_User : Form
    {
        public Gestion_Roles_User()
        {
            InitializeComponent();
        }

        

        private void Gestion_Roles_User_Load(object sender, EventArgs e)
        {

        }

        private void Creacion_Rol_Click_1(object sender, EventArgs e)
        {
            Creacion_Rol creacion_rol = new Creacion_Rol();
            creacion_rol.Show();
            this.Hide();
        }

        private void Rol_Usuario_Click(object sender, EventArgs e)
        {
            Rol_Usuario rol_Usuario = new Rol_Usuario();
            rol_Usuario.Show();
            this.Hide();
        }

        private void Forms_Rol_Click_1(object sender, EventArgs e)
        {
            Forms_Rol forms_Rol = new Forms_Rol();
            forms_Rol.Show();
            this.Hide();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
