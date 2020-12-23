namespace App
{
    partial class FrmUsrs
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tlf = new System.Windows.Forms.Label();
            this.tb_tlf = new System.Windows.Forms.TextBox();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_ruc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_rolUsr = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(428, 131);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(62, 25);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nick:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(85, 14);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(115, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 40);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(115, 20);
            this.txtClave.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(306, 14);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(172, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido Pat.:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(306, 40);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(172, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(233, 97);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(306, 94);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(172, 20);
            this.tb_email.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tlf);
            this.groupBox1.Controls.Add(this.tb_tlf);
            this.groupBox1.Controls.Add(this.lbl_dir);
            this.groupBox1.Controls.Add(this.tb_dir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_ruc);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_dni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.cmb_rolUsr);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // lbl_tlf
            // 
            this.lbl_tlf.AutoSize = true;
            this.lbl_tlf.Location = new System.Drawing.Point(520, 43);
            this.lbl_tlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tlf.Name = "lbl_tlf";
            this.lbl_tlf.Size = new System.Drawing.Size(52, 13);
            this.lbl_tlf.TabIndex = 14;
            this.lbl_tlf.Text = "Teléfono:";
            // 
            // tb_tlf
            // 
            this.tb_tlf.Location = new System.Drawing.Point(593, 40);
            this.tb_tlf.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tlf.Name = "tb_tlf";
            this.tb_tlf.Size = new System.Drawing.Size(172, 20);
            this.tb_tlf.TabIndex = 15;
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.Location = new System.Drawing.Point(520, 17);
            this.lbl_dir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(55, 13);
            this.lbl_dir.TabIndex = 12;
            this.lbl_dir.Text = "Dirección:";
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(593, 14);
            this.tb_dir.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(172, 20);
            this.tb_dir.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellido Mat.:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(306, 65);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 11;
            // 
            // lbl_ruc
            // 
            this.lbl_ruc.AutoSize = true;
            this.lbl_ruc.Location = new System.Drawing.Point(16, 122);
            this.lbl_ruc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ruc.Name = "lbl_ruc";
            this.lbl_ruc.Size = new System.Drawing.Size(33, 13);
            this.lbl_ruc.TabIndex = 8;
            this.lbl_ruc.Text = "RUC:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DNI:";
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(85, 94);
            this.tb_dni.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(115, 20);
            this.tb_dni.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rol Usr.:";
            // 
            // cmb_rolUsr
            // 
            this.cmb_rolUsr.FormattingEnabled = true;
            this.cmb_rolUsr.Location = new System.Drawing.Point(85, 65);
            this.cmb_rolUsr.Name = "cmb_rolUsr";
            this.cmb_rolUsr.Size = new System.Drawing.Size(115, 21);
            this.cmb_rolUsr.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 111);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Uusarios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar por:";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleDescription = "d";
            this.textBox4.AccessibleName = "ds";
            this.textBox4.Location = new System.Drawing.Point(82, 13);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmUsrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsrs";
            this.Text = "Gestion de Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_rolUsr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_tlf;
        private System.Windows.Forms.TextBox tb_tlf;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_ruc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}

