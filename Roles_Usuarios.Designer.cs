namespace FormsApp.WinForms_Usuarios
{
    partial class Roles_Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.creacion_rol = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.asignacion_rol = new System.Windows.Forms.Button();
            this.asignacion_Rol1 = new FormsApp.WinForms_Usuarios.Asignacion_Rol();
            this.creacion_Rol1 = new FormsApp.WinForms_Usuarios.Creacion_Rol();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.creacion_rol);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.asignacion_rol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 503);
            this.panel1.TabIndex = 13;
            // 
            // creacion_rol
            // 
            this.creacion_rol.FlatAppearance.BorderSize = 0;
            this.creacion_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creacion_rol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creacion_rol.ForeColor = System.Drawing.Color.White;
            this.creacion_rol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creacion_rol.Location = new System.Drawing.Point(12, 59);
            this.creacion_rol.Name = "creacion_rol";
            this.creacion_rol.Size = new System.Drawing.Size(133, 54);
            this.creacion_rol.TabIndex = 4;
            this.creacion_rol.Text = "Creacion Rol";
            this.creacion_rol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.creacion_rol.UseVisualStyleBackColor = true;
            this.creacion_rol.Click += new System.EventHandler(this.creacion_rol_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // asignacion_rol
            // 
            this.asignacion_rol.FlatAppearance.BorderSize = 0;
            this.asignacion_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asignacion_rol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignacion_rol.ForeColor = System.Drawing.Color.White;
            this.asignacion_rol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.asignacion_rol.Location = new System.Drawing.Point(12, 113);
            this.asignacion_rol.Name = "asignacion_rol";
            this.asignacion_rol.Size = new System.Drawing.Size(145, 54);
            this.asignacion_rol.TabIndex = 4;
            this.asignacion_rol.Text = "Asignacion Rol";
            this.asignacion_rol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.asignacion_rol.UseVisualStyleBackColor = true;
            this.asignacion_rol.Click += new System.EventHandler(this.asignacion_rol_Click);
            // 
            // asignacion_Rol1
            // 
            this.asignacion_Rol1.Location = new System.Drawing.Point(180, 0);
            this.asignacion_Rol1.Name = "asignacion_Rol1";
            this.asignacion_Rol1.Size = new System.Drawing.Size(344, 492);
            this.asignacion_Rol1.TabIndex = 15;
            //this.asignacion_Rol1.Load += new System.EventHandler(this.asignacion_Rol1_Load);
            // 
            // creacion_Rol1
            // 
            this.creacion_Rol1.Location = new System.Drawing.Point(163, 12);
            this.creacion_Rol1.Name = "creacion_Rol1";
            this.creacion_Rol1.Size = new System.Drawing.Size(370, 489);
            this.creacion_Rol1.TabIndex = 14;
            // 
            // Roles_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 503);
            this.Controls.Add(this.asignacion_Rol1);
            this.Controls.Add(this.creacion_Rol1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roles_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol_Forms";
            this.Load += new System.EventHandler(this.Roles_Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button creacion_rol;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button asignacion_rol;
        private Creacion_Rol creacion_Rol1;
        private Asignacion_Rol asignacion_Rol1;
    }
}