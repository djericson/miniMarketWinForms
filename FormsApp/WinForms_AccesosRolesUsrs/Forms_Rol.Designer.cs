namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_Forms_rol = new System.Windows.Forms.Button();
            this.add_Forms_Rol = new System.Windows.Forms.Button();
            this.list_Form_rol = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Forms = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_Form_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_Forms_rol
            // 
            this.delete_Forms_rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_Forms_rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Forms_rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Forms_rol.Location = new System.Drawing.Point(150, 199);
            this.delete_Forms_rol.Name = "delete_Forms_rol";
            this.delete_Forms_rol.Size = new System.Drawing.Size(89, 28);
            this.delete_Forms_rol.TabIndex = 45;
            this.delete_Forms_rol.Text = "delete";
            this.delete_Forms_rol.UseVisualStyleBackColor = true;
            this.delete_Forms_rol.Click += new System.EventHandler(this.delete_Forms_rol_Click);
            // 
            // add_Forms_Rol
            // 
            this.add_Forms_Rol.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_Forms_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Forms_Rol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Forms_Rol.Location = new System.Drawing.Point(38, 199);
            this.add_Forms_Rol.Name = "add_Forms_Rol";
            this.add_Forms_Rol.Size = new System.Drawing.Size(89, 28);
            this.add_Forms_Rol.TabIndex = 44;
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
            this.list_Form_rol.Location = new System.Drawing.Point(38, 249);
            this.list_Form_rol.Name = "list_Form_rol";
            this.list_Form_rol.ReadOnly = true;
            this.list_Form_rol.RowHeadersWidth = 30;
            this.list_Form_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_Form_rol.ShowEditingIcon = false;
            this.list_Form_rol.Size = new System.Drawing.Size(314, 194);
            this.list_Form_rol.TabIndex = 43;
            this.list_Form_rol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_user_rol_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(97, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Forms Roles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Forms";
            // 
            // Forms
            // 
            this.Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Forms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Forms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forms.FormattingEnabled = true;
            this.Forms.Location = new System.Drawing.Point(101, 113);
            this.Forms.Name = "Forms";
            this.Forms.Size = new System.Drawing.Size(132, 25);
            this.Forms.TabIndex = 46;
            // 
            // Forms_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Forms);
            this.Controls.Add(this.delete_Forms_rol);
            this.Controls.Add(this.add_Forms_Rol);
            this.Controls.Add(this.list_Form_rol);
            this.Controls.Add(this.label2);
            this.Name = "Forms_Rol";
            this.Size = new System.Drawing.Size(396, 446);
            this.Load += new System.EventHandler(this.Forms_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_Form_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button delete_Forms_rol;
        public System.Windows.Forms.Button add_Forms_Rol;
        public System.Windows.Forms.DataGridView list_Form_rol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox Forms;
    }
}
