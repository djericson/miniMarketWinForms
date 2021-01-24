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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.list_productos = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Descuento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 87;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_productos.DefaultCellStyle = dataGridViewCellStyle3;
            this.list_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_productos.Location = new System.Drawing.Point(33, 315);
            this.list_productos.Name = "list_productos";
            this.list_productos.ReadOnly = true;
            this.list_productos.RowHeadersWidth = 30;
            this.list_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_productos.ShowEditingIcon = false;
            this.list_productos.Size = new System.Drawing.Size(349, 182);
            this.list_productos.TabIndex = 88;
            // 
            // agregar
            // 
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(33, 255);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(61, 28);
            this.agregar.TabIndex = 89;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(321, 255);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(61, 28);
            this.eliminar.TabIndex = 90;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_inicio.Location = new System.Drawing.Point(137, 213);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(120, 21);
            this.fecha_inicio.TabIndex = 91;
            // 
            // fecha_fin
            // 
            this.fecha_fin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fin.Location = new System.Drawing.Point(137, 158);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(120, 21);
            this.fecha_fin.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Fecha Fin";
            // 
            // ProductoDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.list_productos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductoDescuento";
            ((System.ComponentModel.ISupportInitialize)(this.list_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView list_productos;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        public System.Windows.Forms.DateTimePicker fecha_inicio;
        public System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}