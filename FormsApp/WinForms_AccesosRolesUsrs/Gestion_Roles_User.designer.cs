namespace FormsApp
{
    partial class Gestion_Roles_User
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
            this.Creacion_Rol = new System.Windows.Forms.Button();
            this.Rol_Usuario = new System.Windows.Forms.Button();
            this.Forms_Rol = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Creacion_Rol
            // 
            this.Creacion_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Creacion_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Creacion_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creacion_Rol.Location = new System.Drawing.Point(53, 65);
            this.Creacion_Rol.Name = "Creacion_Rol";
            this.Creacion_Rol.Size = new System.Drawing.Size(131, 81);
            this.Creacion_Rol.TabIndex = 47;
            this.Creacion_Rol.Text = "Creacion Rol";
            this.Creacion_Rol.UseVisualStyleBackColor = true;
            this.Creacion_Rol.Click += new System.EventHandler(this.Creacion_Rol_Click_1);
            // 
            // Rol_Usuario
            // 
            this.Rol_Usuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Rol_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rol_Usuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol_Usuario.Location = new System.Drawing.Point(226, 65);
            this.Rol_Usuario.Name = "Rol_Usuario";
            this.Rol_Usuario.Size = new System.Drawing.Size(139, 81);
            this.Rol_Usuario.TabIndex = 48;
            this.Rol_Usuario.Text = "Rol Usuario";
            this.Rol_Usuario.UseVisualStyleBackColor = true;
            this.Rol_Usuario.Click += new System.EventHandler(this.Rol_Usuario_Click);
            // 
            // Forms_Rol
            // 
            this.Forms_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Forms_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forms_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forms_Rol.Location = new System.Drawing.Point(53, 181);
            this.Forms_Rol.Name = "Forms_Rol";
            this.Forms_Rol.Size = new System.Drawing.Size(131, 89);
            this.Forms_Rol.TabIndex = 49;
            this.Forms_Rol.Text = "Forms Rol";
            this.Forms_Rol.UseVisualStyleBackColor = true;
            this.Forms_Rol.Click += new System.EventHandler(this.Forms_Rol_Click_1);
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(53, 341);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(131, 58);
            this.Atras.TabIndex = 86;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Gestion_Roles_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 449);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Forms_Rol);
            this.Controls.Add(this.Rol_Usuario);
            this.Controls.Add(this.Creacion_Rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Roles_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol_Usuario";
            this.Load += new System.EventHandler(this.Gestion_Roles_User_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Creacion_Rol;
        public System.Windows.Forms.Button Rol_Usuario;
        public System.Windows.Forms.Button Forms_Rol;
        private System.Windows.Forms.Button Atras;
    }
}