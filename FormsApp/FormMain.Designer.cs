namespace FormsApp
{
    partial class FormMain
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
            this.Productos = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Label();
            this.Provedores = new System.Windows.Forms.Button();
            this.Rol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Roles_Usuario = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.pedidos = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_usuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Productos
            // 
            this.Productos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productos.Location = new System.Drawing.Point(45, 57);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(172, 56);
            this.Productos.TabIndex = 1;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(117, 23);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(47, 17);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "label1";
            // 
            // Provedores
            // 
            this.Provedores.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Provedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Provedores.Location = new System.Drawing.Point(233, 57);
            this.Provedores.Name = "Provedores";
            this.Provedores.Size = new System.Drawing.Size(172, 56);
            this.Provedores.TabIndex = 3;
            this.Provedores.Text = "Provedores";
            this.Provedores.UseVisualStyleBackColor = true;
            this.Provedores.Click += new System.EventHandler(this.Provedores_Click);
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(117, 62);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(47, 17);
            this.Rol.TabIndex = 4;
            this.Rol.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Roles_Usuario);
            this.groupBox1.Controls.Add(this.Usuarios);
            this.groupBox1.Controls.Add(this.pedidos);
            this.groupBox1.Controls.Add(this.Ventas);
            this.groupBox1.Controls.Add(this.Productos);
            this.groupBox1.Controls.Add(this.Provedores);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forms";
            // 
            // Roles_Usuario
            // 
            this.Roles_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Roles_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Roles_Usuario.Location = new System.Drawing.Point(440, 135);
            this.Roles_Usuario.Name = "Roles_Usuario";
            this.Roles_Usuario.Size = new System.Drawing.Size(172, 56);
            this.Roles_Usuario.TabIndex = 7;
            this.Roles_Usuario.Text = "Roles_Usuario";
            this.Roles_Usuario.UseVisualStyleBackColor = true;
            this.Roles_Usuario.Click += new System.EventHandler(this.Roles_Usuario_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Location = new System.Drawing.Point(233, 135);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(172, 56);
            this.Usuarios.TabIndex = 6;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // pedidos
            // 
            this.pedidos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidos.Location = new System.Drawing.Point(45, 135);
            this.pedidos.Name = "pedidos";
            this.pedidos.Size = new System.Drawing.Size(172, 56);
            this.pedidos.TabIndex = 5;
            this.pedidos.Text = "pedidos";
            this.pedidos.UseVisualStyleBackColor = true;
            this.pedidos.Click += new System.EventHandler(this.pedidos_Click);
            // 
            // Ventas
            // 
            this.Ventas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventas.Location = new System.Drawing.Point(440, 57);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(172, 56);
            this.Ventas.TabIndex = 4;
            this.Ventas.Text = "ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            this.Ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(185, 426);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(93, 41);
            this.Atras.TabIndex = 81;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(309, 426);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 41);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Rol:";
            // 
            // ID_usuario
            // 
            this.ID_usuario.AutoSize = true;
            this.ID_usuario.Location = new System.Drawing.Point(368, 71);
            this.ID_usuario.Name = "ID_usuario";
            this.ID_usuario.Size = new System.Drawing.Size(35, 13);
            this.ID_usuario.TabIndex = 84;
            this.ID_usuario.Text = "label3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 517);
            this.Controls.Add(this.ID_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button Provedores;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button pedidos;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Roles_Usuario;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID_usuario;
    }
}