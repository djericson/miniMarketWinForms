﻿namespace FormsApp.WinForms_AccesosRolesUsrs
{
    partial class Forms_Rol
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
            this.label3 = new System.Windows.Forms.Label();
            this.Forms = new System.Windows.Forms.ComboBox();
            this.delete_Forms_rol = new System.Windows.Forms.Button();
            this.add_Forms_Rol = new System.Windows.Forms.Button();
            this.list_Form_rol = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_Form_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 90;
            this.label3.Text = "Forms";
            // 
            // Forms
            // 
            this.Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Forms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Forms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forms.FormattingEnabled = true;
            this.Forms.Location = new System.Drawing.Point(114, 118);
            this.Forms.Name = "Forms";
            this.Forms.Size = new System.Drawing.Size(132, 25);
            this.Forms.TabIndex = 89;
            // 
            // delete_Forms_rol
            // 
            this.delete_Forms_rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_Forms_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Forms_rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Forms_rol.Location = new System.Drawing.Point(233, 204);
            this.delete_Forms_rol.Name = "delete_Forms_rol";
            this.delete_Forms_rol.Size = new System.Drawing.Size(89, 28);
            this.delete_Forms_rol.TabIndex = 88;
            this.delete_Forms_rol.Text = "delete";
            this.delete_Forms_rol.UseVisualStyleBackColor = true;
            this.delete_Forms_rol.Click += new System.EventHandler(this.delete_Forms_rol_Click);
            // 
            // add_Forms_Rol
            // 
            this.add_Forms_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_Forms_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Forms_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Forms_Rol.Location = new System.Drawing.Point(51, 204);
            this.add_Forms_Rol.Name = "add_Forms_Rol";
            this.add_Forms_Rol.Size = new System.Drawing.Size(89, 28);
            this.add_Forms_Rol.TabIndex = 87;
            this.add_Forms_Rol.Text = "add ";
            this.add_Forms_Rol.UseVisualStyleBackColor = true;
            this.add_Forms_Rol.Click += new System.EventHandler(this.add_Forms_Rol_Click);
            // 
            // list_Form_rol
            // 
            this.list_Form_rol.AllowUserToAddRows = false;
            this.list_Form_rol.AllowUserToDeleteRows = false;
            this.list_Form_rol.AllowUserToResizeColumns = false;
            this.list_Form_rol.AllowUserToResizeRows = false;
            this.list_Form_rol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Form_rol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_Form_rol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_Form_rol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list_Form_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_Form_rol.DefaultCellStyle = dataGridViewCellStyle1;
            this.list_Form_rol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_Form_rol.Location = new System.Drawing.Point(51, 254);
            this.list_Form_rol.Name = "list_Form_rol";
            this.list_Form_rol.ReadOnly = true;
            this.list_Form_rol.RowHeadersWidth = 30;
            this.list_Form_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_Form_rol.ShowEditingIcon = false;
            this.list_Form_rol.Size = new System.Drawing.Size(357, 179);
            this.list_Form_rol.TabIndex = 86;
            this.list_Form_rol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_Form_rol_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(110, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 85;
            this.label2.Text = "Forms Roles";
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(51, 453);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 37);
            this.Atras.TabIndex = 91;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Forms_Rol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 555);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Forms);
            this.Controls.Add(this.delete_Forms_rol);
            this.Controls.Add(this.add_Forms_Rol);
            this.Controls.Add(this.list_Form_rol);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forms_Rol2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms_Rol2";
            this.Load += new System.EventHandler(this.Forms_Rol2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_Form_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atras;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Forms;
        public System.Windows.Forms.Button delete_Forms_rol;
        public System.Windows.Forms.Button add_Forms_Rol;
        public System.Windows.Forms.DataGridView list_Form_rol;
        public System.Windows.Forms.Label label2;
    }
}