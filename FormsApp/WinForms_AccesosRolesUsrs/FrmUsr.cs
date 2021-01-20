using System;
using System.Windows.Forms;


namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
{
    public partial class FrmUsrs : Form
    {
        public Tipo_documento Enum_tipoDoc { get; set; }

        public FrmUsrs()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormsApp.SrvRef_Usr.Service_UsrClient xwcf = new FormsApp.SrvRef_Usr.Service_UsrClient();
            
            //xwcf.insert( new object(txt_usrNick.Text, txtClave.Text, txtNombres.Text, txtApellidos.Text, "_") );

        }

        public void _GetDatoss() { }

    }

    //enum tipo documento:
    public enum Tipo_documento
    {
        dni,
        pasaporte
    }

}
