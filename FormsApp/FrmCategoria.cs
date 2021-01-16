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
using BL;

namespace FormsApp
{
    public partial class FrmCategoria : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        ClsBL_Categoria objCategaria = new ClsBL_Categoria();
        public FrmCategoria()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre de la categoria");
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
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
        #endregion
        #region METODO HABILITAR LOS CONTROLES DEL FORMULARIO
        private void HabilitarTxt(bool valor)
        {
            txtNombre.ReadOnly = !valor;
            txtDescripcion.ReadOnly = !valor;
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
        #region METODO OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
        }
        #endregion
        #region MOSTRAR TODOS LOS REGISTROS DE CATEGORIA
        private void Mostrar()
        {
            dgvListado.DataSource = ClsBL_Categoria.MOSTRAR();
            OcultarColumnas(); 
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListado.Rows.Count);
        }
        #endregion
        #region METODO BUSCAR NOMBRE CATEGORIA
        private void BuscarNombre()
        {            
            //dgvListado.DataSource = objCategaria.BUSCAR_NOMBRE(txtBuscar.Text);
            dgvListado.DataSource = new ClsBL_Categoria().BUSCAR_NOMBRE(txtBuscar.Text);
            OcultarColumnas();
            lblTotal.Text = "Total de registros " + Convert.ToString(dgvListado.Rows.Count);
        }
        #endregion

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Mostrar();
            HabilitarTxt(false);
            Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            Botones();
            Limpiar();
            HabilitarTxt(true);
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos seran remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Nombre");
                }
                else
                {
                    if (IsNuevo)
                    {
                        rpta = ClsBL_Categoria.INSERTAR(txtNombre.Text.Trim().ToUpper(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        rpta = ClsBL_Categoria.EDITAR(Convert.ToInt32(dgvListado.CurrentRow.Cells["Id_categoria"].Value), txtNombre.Text.Trim().ToUpper(),
                            txtDescripcion.Text.Trim());
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
                MessageBox.Show(ex.Message + ex.StackTrace); 
            }
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Descripcion"].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                IsEditar = true;
                Botones();
                HabilitarTxt(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
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

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
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
                            Rpta = ClsBL_Categoria.ELIMINAR(Convert.ToInt32(Codigo));
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
                }
                chkEliminar.Checked = false;
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
