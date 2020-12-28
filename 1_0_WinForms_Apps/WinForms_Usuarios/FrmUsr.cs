using System;
using System.Windows.Forms;
using Utilitarios;

namespace App
{
    public partial class FrmUsrs : Form
    {
        public FrmUsrs()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            WCFSeguridad.Service1Client xwcf = new WCFSeguridad.Service1Client(); 
            //clsBLUsuario blusuario = new clsBLUsuario();
            xwcf.Insertar_Usuario(new ClsUsuario(txtUsuario.Text, txtClave.Text, txtNombres.Text, txtApellidos.Text, tb_email.Text));
        }

    }
}
