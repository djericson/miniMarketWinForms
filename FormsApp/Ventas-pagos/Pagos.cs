using BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NS_WinFormsApps.Ventas_pagos
{
    public partial class Pagos : Form
    {
        Dictionary<string, object> _datos;
        ClsBL_Vta bl_venta;
        public Pagos()
        {
            InitializeComponent();
        }

        public Pagos(Dictionary<string, object> datos)
        {
            InitializeComponent();
            _datos = datos;
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            bl_venta = new ClsBL_Vta();
            txtCliente.Text = _datos["nombre_cliente"].ToString();
            txtTotal.Text = _datos["precio_total"].ToString();
            txtComprobante.Text = _datos["numero_comprobante"].ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int getTipoPago()
        {
            if (radMaster.Checked || radVisa.Checked)
            {
                return 1;
            }

            return 2;
        }

        private bool CamposCorrectos()
        {
            if (!radVisa.Checked && !radMaster.Checked && !radEfectivo.Checked)
            {
                MsjError("Metodo de pago no especificado", "No ha elegido el metodo de pago con el que desea efectuar la venta");
                return false;
            }

            if (radEfectivo.Checked && txtMonto.Text.Equals(string.Empty))
            {
                MsjError("Monto inválido", "No ha especificado el monto a pagar");
                return false;
            }

            if (radEfectivo.Checked && double.Parse(txtMonto.Text) < double.Parse(txtTotal.Text))
            {
                MsjError("Monto insuficiente", "El monto es insuficiente");
                return false;
            }

            return true;
        }

        private void GuardarVenta()
        {
            var datos_pago = new Dictionary<string, object>() {
                {"tipo_pago", getTipoPago()},
                {"monto_pago",txtTotal.Text }, 
            };

            int vta_id_out = bl_venta.insertar(_datos, datos_pago);
            if(vta_id_out == 2 )
                MessageBox.Show("Venta realizada", "La venta se ha registrado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (vta_id_out == -1)
                MessageBox.Show("Venta no hecha por que no hubo stock en producto", "_", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        private bool MontoMayor()
        {
            if (txtMonto.Text.Length > 0)
            {
                double monto = double.Parse(txtMonto.Text);
                double total = double.Parse(txtTotal.Text);
                return monto > total;
            }
            return false;
        }

        private void MsjError(string caption, string mensaje)
        {
            MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text.Length > 0)
            {

                if (MontoMayor())
                {
                    txtMonto.ForeColor = Color.Green;
                }
                else
                {
                    txtMonto.ForeColor = Color.DarkRed;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MontoMayor())
            {
                double monto = double.Parse(txtMonto.Text);
                double total = double.Parse(txtTotal.Text);
                double vuelto = monto - total;
                txtVuelto.Text = Math.Round(vuelto, 2).ToString();
            }
            else
            {
                MsjError("Error de pago", "El monto es insuficiente para realizar la venta");
            }
        }

        private void radEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radEfectivo.Checked)
            {
                boxEfectivo.Visible = true;
            }
            else
            {
                boxEfectivo.Visible = false;
            }

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (CamposCorrectos()) {
                this.DialogResult = DialogResult.OK;
                GuardarVenta();
                this.Close();
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "10";
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "20";
        }

        private void pb50_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "50";
        }

        private void pb100_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "100";
        }
    }
}
