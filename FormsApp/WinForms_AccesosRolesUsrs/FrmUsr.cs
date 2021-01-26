using FormsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
{
    public partial class FrmUsrs : Form
    {
        FormsApp.SrvRef_Usr.Service_UsrClient xwcf;
        int id_usr;

        public FrmUsrs()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( "cmb: "+cmb_tipoDoc.SelectedIndex);
            //MessageBox.Show("cmb: " + cmb_tipoDoc.SelectedValue);

            //if txt_nroDoc.,
            //txt_usrRuc.Text
            try
            {
                xwcf.insUsr(new Object[]{ txt_usrNick.Text, txt_usrPass.Text, cmb_tipoDoc.SelectedIndex+1, txt_nroDoc.Text, txt_usrRuc.Text, txt_usrNom.Text,
                txt_usrApePat.Text, txt_usrApeMat.Text, txt_usrEmail.Text, txt_usrTlf.Text, txt_usrDir.Text});

                MessageBox.Show("El registro se insertó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListUsrs();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_updUsr_Click(object sender, EventArgs e)
        {
            try {
                xwcf.updUsr(new Object[]{id_usr, txt_usrNick.Text, txt_usrPass.Text, cmb_tipoDoc.SelectedIndex+1, txt_nroDoc.Text, txt_usrRuc.Text, txt_usrNom.Text,
                txt_usrApePat.Text, txt_usrApeMat.Text, txt_usrEmail.Text, txt_usrTlf.Text, txt_usrDir.Text});

                MessageBox.Show("El registro se actualizó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListUsrs();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_borrarUsr_Click(object sender, EventArgs e)
        {
            try {
                
                xwcf.delUsr(id_usr);

                MessageBox.Show("El registro se Eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListUsrs();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void getListUsrs()
        {
            try {
                List<Object[]> tmp_objLstObjs = new List<Object[]>( xwcf.getListUsrs() );
                dgv_listaUsrs.Rows.Clear();
                foreach (Object[] itmUsr in tmp_objLstObjs) {
                    //MessageBox.Show("itmUsr  3 : " + itmUsr[3]);
                    dgv_listaUsrs.Rows.Add(itmUsr[0].ToString(), itmUsr[1].ToString(), itmUsr[2].ToString(),
                    Enum.GetValues(typeof(Tipo_docIdent)).GetValue(int.Parse(itmUsr[3].ToString()) - 1),
                    itmUsr[4].ToString() != "0" ? itmUsr[4].ToString() : "",
                    itmUsr[5].ToString() != "0" ? itmUsr[5].ToString() : "",
                    itmUsr[6].ToString(), itmUsr[7].ToString(),
                    itmUsr[8].ToString(), itmUsr[9].ToString(), itmUsr[10].ToString(),
                    itmUsr[11].ToString() != "0" ? itmUsr[11].ToString() : ""
                    );
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //objDT_Usrs.Load(obj_dr, LoadOption.OverwriteChanges);
            //dgv_listaUsrs.DataSource = ;
        }

        private void FrmUsrs_Load(object sender, EventArgs e)
        {
            btn_updUsr.Enabled = false;
            btn_borrarUsr.Enabled = false;

            //nombrar Columnas:
            dgv_listaUsrs.Columns.Add("id_usr", "ID Usuario");
            dgv_listaUsrs.Columns.Add("nick_usr", "Nick");
            dgv_listaUsrs.Columns.Add("pass_usr", "Password");
            dgv_listaUsrs.Columns.Add("tipoDoc_usr", "Tipo documento");
            dgv_listaUsrs.Columns.Add("nroDoc_usr", "Nro. Doc. Ident.");
            dgv_listaUsrs.Columns.Add("ruc_usr", "Nro. de RUC");
            dgv_listaUsrs.Columns.Add("nom_usr", "Nombre");
            dgv_listaUsrs.Columns.Add("apePat_usr", "Ap. Paterno");
            dgv_listaUsrs.Columns.Add("apeMat_usr", "Ap. Materno");
            dgv_listaUsrs.Columns.Add("email_usr", "Email");
            dgv_listaUsrs.Columns.Add("tlf_usr", "Teléfono");
            dgv_listaUsrs.Columns.Add("dir_usr", "Dirección");

            xwcf = new FormsApp.SrvRef_Usr.Service_UsrClient();
            //cargar grilla de lista de Usuarios:
            getListUsrs();

            //cargar combobox tipo doc_Ident:
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

        private void dgv_listaUsrs_DoubleClick(object sender, EventArgs e)
        {
            id_usr = int.Parse( dgv_listaUsrs.CurrentRow.Cells["id_usr"].Value.ToString() );
            txt_usrNick.Text = dgv_listaUsrs.CurrentRow.Cells["nick_usr"].Value.ToString();
            txt_usrPass.Text = dgv_listaUsrs.CurrentRow.Cells["pass_usr"].Value.ToString();
            cmb_tipoDoc.SelectedValue = dgv_listaUsrs.CurrentRow.Cells["tipoDoc_usr"].Value;
            txt_nroDoc.Text = dgv_listaUsrs.CurrentRow.Cells["nroDoc_usr"].Value.ToString();
            txt_usrRuc.Text = dgv_listaUsrs.CurrentRow.Cells["ruc_usr"].Value.ToString();
            txt_usrNom.Text = dgv_listaUsrs.CurrentRow.Cells["nom_usr"].Value.ToString();
            txt_usrApePat.Text = dgv_listaUsrs.CurrentRow.Cells["apePat_usr"].Value.ToString();
            txt_usrApeMat.Text = dgv_listaUsrs.CurrentRow.Cells["apeMat_usr"].Value.ToString();
            txt_usrEmail.Text = dgv_listaUsrs.CurrentRow.Cells["email_usr"].Value.ToString();
            txt_usrDir.Text = dgv_listaUsrs.CurrentRow.Cells["tlf_usr"].Value.ToString();
            txt_usrTlf.Text = dgv_listaUsrs.CurrentRow.Cells["dir_usr"].Value.ToString();
            btn_updUsr.Enabled = true;
            btn_borrarUsr.Enabled = true;
        }

        private void FrmUsrs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void btn_limpiarCampos_Click(object sender, EventArgs e)
        {
            txt_usrNick.Text = "";
            txt_usrPass.Text = "";
            //cmb_tipoDoc.SelectedValue = "";
            txt_nroDoc.Text = "";
            txt_usrRuc.Text = "";
            txt_usrNom.Text = "";
            txt_usrApePat.Text = "";
            txt_usrApeMat.Text = "";
            txt_usrEmail.Text = "";
            txt_usrDir.Text = "";
            txt_usrTlf.Text = "";
            btn_updUsr.Enabled = false;
            btn_borrarUsr.Enabled = false;

        }

        private void txt_nroDoc_TextChanged(object sender, EventArgs e)
        {
           
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_nroDoc.Text, "^[0-9]")) {
                txt_nroDoc.Text = "";
            }
            
        }

        private void txt_usrRuc_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_usrRuc.Text, "^[0-9]")) {
                txt_usrRuc.Text = "";
            }
        }

        private void txt_usrTlf_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_usrTlf.Text, "^[0-9]")) {
                txt_usrTlf.Text = "";
            }
        }
    }

    //enum tipo documento:
    public enum Tipo_docIdent
    {
        [Description("DNI")]
        DNI = 1,
        [Description("Carne d Extranjeria")]
        CARNE_EXTRANJERIA = 2,

    }
}

