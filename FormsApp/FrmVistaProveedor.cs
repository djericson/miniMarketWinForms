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

using NS_WinFormsApps;

namespace FormsApp
{
    public partial class FrmVistaProveedor : Form
    {
        ClsBLProveedor obj_BL_Proveedor = new ClsBLProveedor();
        public FrmVistaProveedor()
        {
            InitializeComponent();
        } 
        private void OcularColumnas()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
        }


        private void Mostrar()
        {

            dgvListado.DataSource = ClsBLProveedor.MOSTRAR();
            //OcularColumnas();
        }


        private void BuscarRazon_Social()
        {
            dgvListado.DataSource = obj_BL_Proveedor.BUSCAR_RAZON_SOCIAL(txtBuscar.Text);
            OcularColumnas();
        }

  
        private void BuscarNum_Documento()
        {
            dgvListado.DataSource = obj_BL_Proveedor.BUSCAR_NUM_DOCUMENTO(txtBuscar.Text);
            OcularColumnas();
        }


        private void FrmVistaProveedor_Load(object sender, EventArgs e)
        {
            Mostrar();
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

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPedido frm = FrmPedido.GetInstancia();
            string par1, par2, par3, par4;
            par1 = Convert.ToString(dgvListado.CurrentRow.Cells["id_proveedor"].Value);
            par2 = Convert.ToString(dgvListado.CurrentRow.Cells["nombre_comercial"].Value);
            par3 = Convert.ToString(dgvListado.CurrentRow.Cells["Categoria"].Value);
            par4 = Convert.ToString(dgvListado.CurrentRow.Cells[4].Value);
            frm.ControlesProveedor(par1, par2, par3, par4);
            Hide();
        }
    }
}
