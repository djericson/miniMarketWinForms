using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.WinForms_Usuarios
{
    public partial class Rol_Usuario : Form
    {
        public Rol_Usuario()
        {
            InitializeComponent();
            SidePanel.Height = creacion_rol.Height;
            SidePanel.Top = creacion_rol.Top;
            creacion_Rol1.BringToFront();
        }

        private void creacion_rol_Click(object sender, EventArgs e)
        {
            creacion_rol.Text = "Creacion Rol";
            SidePanel.Height = creacion_rol.Height;
            SidePanel.Top = creacion_rol.Top;
            creacion_Rol1.BringToFront();
            creacion_Rol1.load_list_roles();
        }

        private void Rol_user_Click(object sender, EventArgs e)
        {
            Rol_user.Text = "Rol Usuario ";
            SidePanel.Height = Rol_user.Height;
            SidePanel.Top = Rol_user.Top;
            asignacion_Rol1.BringToFront();
            asignacion_Rol1.loadlist_Roles_user();
        }

        private void Rol_Usuario_Load(object sender, EventArgs e)
        {
            Rol_user.Text = "Rol Usuario ";
            creacion_rol.Text = "Creacion Rol";
            Forms_rol.Text = "Forms Rol ";
        }

        private void Forms_rol_Click(object sender, EventArgs e)
        {
            Forms_rol.Text = "Forms Rol ";
            SidePanel.Height = Forms_rol.Height;
            SidePanel.Top = Forms_rol.Top;
            forms_Rol1.BringToFront();
            forms_Rol1.load_forms_rol();
        }
    }
}
