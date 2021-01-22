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

namespace NS_WinFormsApps.Ventas_pagos
{
    public partial class Ventas : Form
    {
        ClsBL_Usr _objUsr;
        ClsBL_Producto _objProducto;

        int id_cliente, id_cajero, id_producto;

        public Ventas()
        {
            InitializeComponent();
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
            _objUsr = new ClsBL_Usr();
            _objProducto = new ClsBL_Producto();

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
                busqueda.objTabla = _objUsr.getUsrCliente("");
                busqueda.ShowDialog();
                if (busqueda.objRow != null)
                {
                    id_cliente = (int)busqueda.objRow.Cells["id"].Value;
                    txtCliente.Text = busqueda.objRow.Cells["Nombre"].Value.ToString();
                }
                busqueda.objTabla.Clear();
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != string.Empty && nudCantidad.Value > 0)
            {

                double total = double.Parse(txtPrecio.Text) * double.Parse(nudCantidad.Value.ToString()) *
                  (1 - (double.Parse(nudDescuento.Value.ToString())) / 100);
                dgvDetalle.Rows.Add(id_producto, txtProducto.Text, txtPrecio.Text, nudCantidad.Value, nudDescuento.Value, total);
                CalcularPrecioTotal();

            }
            else
            {
                MsjError("Error ventas", "No ha seleccionado un producto o no ha especificado la cantidad que desea vender del producto");
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

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

            txtCliente.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            dgvDetalle.Rows.Clear();
            txtPrecioTotal.Clear();
            id_cliente = 0;
            id_producto = 0;
        }

        private void btnIrPago_Click(object sender, EventArgs e)
        {

            var datos = new Dictionary<string, object>()
            {
                { "id_usuario",id_cliente},
                { "id_cajero",id_cajero},
                { "numero_operacion", txtNumOperacion.Text },
                { "fecha_venta",dtpFecha.Value },
                { "precio_total",txtPrecioTotal.Text},
                { "detalle_venta",getDetalle()}
            };

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var busqueda = new NS_Busqueda.Busqueda())
            {

                busqueda.objTabla = _objProducto.search_product(txtProducto.Text);

                busqueda.objTabla = _objProducto.search_product("");

                busqueda.ShowDialog();
                if (busqueda.objRow != null)
                {
                    id_producto = (int)busqueda.objRow.Cells["codigo"].Value;
                    txtProducto.Text = busqueda.objRow.Cells["nombre"].Value.ToString();
                    txtPrecio.Text = busqueda.objRow.Cells["precio"].Value.ToString();
                }
                busqueda.objTabla.Clear();
            }
        }
    }
}
