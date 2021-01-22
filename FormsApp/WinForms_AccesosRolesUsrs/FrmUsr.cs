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

            //xwcf.insUsr( new Object() { txt_usrNick.Text, txt_usrPass.Text, cmb_tipoDoc.SelectedValue, txt_nroDoc.Text, "_" } );

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
        [Description("none")]
        DNI = 1,
        [Description("sewn")]
        PASAPORTE = 2,

    }
}

