namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_rol = new System.Windows.Forms.RichTextBox();
            this.dataGrid_Roles = new System.Windows.Forms.DataGridView();
            this.add_Rol = new System.Windows.Forms.Button();
            this.delete_rol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(99, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // name_rol
            // 
            this.name_rol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_rol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_rol.Location = new System.Drawing.Point(103, 78);
            this.name_rol.Multiline = false;
            this.name_rol.Name = "name_rol";
            this.name_rol.Size = new System.Drawing.Size(153, 34);
            this.name_rol.TabIndex = 19;
            this.name_rol.Text = "";
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
            this.dataGrid_Roles.Location = new System.Drawing.Point(43, 201);
            this.dataGrid_Roles.Name = "dataGrid_Roles";
            this.dataGrid_Roles.ReadOnly = true;
            this.dataGrid_Roles.RowHeadersWidth = 30;
            this.dataGrid_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Roles.ShowEditingIcon = false;
            this.dataGrid_Roles.Size = new System.Drawing.Size(213, 136);
            this.dataGrid_Roles.TabIndex = 21;
            this.dataGrid_Roles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Roles_CellClick);
            // 
            // add_Rol
            // 
            this.add_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Rol.Location = new System.Drawing.Point(43, 155);
            this.add_Rol.Name = "add_Rol";
            this.add_Rol.Size = new System.Drawing.Size(89, 28);
            this.add_Rol.TabIndex = 22;
            this.add_Rol.Text = "add ";
            this.add_Rol.UseVisualStyleBackColor = true;
            this.add_Rol.Click += new System.EventHandler(this.add_Rol_Click);
            // 
            // delete_rol
            // 
            this.delete_rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_rol.Location = new System.Drawing.Point(152, 155);
            this.delete_rol.Name = "delete_rol";
            this.delete_rol.Size = new System.Drawing.Size(89, 28);
            this.delete_rol.TabIndex = 24;
            this.delete_rol.Text = "delete";
            this.delete_rol.UseVisualStyleBackColor = true;
            this.delete_rol.Click += new System.EventHandler(this.delete_rol_Click);
            // 
            // Creacion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_rol);
            this.Controls.Add(this.add_Rol);
            this.Controls.Add(this.dataGrid_Roles);
            this.Controls.Add(this.name_rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Creacion_Rol";
            this.Size = new System.Drawing.Size(370, 489);
            this.Load += new System.EventHandler(this.Creacion_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_rol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox name_rol;
        public System.Windows.Forms.DataGridView dataGrid_Roles;
        public System.Windows.Forms.Button add_Rol;
    }
}
