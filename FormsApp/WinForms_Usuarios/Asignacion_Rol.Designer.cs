﻿namespace FormsApp.WinForms_Usuarios
{
    partial class Asignacion_Rol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.update_rol_user = new System.Windows.Forms.Button();
            this.add_Rol = new System.Windows.Forms.Button();
            this.list_user_rol = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_user_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // update_rol_user
            // 
            this.update_rol_user.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update_rol_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_rol_user.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_rol_user.Location = new System.Drawing.Point(136, 222);
            this.update_rol_user.Name = "update_rol_user";
            this.update_rol_user.Size = new System.Drawing.Size(89, 28);
            this.update_rol_user.TabIndex = 29;
            this.update_rol_user.Text = "delete";
            this.update_rol_user.UseVisualStyleBackColor = true;
            this.update_rol_user.Click += new System.EventHandler(this.delete_user_rol_Click);
            // 
            // add_Rol
            // 
            this.add_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Rol.Location = new System.Drawing.Point(21, 222);
            this.add_Rol.Name = "add_Rol";
            this.add_Rol.Size = new System.Drawing.Size(89, 28);
            this.add_Rol.TabIndex = 28;
            this.add_Rol.Text = "add ";
            this.add_Rol.UseVisualStyleBackColor = true;
            this.add_Rol.Click += new System.EventHandler(this.add_Rol_Click);
            // 
            // list_user_rol
            // 
            this.list_user_rol.AllowUserToAddRows = false;
            this.list_user_rol.AllowUserToDeleteRows = false;
            this.list_user_rol.AllowUserToResizeColumns = false;
            this.list_user_rol.AllowUserToResizeRows = false;
            this.list_user_rol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_user_rol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_user_rol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_user_rol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list_user_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_user_rol.DefaultCellStyle = dataGridViewCellStyle3;
            this.list_user_rol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_user_rol.Location = new System.Drawing.Point(21, 270);
            this.list_user_rol.Name = "list_user_rol";
            this.list_user_rol.ReadOnly = true;
            this.list_user_rol.RowHeadersWidth = 30;
            this.list_user_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_user_rol.ShowEditingIcon = false;
            this.list_user_rol.Size = new System.Drawing.Size(317, 248);
            this.list_user_rol.TabIndex = 27;
            this.list_user_rol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_user_rol_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(96, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Roles";
            // 
            // roles
            // 
            this.roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(82, 147);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(132, 25);
            this.roles.TabIndex = 41;
            this.roles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roles_DrawItem);
            this.roles.SelectedIndexChanged += new System.EventHandler(this.roles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Roles";
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(236, 56);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(54, 41);
            this.Atras.TabIndex = 83;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Asignacion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.update_rol_user);
            this.Controls.Add(this.add_Rol);
            this.Controls.Add(this.list_user_rol);
            this.Controls.Add(this.label2);
            this.Name = "Asignacion_Rol";
            this.Size = new System.Drawing.Size(382, 546);
            this.Load += new System.EventHandler(this.Asignacion_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_user_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button update_rol_user;
        public System.Windows.Forms.Button add_Rol;
        public System.Windows.Forms.DataGridView list_user_rol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox roles;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Atras;
    }
}