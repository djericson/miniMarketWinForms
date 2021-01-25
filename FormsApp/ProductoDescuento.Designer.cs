namespace FormsApp
{
    partial class ProductoDescuento
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
            this.label2 = new System.Windows.Forms.Label();
            this.Descuento = new System.Windows.Forms.TextBox();
            this.list_productos = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Descuento";
            // 
            // Descuento
            // 
            this.Descuento.Location = new System.Drawing.Point(135, 51);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(120, 20);
            this.Descuento.TabIndex = 87;
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
            this.list_productos.Location = new System.Drawing.Point(19, 264);
            this.list_productos.Name = "list_productos";
            this.list_productos.ReadOnly = true;
            this.list_productos.RowHeadersWidth = 30;
            this.list_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_productos.ShowEditingIcon = false;
            this.list_productos.Size = new System.Drawing.Size(445, 182);
            this.list_productos.TabIndex = 88;
            // 
            // agregar
            // 
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(31, 210);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(61, 28);
            this.agregar.TabIndex = 89;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(282, 210);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(61, 28);
            this.eliminar.TabIndex = 90;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_Inicio.Location = new System.Drawing.Point(135, 101);
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.Size = new System.Drawing.Size(120, 21);
            this.Fecha_Inicio.TabIndex = 91;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_Fin.Location = new System.Drawing.Point(135, 156);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(120, 21);
            this.Fecha_Fin.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Fecha Fin";
            // 
            // ProductoDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fecha_Fin);
            this.Controls.Add(this.Fecha_Inicio);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.list_productos);
            this.Controls.Add(this.Descuento);
            this.Controls.Add(this.label2);
            this.Name = "ProductoDescuento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductoDescuento_FormClosing);
            this.Load += new System.EventHandler(this.ProductoDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descuento;
        public System.Windows.Forms.DataGridView list_productos;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.DateTimePicker Fecha_Inicio;
        public System.Windows.Forms.DateTimePicker Fecha_Fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}