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
            this.btn_insUsr = new System.Windows.Forms.Button();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_usrNick = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbl_nomUsr = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbl_apPat = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_confirmarPass = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_ruc = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_nickUsr = new System.Windows.Forms.Label();
            this.lbl_apMat = new System.Windows.Forms.Label();
            this.cb_verRolesUsr = new System.Windows.Forms.ComboBox();
            this.lbl_VerRolUsr = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl_tlf = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_updUsr = new System.Windows.Forms.Button();
            this.btn_borrarUsr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_insUsr
            // 
            this.btn_insUsr.Location = new System.Drawing.Point(168, 192);
            this.btn_insUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insUsr.Name = "btn_insUsr";
            this.btn_insUsr.Size = new System.Drawing.Size(86, 25);
            this.btn_insUsr.TabIndex = 0;
            this.btn_insUsr.Text = "Añadir";
            this.btn_insUsr.UseVisualStyleBackColor = true;
            this.btn_insUsr.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(8, 119);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "DNI:";
            // 
            // txt_usrNick
            // 
            this.txt_usrNick.Location = new System.Drawing.Point(114, 43);
            this.txt_usrNick.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrNick.Name = "txt_usrNick";
            this.txt_usrNick.Size = new System.Drawing.Size(115, 20);
            this.txt_usrNick.TabIndex = 2;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(8, 71);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(37, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(114, 116);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(115, 20);
            this.txtClave.TabIndex = 2;
            // 
            // lbl_nomUsr
            // 
            this.lbl_nomUsr.AutoSize = true;
            this.lbl_nomUsr.Location = new System.Drawing.Point(242, 20);
            this.lbl_nomUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nomUsr.Name = "lbl_nomUsr";
            this.lbl_nomUsr.Size = new System.Drawing.Size(52, 13);
            this.lbl_nomUsr.TabIndex = 1;
            this.lbl_nomUsr.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(322, 17);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(263, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // lbl_apPat
            // 
            this.lbl_apPat.AutoSize = true;
            this.lbl_apPat.Location = new System.Drawing.Point(242, 46);
            this.lbl_apPat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apPat.Name = "lbl_apPat";
            this.lbl_apPat.Size = new System.Drawing.Size(66, 13);
            this.lbl_apPat.TabIndex = 1;
            this.lbl_apPat.Text = "Ap. Paterno:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(322, 43);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(263, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(242, 96);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.lbl_tlf);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.lbl_confirmarPass);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.lbl_ruc);
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_nickUsr);
            this.groupBox1.Controls.Add(this.txt_usrNick);
            this.groupBox1.Controls.Add(this.lbl_apMat);
            this.groupBox1.Controls.Add(this.cb_verRolesUsr);
            this.groupBox1.Controls.Add(this.lbl_VerRolUsr);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_pass);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.lbl_nomUsr);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lbl_apPat);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 92);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lbl_confirmarPass
            // 
            this.lbl_confirmarPass.AutoSize = true;
            this.lbl_confirmarPass.Location = new System.Drawing.Point(8, 95);
            this.lbl_confirmarPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_confirmarPass.Name = "lbl_confirmarPass";
            this.lbl_confirmarPass.Size = new System.Drawing.Size(84, 13);
            this.lbl_confirmarPass.TabIndex = 10;
            this.lbl_confirmarPass.Text = "Confirmar Clave:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 140);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 9;
            // 
            // lbl_ruc
            // 
            this.lbl_ruc.AutoSize = true;
            this.lbl_ruc.Location = new System.Drawing.Point(8, 143);
            this.lbl_ruc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ruc.Name = "lbl_ruc";
            this.lbl_ruc.Size = new System.Drawing.Size(33, 13);
            this.lbl_ruc.TabIndex = 8;
            this.lbl_ruc.Text = "RUC:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 68);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lbl_nickUsr
            // 
            this.lbl_nickUsr.AutoSize = true;
            this.lbl_nickUsr.Location = new System.Drawing.Point(8, 46);
            this.lbl_nickUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nickUsr.Name = "lbl_nickUsr";
            this.lbl_nickUsr.Size = new System.Drawing.Size(71, 13);
            this.lbl_nickUsr.TabIndex = 5;
            this.lbl_nickUsr.Text = "Nick Usuario:";
            // 
            // lbl_apMat
            // 
            this.lbl_apMat.AutoSize = true;
            this.lbl_apMat.Location = new System.Drawing.Point(242, 71);
            this.lbl_apMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apMat.Name = "lbl_apMat";
            this.lbl_apMat.Size = new System.Drawing.Size(68, 13);
            this.lbl_apMat.TabIndex = 6;
            this.lbl_apMat.Text = "Ap. Materno:";
            // 
            // cb_verRolesUsr
            // 
            this.cb_verRolesUsr.FormattingEnabled = true;
            this.cb_verRolesUsr.Location = new System.Drawing.Point(114, 17);
            this.cb_verRolesUsr.Name = "cb_verRolesUsr";
            this.cb_verRolesUsr.Size = new System.Drawing.Size(115, 21);
            this.cb_verRolesUsr.TabIndex = 5;
            // 
            // lbl_VerRolUsr
            // 
            this.lbl_VerRolUsr.AutoSize = true;
            this.lbl_VerRolUsr.Location = new System.Drawing.Point(8, 20);
            this.lbl_VerRolUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VerRolUsr.Name = "lbl_VerRolUsr";
            this.lbl_VerRolUsr.Size = new System.Drawing.Size(101, 13);
            this.lbl_VerRolUsr.TabIndex = 4;
            this.lbl_VerRolUsr.Text = "Ver Rol(es) Usuario:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 137);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(322, 116);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(263, 20);
            this.textBox6.TabIndex = 13;
            // 
            // lbl_tlf
            // 
            this.lbl_tlf.AutoSize = true;
            this.lbl_tlf.Location = new System.Drawing.Point(242, 119);
            this.lbl_tlf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tlf.Name = "lbl_tlf";
            this.lbl_tlf.Size = new System.Drawing.Size(52, 13);
            this.lbl_tlf.TabIndex = 12;
            this.lbl_tlf.Text = "Teléfono:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(322, 140);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(263, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dirección:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_borrarUsr);
            this.groupBox2.Controls.Add(this.btn_updUsr);
            this.groupBox2.Controls.Add(this.btn_insUsr);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(5, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 220);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // btn_updUsr
            // 
            this.btn_updUsr.Location = new System.Drawing.Point(308, 192);
            this.btn_updUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updUsr.Name = "btn_updUsr";
            this.btn_updUsr.Size = new System.Drawing.Size(81, 25);
            this.btn_updUsr.TabIndex = 1;
            this.btn_updUsr.Text = "Actualizar";
            this.btn_updUsr.UseVisualStyleBackColor = true;
            // 
            // btn_borrarUsr
            // 
            this.btn_borrarUsr.Location = new System.Drawing.Point(455, 192);
            this.btn_borrarUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_borrarUsr.Name = "btn_borrarUsr";
            this.btn_borrarUsr.Size = new System.Drawing.Size(86, 25);
            this.btn_borrarUsr.TabIndex = 6;
            this.btn_borrarUsr.Text = "Eliminar";
            this.btn_borrarUsr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Usuario por nick, dni, o nombres:";
            // 
            // textBox8
            // 
            this.textBox8.AccessibleDescription = "df";
            this.textBox8.AccessibleName = "ssd";
            this.textBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox8.Location = new System.Drawing.Point(210, 25);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(219, 20);
            this.textBox8.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 22);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 25);
            this.button3.TabIndex = 18;
            this.button3.Text = "Borrar Filtro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmUsrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
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

        private System.Windows.Forms.Button btn_insUsr;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_usrNick;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbl_nomUsr;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbl_apPat;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_confirmarPass;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_ruc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_nickUsr;
        private System.Windows.Forms.Label lbl_apMat;
        private System.Windows.Forms.ComboBox cb_verRolesUsr;
        private System.Windows.Forms.Label lbl_VerRolUsr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl_tlf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrarUsr;
        private System.Windows.Forms.Button btn_updUsr;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

