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
using FormsApp;


namespace FormsApp
{
    public partial class FrmVistaProducto : Form
    {
        public FrmVistaProducto()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {

            //dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Visible = false;
            dgvListado.Columns[4].Visible = false;
            dgvListado.Columns[8].Visible = false;
            dgvListado.Columns[9].Visible = false;
            dgvListado.Columns[10].Visible = false;

        }
        private void Mostrar()
        {
            dgvListado.DataSource = new ClsBL_Producto().MOSTRAR();
            OcultarColumnas();
        }

        private void FrmVistaProducto_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            FrmPedido form = FrmPedido.GetInstancia();
            string par1, par2, par3, par4, par5, par6, par7, par8;
            par1 = Convert.ToString( dgvListado.CurrentRow.Cells["id_prod"].Value);
            par2 = Convert.ToString( dgvListado.CurrentRow.Cells["Stock_MInimo"].Value);
            par3 = Convert.ToString( dgvListado.CurrentRow.Cells["Stock_Maximo"].Value);
            par4 = Convert.ToString( dgvListado.CurrentRow.Cells["NOMBRE_PRODUCTO"].Value);
            par5 = Convert.ToString( dgvListado.CurrentRow.Cells["MARCA"].Value);
            par6 = Convert.ToString( dgvListado.CurrentRow.Cells["cant_Total"].Value);
            par7 = Convert.ToString( dgvListado.CurrentRow.Cells["descripcion"].Value);
            form.ControlesProducto(par1, par2, par3, par4, par5, par6, par7);
            Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvListado.DataSource = new ClsBL_Producto().BUSCAR_NOMBRE(txtBuscar.Text);
            OcultarColumnas();
        }
    }
}
