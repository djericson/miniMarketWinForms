using App.UserControl_to_gestion_productos;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_productos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.search_produ = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tag_producto = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add_producto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update_product1 = new App.UserControl_to_gestion_productos.Update_product();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(243, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "name product";
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Location = new System.Drawing.Point(403, 69);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(53, 36);
            this.BtnAyuda.TabIndex = 2;
            this.BtnAyuda.Text = "...";
            this.BtnAyuda.UseVisualStyleBackColor = true;
            this.BtnAyuda.Click += new System.EventHandler(this.buscar_producto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.search_produ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 558);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "       Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Location = new System.Drawing.Point(0, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(10, 49);
            this.panel.TabIndex = 6;
            // 
            // search_produ
            // 
            this.search_produ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_produ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_produ.FlatAppearance.BorderSize = 0;
            this.search_produ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_produ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_produ.ForeColor = System.Drawing.Color.White;
            this.search_produ.Image = ((System.Drawing.Image)(resources.GetObject("search_produ.Image")));
            this.search_produ.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.search_produ.Location = new System.Drawing.Point(12, 111);
            this.search_produ.Name = "search_produ";
            this.search_produ.Size = new System.Drawing.Size(185, 51);
            this.search_produ.TabIndex = 5;
            this.search_produ.Text = "  search product";
            this.search_produ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search_produ.UseVisualStyleBackColor = false;
            this.search_produ.Click += new System.EventHandler(this.search_produ_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(246, 69);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightMargin = 3;
            this.richTextBox1.Size = new System.Drawing.Size(140, 36);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // tag_producto
            // 
            this.tag_producto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tag_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tag_producto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_producto.Image = global::App.Properties.Resources.Webp_net_resizeimage__12_;
            this.tag_producto.Location = new System.Drawing.Point(246, 111);
            this.tag_producto.Name = "tag_producto";
            this.tag_producto.Size = new System.Drawing.Size(62, 42);
            this.tag_producto.TabIndex = 8;
            this.tag_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tag_producto.UseCompatibleTextRendering = true;
            this.tag_producto.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(549, 124);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(109, 28);
            this.update.TabIndex = 11;
            this.update.Text = "update producto";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(655, 124);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(109, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add_producto
            // 
            this.add_producto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_producto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_producto.Location = new System.Drawing.Point(434, 124);
            this.add_producto.Name = "add_producto";
            this.add_producto.Size = new System.Drawing.Size(119, 28);
            this.add_producto.TabIndex = 15;
            this.add_producto.Text = "add producto";
            this.add_producto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.panel2.Controls.Add(this.update_product1);
            this.panel2.Location = new System.Drawing.Point(247, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 363);
            this.panel2.TabIndex = 17;
            // 
            // update_product1
            // 
            this.update_product1.Location = new System.Drawing.Point(-1, 3);
            this.update_product1.Name = "update_product1";
            this.update_product1.Size = new System.Drawing.Size(650, 290);
            this.update_product1.TabIndex = 0;
            // 
            // gestion_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_producto);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.tag_producto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion_productos";
            this.Load += new System.EventHandler(this.gestion_productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button search_produ;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tag_producto;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add_producto;
        private System.Windows.Forms.Panel panel2;
        private Update_product update_product1;
    }
}