//using App.UserControl_to_gestion_productos;

namespace NS_WinFormsApps
{
    partial class gestion_productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete = new System.Windows.Forms.Button();
            this.add_producto = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.update = new System.Windows.Forms.Button();
            this.list_productos = new System.Windows.Forms.DataGridView();
            this.agregar_datagridview = new System.Windows.Forms.Button();
            this.delete_datagridview = new System.Windows.Forms.Button();
            this.update_datagridview = new System.Windows.Forms.Button();
            this.presio_promed_dpt = new System.Windows.Forms.NumericUpDown();
            this.fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.fecha_fabricacion = new System.Windows.Forms.DateTimePicker();
            this.fecha_ingreso_stock = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cantida_produ_venta = new System.Windows.Forms.RichTextBox();
            this.presio_prome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.presio_promdio = new System.Windows.Forms.NumericUpDown();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.RichTextBox();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.unidad_produc = new System.Windows.Forms.RichTextBox();
            this.cantida_total = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numero_producto = new System.Windows.Forms.RichTextBox();
            this.Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presio_promed_dpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presio_promdio)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(394, 569);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(83, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add_producto
            // 
            this.add_producto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_producto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_producto.Location = new System.Drawing.Point(175, 569);
            this.add_producto.Name = "add_producto";
            this.add_producto.Size = new System.Drawing.Size(89, 28);
            this.add_producto.TabIndex = 15;
            this.add_producto.Text = "Insert";
            this.add_producto.UseVisualStyleBackColor = true;
            this.add_producto.Click += new System.EventHandler(this.add_producto_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.White;
            this.BtnAyuda.FlatAppearance.BorderSize = 0;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Location = new System.Drawing.Point(314, 81);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(30, 26);
            this.BtnAyuda.TabIndex = 19;
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(212, 81);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 28);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // update
            // 
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(293, 569);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 28);
            this.update.TabIndex = 22;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // list_productos
            // 
            this.list_productos.AllowUserToAddRows = false;
            this.list_productos.AllowUserToDeleteRows = false;
            this.list_productos.AllowUserToResizeColumns = false;
            this.list_productos.AllowUserToResizeRows = false;
            this.list_productos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.list_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.list_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_productos.DefaultCellStyle = dataGridViewCellStyle1;
            this.list_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_productos.Location = new System.Drawing.Point(23, 370);
            this.list_productos.Name = "list_productos";
            this.list_productos.ReadOnly = true;
            this.list_productos.RowHeadersWidth = 30;
            this.list_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_productos.ShowEditingIcon = false;
            this.list_productos.Size = new System.Drawing.Size(674, 182);
            this.list_productos.TabIndex = 44;
            this.list_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_productos_CellClick);
            // 
            // agregar_datagridview
            // 
            this.agregar_datagridview.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.agregar_datagridview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_datagridview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_datagridview.Location = new System.Drawing.Point(717, 382);
            this.agregar_datagridview.Name = "agregar_datagridview";
            this.agregar_datagridview.Size = new System.Drawing.Size(61, 28);
            this.agregar_datagridview.TabIndex = 45;
            this.agregar_datagridview.Text = "add";
            this.agregar_datagridview.UseVisualStyleBackColor = true;
            this.agregar_datagridview.Click += new System.EventHandler(this.agregar_datagridview_Click);
            // 
            // delete_datagridview
            // 
            this.delete_datagridview.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_datagridview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_datagridview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_datagridview.Location = new System.Drawing.Point(717, 476);
            this.delete_datagridview.Name = "delete_datagridview";
            this.delete_datagridview.Size = new System.Drawing.Size(61, 28);
            this.delete_datagridview.TabIndex = 46;
            this.delete_datagridview.Text = "delete";
            this.delete_datagridview.UseVisualStyleBackColor = true;
            this.delete_datagridview.Click += new System.EventHandler(this.delete_datagridview_Click);
            // 
            // update_datagridview
            // 
            this.update_datagridview.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update_datagridview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_datagridview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_datagridview.Location = new System.Drawing.Point(718, 430);
            this.update_datagridview.Name = "update_datagridview";
            this.update_datagridview.Size = new System.Drawing.Size(60, 28);
            this.update_datagridview.TabIndex = 47;
            this.update_datagridview.Text = "update";
            this.update_datagridview.UseVisualStyleBackColor = true;
            this.update_datagridview.Click += new System.EventHandler(this.update_datagridview_Click);
            // 
            // presio_promed_dpt
            // 
            this.presio_promed_dpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presio_promed_dpt.DecimalPlaces = 2;
            this.presio_promed_dpt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presio_promed_dpt.Location = new System.Drawing.Point(569, 41);
            this.presio_promed_dpt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.presio_promed_dpt.Name = "presio_promed_dpt";
            this.presio_promed_dpt.Size = new System.Drawing.Size(128, 27);
            this.presio_promed_dpt.TabIndex = 79;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiento.Location = new System.Drawing.Point(569, 198);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(132, 21);
            this.fecha_vencimiento.TabIndex = 78;
            // 
            // fecha_fabricacion
            // 
            this.fecha_fabricacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fabricacion.Location = new System.Drawing.Point(569, 157);
            this.fecha_fabricacion.Name = "fecha_fabricacion";
            this.fecha_fabricacion.Size = new System.Drawing.Size(132, 21);
            this.fecha_fabricacion.TabIndex = 77;
            // 
            // fecha_ingreso_stock
            // 
            this.fecha_ingreso_stock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ingreso_stock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_ingreso_stock.Location = new System.Drawing.Point(569, 122);
            this.fecha_ingreso_stock.Name = "fecha_ingreso_stock";
            this.fecha_ingreso_stock.Size = new System.Drawing.Size(132, 21);
            this.fecha_ingreso_stock.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "5- fecha vencimiento";
            // 
            // cantida_produ_venta
            // 
            this.cantida_produ_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cantida_produ_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantida_produ_venta.Location = new System.Drawing.Point(569, 81);
            this.cantida_produ_venta.Multiline = false;
            this.cantida_produ_venta.Name = "cantida_produ_venta";
            this.cantida_produ_venta.Size = new System.Drawing.Size(132, 27);
            this.cantida_produ_venta.TabIndex = 74;
            this.cantida_produ_venta.Text = "";
            // 
            // presio_prome
            // 
            this.presio_prome.AutoSize = true;
            this.presio_prome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.presio_prome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presio_prome.Location = new System.Drawing.Point(391, 44);
            this.presio_prome.Name = "presio_prome";
            this.presio_prome.Size = new System.Drawing.Size(155, 17);
            this.presio_prome.TabIndex = 73;
            this.presio_prome.Text = "1- presio promedio det";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "2- cantidad prod venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "3- fecha ingreso stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "4- fecha fabricacion ";
            // 
            // presio_promdio
            // 
            this.presio_promdio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presio_promdio.DecimalPlaces = 2;
            this.presio_promdio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presio_promdio.Location = new System.Drawing.Point(212, 198);
            this.presio_promdio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.presio_promdio.Name = "presio_promdio";
            this.presio_promdio.Size = new System.Drawing.Size(128, 27);
            this.presio_promdio.TabIndex = 93;
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(212, 117);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(132, 25);
            this.categoria.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "4- presio_promedio";
            // 
            // marca
            // 
            this.marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.marca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(212, 157);
            this.marca.Multiline = false;
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(132, 27);
            this.marca.TabIndex = 90;
            this.marca.Text = "";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(212, 285);
            this.descripcion.Multiline = false;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(132, 27);
            this.descripcion.TabIndex = 89;
            this.descripcion.Text = "";
            // 
            // unidad_produc
            // 
            this.unidad_produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.unidad_produc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_produc.Location = new System.Drawing.Point(212, 326);
            this.unidad_produc.Multiline = false;
            this.unidad_produc.Name = "unidad_produc";
            this.unidad_produc.Size = new System.Drawing.Size(132, 27);
            this.unidad_produc.TabIndex = 88;
            this.unidad_produc.Text = "";
            // 
            // cantida_total
            // 
            this.cantida_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cantida_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantida_total.Location = new System.Drawing.Point(212, 243);
            this.cantida_total.Multiline = false;
            this.cantida_total.Name = "cantida_total";
            this.cantida_total.Size = new System.Drawing.Size(132, 27);
            this.cantida_total.TabIndex = 87;
            this.cantida_total.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 85;
            this.label11.Text = "3-marca ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 84;
            this.label10.Text = "5- descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "5- cantidad total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "6- unidad producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "2- categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "1- nombre producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 95;
            this.label1.Text = "Codigo";
            // 
            // numero_producto
            // 
            this.numero_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numero_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_producto.Location = new System.Drawing.Point(212, 37);
            this.numero_producto.Multiline = false;
            this.numero_producto.Name = "numero_producto";
            this.numero_producto.Size = new System.Drawing.Size(132, 28);
            this.numero_producto.TabIndex = 96;
            this.numero_producto.Text = "";
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(599, 565);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 37);
            this.Atras.TabIndex = 97;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // gestion_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 609);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.numero_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presio_promdio);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.unidad_produc);
            this.Controls.Add(this.cantida_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.presio_promed_dpt);
            this.Controls.Add(this.fecha_vencimiento);
            this.Controls.Add(this.fecha_fabricacion);
            this.Controls.Add(this.fecha_ingreso_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantida_produ_venta);
            this.Controls.Add(this.presio_prome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_datagridview);
            this.Controls.Add(this.delete_datagridview);
            this.Controls.Add(this.agregar_datagridview);
            this.Controls.Add(this.list_productos);
            this.Controls.Add(this.update);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.add_producto);
            this.Controls.Add(this.delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion_productos";
            this.Load += new System.EventHandler(this.gestion_productos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presio_promed_dpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presio_promdio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add_producto;
        //private Update_product update_product1;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.RichTextBox richTextBox1;
        //private Update_product update_Product;
        private System.Windows.Forms.Button update;
        public System.Windows.Forms.DataGridView list_productos;
        private System.Windows.Forms.Button agregar_datagridview;
        private System.Windows.Forms.Button delete_datagridview;
        private System.Windows.Forms.Button update_datagridview;
        public System.Windows.Forms.NumericUpDown presio_promed_dpt;
        public System.Windows.Forms.DateTimePicker fecha_vencimiento;
        public System.Windows.Forms.DateTimePicker fecha_fabricacion;
        public System.Windows.Forms.DateTimePicker fecha_ingreso_stock;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox cantida_produ_venta;
        public System.Windows.Forms.Label presio_prome;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown presio_promdio;
        public System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.RichTextBox marca;
        public System.Windows.Forms.RichTextBox descripcion;
        public System.Windows.Forms.RichTextBox unidad_produc;
        public System.Windows.Forms.RichTextBox cantida_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox numero_producto;
        private System.Windows.Forms.Button Atras;
    }
}