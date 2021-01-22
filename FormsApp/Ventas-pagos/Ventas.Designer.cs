namespace NS_WinFormsApps.Ventas_pagos
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIrPago = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumOperacion = new System.Windows.Forms.TextBox();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 36);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ventas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 585);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(331, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(737, 545);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cmbTipoComprobante);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnIrPago);
            this.tabPage2.Controls.Add(this.btnNuevaVenta);
            this.tabPage2.Controls.Add(this.btnBuscarCliente);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNumOperacion);
            this.tabPage2.Controls.Add(this.txtNumComprobante);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPrecioTotal);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtpFecha);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCajero);
            this.tabPage2.Controls.Add(this.txtCliente);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarProd);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.nudDescuento);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAgregarProd);
            this.groupBox1.Controls.Add(this.dgvDetalle);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(14, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 395);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Venta";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(321, 23);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(46, 22);
            this.btnBuscarProd.TabIndex = 65;
            this.btnBuscarProd.Text = "...";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(948, 17);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(769, 26);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(69, 20);
            this.nudDescuento.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(699, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Descuento";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(867, 17);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarProd.TabIndex = 7;
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Descuento,
            this.Total,
            this.Borrar});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 62);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(1042, 316);
            this.dgvDetalle.TabIndex = 6;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(606, 25);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(69, 20);
            this.nudCantidad.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(548, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(434, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(62, 24);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(254, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto";
            // 
            // cmbTipoComprobante
            // 
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTipoComprobante.Location = new System.Drawing.Point(536, 19);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(144, 21);
            this.cmbTipoComprobante.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tipo de comprobante";
            // 
            // btnIrPago
            // 
            this.btnIrPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrPago.Location = new System.Drawing.Point(902, 491);
            this.btnIrPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnIrPago.Name = "btnIrPago";
            this.btnIrPago.Size = new System.Drawing.Size(160, 51);
            this.btnIrPago.TabIndex = 66;
            this.btnIrPago.Text = "Ir a Pago";
            this.btnIrPago.UseVisualStyleBackColor = true;
            this.btnIrPago.Click += new System.EventHandler(this.btnIrPago_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Location = new System.Drawing.Point(738, 491);
            this.btnNuevaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(160, 51);
            this.btnNuevaVenta.TabIndex = 65;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(333, 15);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(46, 22);
            this.btnBuscarCliente.TabIndex = 64;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Nro Operacion";
            // 
            // txtNumOperacion
            // 
            this.txtNumOperacion.Location = new System.Drawing.Point(536, 51);
            this.txtNumOperacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumOperacion.Name = "txtNumOperacion";
            this.txtNumOperacion.Size = new System.Drawing.Size(144, 20);
            this.txtNumOperacion.TabIndex = 62;
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.Location = new System.Drawing.Point(841, 20);
            this.txtNumComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(153, 20);
            this.txtNumComprobante.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nro Comprobante";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(151, 514);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(92, 28);
            this.txtPrecioTotal.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 516);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Precio total";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(841, 50);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha";
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(123, 49);
            this.txtCajero.Margin = new System.Windows.Forms.Padding(2);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.ReadOnly = true;
            this.txtCajero.Size = new System.Drawing.Size(207, 20);
            this.txtCajero.TabIndex = 55;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(123, 16);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(207, 20);
            this.txtCliente.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cajero en turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre cliente";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIrPago;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumOperacion;
        private System.Windows.Forms.TextBox txtNumComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarProd;
    }
}