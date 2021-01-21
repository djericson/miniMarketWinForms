using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using BL;

namespace NS_WinFormsApps
{
    public partial class FrmProveedores : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        ClsBLProveedor obj_BL_Proveedor = new ClsBLProveedor();

        public FrmProveedores()
        {
            InitializeComponent();
        }
        #region METODO PARA MOSTRAR MENSAJE DE CONFIRMACION
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region METODO PARA MOSTRAR MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region METODO LIMPIAR TODOS LOS CONTROLES DEL FORMULARIO
        private void Limpiar()
        {
            txtRazon_Social.Text = string.Empty;
            txtNum_Documento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUrl.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        #endregion
        #region METODO HABILITAR LOS CONTROLES DEL FORMULARIO
        private void HabilitarTxt(bool valor)
        {
            txtRazon_Social.ReadOnly = !valor;
            txtDireccion.ReadOnly = !valor;
            cbCategoria.Enabled = valor;
            txtNum_Documento.ReadOnly = !valor;
            txtTelefono.ReadOnly = !valor;
            txtUrl.ReadOnly = !valor;
            txtEmail.ReadOnly = !valor;
        }
        #endregion
        #region METODO HABILITAR LOS BOTONES
        private void Botones()
        {
            if (IsNuevo || IsEditar)
            {
                HabilitarTxt(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                HabilitarTxt(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        #endregion
        #region METODO OCULTAR COLUMAS
        private void OcularColumnas()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
        }
        #endregion
        #region MOSTRAR TODOS LOS REGISTROS DE CATEGORIA
        private void Mostrar()
        {
            dgvListado.DataSource = ClsBLProveedor.MOSTRAR();
            OcularColumnas();
        }
        #endregion
        #region METODO BUSCAR POR RAZON SOCIAL
        private void BuscarRazon_Social()
        {
            dgvListado.DataSource = obj_BL_Proveedor.BUSCAR_RAZON_SOCIAL(txtBuscar.Text);
            OcularColumnas();
        }
        #endregion
        #region METODO BUSCAR POR NUMERO DE DOCUMENTO
        private void BuscarNum_Documento()
        {
            dgvListado.DataSource = obj_BL_Proveedor.BUSCAR_NUM_DOCUMENTO(txtBuscar.Text);
            OcularColumnas();

        }
        #endregion

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            HabilitarTxt(false);
            Botones();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbBuscar.Text.Equals("Razon Social"))
            {
                BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("RUC"))
            {
                BuscarNum_Documento();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eleminar los registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = ClsBLProveedor.ELIMINAR(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                MensajeOk("SE ELIMINO CORRECTAMENTE EL REGISTRO");
                            }
                            else
                            {
                                MensajeError(Rpta);
                            }
                        }
                    }
                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            Botones();
            Limpiar();
            HabilitarTxt(true);
            txtRazon_Social.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtRazon_Social.Text == string.Empty || txtNum_Documento.Text == string.Empty
                    || this.txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtRazon_Social, "Ingrese un Nombre");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un numero de Documento");
                    errorIcono.SetError(txtDireccion, "Ingrese una Direccion");
                    errorIcono.SetError(txtTelefono, "Ingrese una numero de Telefono");
                    errorIcono.SetError(txtEmail, "Ingrese una direccion de Correo");
                }
                else
                {
                    if (IsNuevo)
                    {
                        rpta = ClsBLProveedor.INSERTAR(txtRazon_Social.Text.Trim().ToUpper(), cbCategoria.Text, ""/*cbTipo_Documento.Text*/,
                        txtNum_Documento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtUrl.Text);
                    }
                    else
                    {
                        rpta = ClsBLProveedor.EDITAR(Convert.ToInt32(dgvListado.CurrentRow.Cells["id_Proveedor"].Value), txtRazon_Social.Text.Trim().ToUpper(), cbCategoria.Text, ""/*cbTipo_Documento.Text*/,
                        txtNum_Documento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtUrl.Text);
                    }
                  
                    if (rpta.Equals("OK"))
                    {
                        if (IsNuevo)
                        {
                            MensajeOk("Se inserto de forma correcta el registro");
                        }
                        else
                        {
                            MensajeOk("Se Actualizo de forma correcta el registro");
                        }
                    }
      
                    else
                    {
                        MensajeError(rpta);
                    }
                    IsNuevo = false;
                    IsEditar = false;
                    Botones();
                    Limpiar();
                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); // Nos muestra el posible error.
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtRazon_Social.Text.Equals(""))
            {
                IsEditar = true;
                Botones();
                HabilitarTxt(true);
            }
            else
            {
                MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            IsEditar = false;
            Botones();
            Limpiar();
            HabilitarTxt(false);
        }
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            txtRazon_Social.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Razon_Social"].Value);
            cbCategoria.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Categoria"].Value);
            txtNum_Documento.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Num_Documento"].Value);
            txtDireccion.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Direccion"].Value);
            txtTelefono.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Telefono"].Value);
            txtEmail.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Email"].Value);
            txtUrl.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Pagina_Web"].Value);
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
