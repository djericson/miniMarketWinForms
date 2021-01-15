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
    public partial class Roles_Usuarios : Form
    {
        public Roles_Usuarios()
        {
            InitializeComponent();

            SidePanel.Height = creacion_rol.Height;
            SidePanel.Top = creacion_rol.Top;
            creacion_Rol1.BringToFront();
           
        }

        private void Roles_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void creacion_rol_Click(object sender, EventArgs e)
        {
            SidePanel.Height = creacion_rol.Height;
            SidePanel.Top = creacion_rol.Top;
            creacion_Rol1.BringToFront();
        }

        private void asignacion_rol_Click(object sender, EventArgs e)
        {
            SidePanel.Height = asignacion_rol.Height;
            SidePanel.Top = asignacion_rol.Top;
            asignacion_Rol1.BringToFront();
            asignacion_Rol1.loadlist_roles();
        }


    }
}
