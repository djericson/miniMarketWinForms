namespace App
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
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_producto = new System.Windows.Forms.TextBox();
            this.buscar_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo_producto";
            // 
            // codigo_producto
            // 
            this.codigo_producto.Location = new System.Drawing.Point(36, 79);
            this.codigo_producto.Name = "codigo_producto";
            this.codigo_producto.Size = new System.Drawing.Size(100, 20);
            this.codigo_producto.TabIndex = 1;
            this.codigo_producto.Text = " ";
            // 
            // buscar_producto
            // 
            this.buscar_producto.Location = new System.Drawing.Point(142, 77);
            this.buscar_producto.Name = "buscar_producto";
            this.buscar_producto.Size = new System.Drawing.Size(32, 23);
            this.buscar_producto.TabIndex = 2;
            this.buscar_producto.Text = "...";
            this.buscar_producto.UseVisualStyleBackColor = true;
            this.buscar_producto.Click += new System.EventHandler(this.buscar_producto_Click);
            // 
            // gestion_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar_producto);
            this.Controls.Add(this.codigo_producto);
            this.Controls.Add(this.label1);
            this.Name = "gestion_productos";
            this.Text = "gestion_productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo_producto;
        private System.Windows.Forms.Button buscar_producto;
    }
}