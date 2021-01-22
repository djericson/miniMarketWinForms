using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
{
    public partial class FrmUsrs : Form
    {

        public FrmUsrs()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FormsApp.SrvRef_Usr.Service_UsrClient xwcf = new FormsApp.SrvRef_Usr.Service_UsrClient();
            //MessageBox.Show( "cmb: "+cmb_tipoDoc.SelectedIndex);
            //MessageBox.Show("cmb: " + cmb_tipoDoc.SelectedValue);
            xwcf.insUsr( new Object[]{ txt_usrNick.Text, txt_usrPass.Text, cmb_tipoDoc.SelectedIndex+1, txt_nroDoc.Text, txt_usrRuc.Text, txt_usrNom.Text,
            txt_usrApePat.Text, txt_usrApeMat.Text, txt_usrEmail.Text, txt_usrTlf.Text, txt_usrDir.Text} );
            
           
        }

        public void _GetListaUsrs() {
        
        }

        private void FrmUsrs_Load(object sender, EventArgs e)
        {
            _GetListaUsrs();

            cmb_tipoDoc.DataSource = Enum.GetValues(typeof(Tipo_docIdent))
            .Cast<Enum>()
            .Select(value => new {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            })
            .OrderBy(item => item.value)
            .ToList();
            cmb_tipoDoc.DisplayMember = "Description";
            cmb_tipoDoc.ValueMember = "value";
        }
    }

    //enum tipo documento:
    public enum Tipo_docIdent
    {
        [Description("DNI")]
        DNI = 1,
        [Description("Pasaporte")]
        PASAPORTE = 2,

    }
}

