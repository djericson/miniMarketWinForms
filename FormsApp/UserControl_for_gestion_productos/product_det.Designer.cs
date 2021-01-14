namespace FormsApp.UserControl_for_gestion_productos
{
    partial class product_det
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)(this.presio_promed_dpt)).BeginInit();
            this.SuspendLayout();
            // 
            // presio_promed_dpt
            // 
            this.presio_promed_dpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presio_promed_dpt.DecimalPlaces = 2;
            this.presio_promed_dpt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presio_promed_dpt.Location = new System.Drawing.Point(207, 21);
            this.presio_promed_dpt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.presio_promed_dpt.Name = "presio_promed_dpt";
            this.presio_promed_dpt.Size = new System.Drawing.Size(128, 27);
            this.presio_promed_dpt.TabIndex = 69;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_vencimiento.Location = new System.Drawing.Point(207, 178);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(132, 21);
            this.fecha_vencimiento.TabIndex = 67;
            // 
            // fecha_fabricacion
            // 
            this.fecha_fabricacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_fabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fabricacion.Location = new System.Drawing.Point(207, 137);
            this.fecha_fabricacion.Name = "fecha_fabricacion";
            this.fecha_fabricacion.Size = new System.Drawing.Size(132, 21);
            this.fecha_fabricacion.TabIndex = 66;
            // 
            // fecha_ingreso_stock
            // 
            this.fecha_ingreso_stock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ingreso_stock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_ingreso_stock.Location = new System.Drawing.Point(207, 102);
            this.fecha_ingreso_stock.Name = "fecha_ingreso_stock";
            this.fecha_ingreso_stock.Size = new System.Drawing.Size(132, 21);
            this.fecha_ingreso_stock.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "5- fecha vencimiento";
            // 
            // cantida_produ_venta
            // 
            this.cantida_produ_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cantida_produ_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantida_produ_venta.Location = new System.Drawing.Point(207, 61);
            this.cantida_produ_venta.Multiline = false;
            this.cantida_produ_venta.Name = "cantida_produ_venta";
            this.cantida_produ_venta.Size = new System.Drawing.Size(132, 27);
            this.cantida_produ_venta.TabIndex = 61;
            this.cantida_produ_venta.Text = "";
            // 
            // presio_prome
            // 
            this.presio_prome.AutoSize = true;
            this.presio_prome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.presio_prome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presio_prome.Location = new System.Drawing.Point(29, 24);
            this.presio_prome.Name = "presio_prome";
            this.presio_prome.Size = new System.Drawing.Size(155, 17);
            this.presio_prome.TabIndex = 53;
            this.presio_prome.Text = "1- presio promedio det";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "2- cantidad prod venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "3- fecha ingreso stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "4- fecha fabricacion ";
            // 
            // product_det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "product_det";
            this.Size = new System.Drawing.Size(372, 539);
            ((System.ComponentModel.ISupportInitialize)(this.presio_promed_dpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown presio_promed_dpt;
        public System.Windows.Forms.DateTimePicker fecha_vencimiento;
        public System.Windows.Forms.DateTimePicker fecha_fabricacion;
        public System.Windows.Forms.DateTimePicker fecha_ingreso_stock;
        public System.Windows.Forms.RichTextBox cantida_produ_venta;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label presio_prome;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}
