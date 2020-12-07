using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pruebawcf
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            WCFSeguridad.Service1Client xwcf = new WCFSeguridad.Service1Client();
            WCFSeguridad.clsUsuario xobj = new WCFSeguridad.clsUsuario();
            xobj.Nombres = txtNombres.Text;xobj.Apellidos = txtApellidos.Text;
            xobj.clave = txtClave.Text;xobj.Usuario = txtUsuario.Text;
            xobj.Correo = txtCorreo.Text;
            xwcf.Insertar_Usuario(xobj);
        }
    }
}
