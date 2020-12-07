using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace App
{
    public partial class FrmUsr : Form
    {
        public FrmUsr()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            WCFSeguridad.Service1Client xwcf = new WCFSeguridad.Service1Client(); 
            //clsBLUsuario blusuario = new clsBLUsuario();
            xwcf.Insertar_Usuario(new clsUsuario(txtUsuario.Text, txtClave.Text, txtNombres.Text, txtApellidos.Text, txtEmail.Text));
        }
    }
}
