using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace NS_WinFormsApps.Ventas_pagos
{
    public partial class Ventas : Form
    {
        ClsBL_Producto _objProducto;
        ClsBL_Vta _objVta;

        Object timeStamp_prod;
        int id_cliente, id_producto;
        int id_cajero = 3;

        public Ventas()
        {
            InitializeComponent();
        }

        public Ventas(int idCajero, string usuario)
        {
            InitializeComponent();
            id_cajero = idCajero;
            txtCajero.Text = usuario;
        }

        private void MsjError(string caption, string mensaje)
        {
            MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            _objProducto = new ClsBL_Producto();
            _objVta = new ClsBL_Vta();
            dgvVentas.DataSource = _objVta.search();
            txtNumOperacion.Text = (_objVta.getNumeroOperacion() + 1).ToString();
            txtNumComprobante.Text = txtNumOperacion.Text;
        }

        private bool isDataEmpty()
        {
            if (txtCliente.Text.Equals(string.Empty))
            {
                errorIcono.SetError(txtCliente,"No ha seleccionado un cliente");
                return true;
            }

            if(dgvDetalle.Rows.Count < 1)
            {
                MsjError("Error ventas","no hay productos en la grilla");
            }

            return false;
        }

        private void CalcularPrecioTotal()
        {
            double total = 0;
            foreach (DataGridViewRow data in dgvDetalle.Rows)
            {
                total += double.Parse(data.Cells["Total"].Value.ToString());
            }

            txtPrecioTotal.Text = total.ToString();
        }

        private string getDetalle()
        {
            string xml_detalle = string.Empty;
            xml_detalle = "<items>";
            foreach (DataGridViewRow data in dgvDetalle.Rows)
            {
                xml_detalle += "<item>";
                xml_detalle += "<id_producto>" + data.Cells["Codigo"].Value.ToString() + "</id_producto>";
                xml_detalle += "<cantidad>" + data.Cells["Cantidad"].Value.ToString() + "</cantidad>";
                xml_detalle += "<precio>" + data.Cells["Precio"].Value.ToString() + "</precio>";
                xml_detalle += "<descuento>" + data.Cells["Descuento"].Value.ToString() + "</descuento>";
                xml_detalle += "</item>";
            }
            xml_detalle += "</items>";

            return xml_detalle;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var busqueda = new NS_Busqueda.Busqueda())
            {

                busqueda.objTabla = _objVta.search_client("");
                busqueda.ShowDialog();
                if (busqueda.objRow != null)
                {
                    id_cliente = (int)busqueda.objRow.Cells["id"].Value;
                    txtCliente.Text = busqueda.objRow.Cells["Nombre"].Value.ToString();
                }
                busqueda.objTabla.Clear();

            }
        }

        private int getTipoComprobante()
        {
            if(cmbTipoComprobante.Text == "Factura")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private bool existeProductoEnGrilla()
        {
            foreach(DataGridViewRow row in dgvDetalle.Rows)
            {
                if((int)row.Cells["Codigo"].Value == id_producto)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != string.Empty && !existeProductoEnGrilla())
            {
                if(int.Parse(txtStock.Text) >= nudCantidad.Value  && nudCantidad.Value > 0)
                {
                    double total = double.Parse(txtPrecio.Text) * double.Parse(nudCantidad.Value.ToString()) *
                    (1 - (double.Parse(txtDescuento.Text.ToString())) / 100);
                    dgvDetalle.Rows.Add(id_producto, txtProducto.Text, txtPrecio.Text, nudCantidad.Value, txtDescuento.Text, total);
                    CalcularPrecioTotal();
                }
                else
                {
                    errorIcono.SetError(nudCantidad, "La cantidad definida es mayor al stock actual o es menor a 1");
                }

            }
            else
            {
                MsjError("Error ventas", "No ha seleccionado un producto o ya existe en la tabla");
            }
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDetalle.NewRowIndex || e.RowIndex < 0)
                return;


            if (e.ColumnIndex == dgvDetalle.Columns["Borrar"].Index)
            {
                dgvDetalle.Rows.RemoveAt(e.RowIndex);

                CalcularPrecioTotal();

            }
        }

        private void LimpiarTodo()
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            dgvDetalle.Rows.Clear();
            txtPrecioTotal.Clear();
            txtStock.Clear();
            txtDescuento.Clear();
            id_cliente = 0;
            id_producto = 0;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            txtNumOperacion.Text = (int.Parse(txtNumOperacion.Text) + 1).ToString();
            txtNumComprobante.Text = txtNumOperacion.Text;
        }

        private void btnIrPago_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("timeStamp_prod"+timeStamp_prod);
            if (!isDataEmpty()) {
                var datos = new Dictionary<string, Object>() {
                    { "id_usuario",id_cliente},
                    { "nombre_cliente",txtCliente.Text},
                    { "id_cajero",id_cajero},
                    { "numero_operacion", txtNumOperacion.Text },
                    { "fecha_venta",dtpFecha.Value },
                    { "precio_total",txtPrecioTotal.Text},
                    { "detalle_venta",getDetalle()},
                    { "tipo_comprobante",getTipoComprobante()},
                    {"numero_comprobante", txtNumComprobante.Text},
                    {"timeStamp_prod", timeStamp_prod}

                };

                Pagos pagos = new Pagos(datos);
                DialogResult dialog = pagos.ShowDialog(this); 
                if(dialog == DialogResult.OK) {
                    LimpiarTodo();
                    txtNumOperacion.Text = (int.Parse(txtNumOperacion.Text) + 1).ToString();
                    txtNumComprobante.Text = txtNumOperacion.Text;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (!txtStock.Text.Equals(string.Empty) && int.Parse(txtStock.Text) >= nudCantidad.Value)
            {
                nudCantidad.ForeColor = Color.Green;
            }
            else
            {
                nudCantidad.ForeColor = Color.Red;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = _objVta.search();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
                using (var busqueda = new NS_Busqueda.Busqueda()) {
                busqueda.objTabla = _objVta.search_product("");

                busqueda.ShowDialog();
                if (busqueda.objRow != null) {
                    id_producto = (int)busqueda.objRow.Cells["codigo"].Value;

                    ClsBL_Vta tmp_BL_vta = new ClsBL_Vta();
                    timeStamp_prod = tmp_BL_vta.selectUnProd(id_producto);
                    
                    txtProducto.Text = busqueda.objRow.Cells["nombre"].Value.ToString();
                    txtPrecio.Text = busqueda.objRow.Cells["precio"].Value.ToString();
                    txtStock.Text = busqueda.objRow.Cells["stock"].Value.ToString();
                    txtDescuento.Text = busqueda.objRow.Cells["descuento"].Value.ToString();
                    //timestamp = busqueda.objRow.Cells["ts_prod_Version"].Value.ToString();
                }
                busqueda.objTabla.Clear();
            }
        }
    }
}
