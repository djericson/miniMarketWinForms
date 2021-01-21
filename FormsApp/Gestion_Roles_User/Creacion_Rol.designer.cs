namespace FormsApp
{
    partial class Creacion_Rol
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
            this.delete_rol = new System.Windows.Forms.Button();
            this.add_Rol = new System.Windows.Forms.Button();
            this.dataGrid_Roles = new System.Windows.Forms.DataGridView();
            this.name_rol = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_rol
            // 
            this.delete_rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_rol.Location = new System.Drawing.Point(181, 174);
            this.delete_rol.Name = "delete_rol";
            this.delete_rol.Size = new System.Drawing.Size(89, 28);
            this.delete_rol.TabIndex = 30;
            this.delete_rol.Text = "delete";
            this.delete_rol.UseVisualStyleBackColor = true;
            this.delete_rol.Click += new System.EventHandler(this.delete_rol_Click_1);
            // 
            // add_Rol
            // 
            this.add_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Rol.Location = new System.Drawing.Point(57, 174);
            this.add_Rol.Name = "add_Rol";
            this.add_Rol.Size = new System.Drawing.Size(89, 28);
            this.add_Rol.TabIndex = 29;
            this.add_Rol.Text = "add ";
            this.add_Rol.UseVisualStyleBackColor = true;
            this.add_Rol.Click += new System.EventHandler(this.add_Rol_Click);
            // 
            // dataGrid_Roles
            // 
            this.dataGrid_Roles.AllowUserToAddRows = false;
            this.dataGrid_Roles.AllowUserToDeleteRows = false;
            this.dataGrid_Roles.AllowUserToResizeColumns = false;
            this.dataGrid_Roles.AllowUserToResizeRows = false;
            this.dataGrid_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Roles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid_Roles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_Roles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Roles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Roles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid_Roles.Location = new System.Drawing.Point(57, 226);
            this.dataGrid_Roles.Name = "dataGrid_Roles";
            this.dataGrid_Roles.ReadOnly = true;
            this.dataGrid_Roles.RowHeadersWidth = 30;
            this.dataGrid_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Roles.ShowEditingIcon = false;
            this.dataGrid_Roles.Size = new System.Drawing.Size(213, 181);
            this.dataGrid_Roles.TabIndex = 28;
            this.dataGrid_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Roles_CellClick_1);
            // 
            // name_rol
            // 
            this.name_rol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_rol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_rol.Location = new System.Drawing.Point(117, 97);
            this.name_rol.Multiline = false;
            this.name_rol.Name = "name_rol";
            this.name_rol.Size = new System.Drawing.Size(153, 34);
            this.name_rol.TabIndex = 27;
            this.name_rol.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(113, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Roles";
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(57, 431);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(76, 37);
            this.Atras.TabIndex = 83;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click_1);
            // 
            // Creacion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 521);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.delete_rol);
            this.Controls.Add(this.add_Rol);
            this.Controls.Add(this.dataGrid_Roles);
            this.Controls.Add(this.name_rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Creacion_Rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion_Rol";
            this.Load += new System.EventHandler(this.Creacion_Rol_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_rol;
        public System.Windows.Forms.Button add_Rol;
        public System.Windows.Forms.DataGridView dataGrid_Roles;
        public System.Windows.Forms.RichTextBox name_rol;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Atras;
    }
}