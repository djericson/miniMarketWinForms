namespace NS_WinFormsApps.WinForms_AccesosRolesUsrs
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
            this.lbl_nroDoc = new System.Windows.Forms.Label();
            this.txt_usrNick = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.lbl_nomUsr = new System.Windows.Forms.Label();
            this.txt_usrNom = new System.Windows.Forms.TextBox();
            this.lbl_apPat = new System.Windows.Forms.Label();
            this.txt_usrApePat = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_usrEmail = new System.Windows.Forms.TextBox();
            this.grpB_datosUsr = new System.Windows.Forms.GroupBox();
            this.cmb_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_usrRuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usrDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usrTlf = new System.Windows.Forms.TextBox();
            this.lbl_tlf = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.lbl_confirmarPass = new System.Windows.Forms.Label();
            this.lbl_ruc = new System.Windows.Forms.Label();
            this.txt_usrPass = new System.Windows.Forms.TextBox();
            this.txt_usrApeMat = new System.Windows.Forms.TextBox();
            this.lbl_nickUsr = new System.Windows.Forms.Label();
            this.lbl_apMat = new System.Windows.Forms.Label();
            this.cb_verRolesUsr = new System.Windows.Forms.ComboBox();
            this.lbl_VerRolUsr = new System.Windows.Forms.Label();
            this.dgv_listaUsrs = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiarCampos = new System.Windows.Forms.Button();
            this.btn_borrarUsr = new System.Windows.Forms.Button();
            this.btn_updUsr = new System.Windows.Forms.Button();
            this.grpB_datosUsr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaUsrs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_insUsr
            // 
            this.btn_insUsr.Location = new System.Drawing.Point(152, 162);
            this.btn_insUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insUsr.Name = "btn_insUsr";
            this.btn_insUsr.Size = new System.Drawing.Size(86, 25);
            this.btn_insUsr.TabIndex = 0;
            this.btn_insUsr.Text = "Añadir";
            this.btn_insUsr.UseVisualStyleBackColor = true;
            this.btn_insUsr.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lbl_nroDoc
            // 
            this.lbl_nroDoc.AutoSize = true;
            this.lbl_nroDoc.Location = new System.Drawing.Point(8, 143);
            this.lbl_nroDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nroDoc.Name = "lbl_nroDoc";
            this.lbl_nroDoc.Size = new System.Drawing.Size(56, 13);
            this.lbl_nroDoc.TabIndex = 1;
            this.lbl_nroDoc.Text = "Nro. Doc.:";
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
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(114, 140);
            this.txt_nroDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(115, 20);
            this.txt_nroDoc.TabIndex = 2;
            this.txt_nroDoc.TextChanged += new System.EventHandler(this.txt_nroDoc_TextChanged);
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
            // txt_usrNom
            // 
            this.txt_usrNom.Location = new System.Drawing.Point(322, 17);
            this.txt_usrNom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrNom.Name = "txt_usrNom";
            this.txt_usrNom.Size = new System.Drawing.Size(263, 20);
            this.txt_usrNom.TabIndex = 2;
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
            // txt_usrApePat
            // 
            this.txt_usrApePat.Location = new System.Drawing.Point(322, 43);
            this.txt_usrApePat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrApePat.Name = "txt_usrApePat";
            this.txt_usrApePat.Size = new System.Drawing.Size(263, 20);
            this.txt_usrApePat.TabIndex = 2;
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
            // txt_usrEmail
            // 
            this.txt_usrEmail.Location = new System.Drawing.Point(322, 92);
            this.txt_usrEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrEmail.Name = "txt_usrEmail";
            this.txt_usrEmail.Size = new System.Drawing.Size(263, 20);
            this.txt_usrEmail.TabIndex = 3;
            // 
            // grpB_datosUsr
            // 
            this.grpB_datosUsr.Controls.Add(this.cmb_tipoDoc);
            this.grpB_datosUsr.Controls.Add(this.txt_usrRuc);
            this.grpB_datosUsr.Controls.Add(this.label2);
            this.grpB_datosUsr.Controls.Add(this.txt_usrDir);
            this.grpB_datosUsr.Controls.Add(this.label1);
            this.grpB_datosUsr.Controls.Add(this.txt_usrTlf);
            this.grpB_datosUsr.Controls.Add(this.lbl_tlf);
            this.grpB_datosUsr.Controls.Add(this.txt_confirmPass);
            this.grpB_datosUsr.Controls.Add(this.lbl_confirmarPass);
            this.grpB_datosUsr.Controls.Add(this.lbl_ruc);
            this.grpB_datosUsr.Controls.Add(this.lbl_nroDoc);
            this.grpB_datosUsr.Controls.Add(this.txt_usrPass);
            this.grpB_datosUsr.Controls.Add(this.txt_usrApeMat);
            this.grpB_datosUsr.Controls.Add(this.lbl_nickUsr);
            this.grpB_datosUsr.Controls.Add(this.txt_usrNick);
            this.grpB_datosUsr.Controls.Add(this.lbl_apMat);
            this.grpB_datosUsr.Controls.Add(this.cb_verRolesUsr);
            this.grpB_datosUsr.Controls.Add(this.lbl_VerRolUsr);
            this.grpB_datosUsr.Controls.Add(this.txt_usrEmail);
            this.grpB_datosUsr.Controls.Add(this.lbl_pass);
            this.grpB_datosUsr.Controls.Add(this.txt_nroDoc);
            this.grpB_datosUsr.Controls.Add(this.lbl_nomUsr);
            this.grpB_datosUsr.Controls.Add(this.lbl_email);
            this.grpB_datosUsr.Controls.Add(this.txt_usrNom);
            this.grpB_datosUsr.Controls.Add(this.txt_usrApePat);
            this.grpB_datosUsr.Controls.Add(this.lbl_apPat);
            this.grpB_datosUsr.Location = new System.Drawing.Point(5, 6);
            this.grpB_datosUsr.Name = "grpB_datosUsr";
            this.grpB_datosUsr.Size = new System.Drawing.Size(592, 193);
            this.grpB_datosUsr.TabIndex = 4;
            this.grpB_datosUsr.TabStop = false;
            this.grpB_datosUsr.Text = "Datos de Usuario";
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(114, 116);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(115, 21);
            this.cmb_tipoDoc.TabIndex = 18;
            // 
            // txt_usrRuc
            // 
            this.txt_usrRuc.Location = new System.Drawing.Point(114, 164);
            this.txt_usrRuc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrRuc.Name = "txt_usrRuc";
            this.txt_usrRuc.Size = new System.Drawing.Size(115, 20);
            this.txt_usrRuc.TabIndex = 17;
            this.txt_usrRuc.TextChanged += new System.EventHandler(this.txt_usrRuc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "RUC:";
            // 
            // txt_usrDir
            // 
            this.txt_usrDir.Location = new System.Drawing.Point(322, 140);
            this.txt_usrDir.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrDir.Multiline = true;
            this.txt_usrDir.Name = "txt_usrDir";
            this.txt_usrDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_usrDir.Size = new System.Drawing.Size(263, 24);
            this.txt_usrDir.TabIndex = 15;
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
            // txt_usrTlf
            // 
            this.txt_usrTlf.Location = new System.Drawing.Point(322, 116);
            this.txt_usrTlf.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrTlf.Name = "txt_usrTlf";
            this.txt_usrTlf.Size = new System.Drawing.Size(263, 20);
            this.txt_usrTlf.TabIndex = 13;
            this.txt_usrTlf.TextChanged += new System.EventHandler(this.txt_usrTlf_TextChanged);
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
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(114, 92);
            this.txt_confirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(115, 20);
            this.txt_confirmPass.TabIndex = 11;
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
            // lbl_ruc
            // 
            this.lbl_ruc.AutoSize = true;
            this.lbl_ruc.Location = new System.Drawing.Point(8, 119);
            this.lbl_ruc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ruc.Name = "lbl_ruc";
            this.lbl_ruc.Size = new System.Drawing.Size(89, 13);
            this.lbl_ruc.TabIndex = 8;
            this.lbl_ruc.Text = "Tipo Documento:";
            // 
            // txt_usrPass
            // 
            this.txt_usrPass.Location = new System.Drawing.Point(114, 68);
            this.txt_usrPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrPass.Name = "txt_usrPass";
            this.txt_usrPass.Size = new System.Drawing.Size(115, 20);
            this.txt_usrPass.TabIndex = 6;
            // 
            // txt_usrApeMat
            // 
            this.txt_usrApeMat.Location = new System.Drawing.Point(322, 68);
            this.txt_usrApeMat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usrApeMat.Name = "txt_usrApeMat";
            this.txt_usrApeMat.Size = new System.Drawing.Size(263, 20);
            this.txt_usrApeMat.TabIndex = 7;
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
            this.cb_verRolesUsr.Items.AddRange(new object[] {
            "Aun no hay rol(es) asignados\\n,ir a ventana de roles para ello"});
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
            // dgv_listaUsrs
            // 
            this.dgv_listaUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaUsrs.Location = new System.Drawing.Point(6, 40);
            this.dgv_listaUsrs.Name = "dgv_listaUsrs";
            this.dgv_listaUsrs.Size = new System.Drawing.Size(580, 117);
            this.dgv_listaUsrs.TabIndex = 5;
            this.dgv_listaUsrs.DoubleClick += new System.EventHandler(this.dgv_listaUsrs_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiarCampos);
            this.groupBox2.Controls.Add(this.btn_borrarUsr);
            this.groupBox2.Controls.Add(this.btn_updUsr);
            this.groupBox2.Controls.Add(this.btn_insUsr);
            this.groupBox2.Controls.Add(this.dgv_listaUsrs);
            this.groupBox2.Location = new System.Drawing.Point(5, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 197);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // btn_limpiarCampos
            // 
            this.btn_limpiarCampos.Location = new System.Drawing.Point(23, 162);
            this.btn_limpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiarCampos.Name = "btn_limpiarCampos";
            this.btn_limpiarCampos.Size = new System.Drawing.Size(86, 25);
            this.btn_limpiarCampos.TabIndex = 7;
            this.btn_limpiarCampos.Text = "Nuevo";
            this.btn_limpiarCampos.UseVisualStyleBackColor = true;
            this.btn_limpiarCampos.Click += new System.EventHandler(this.btn_limpiarCampos_Click);
            // 
            // btn_borrarUsr
            // 
            this.btn_borrarUsr.Enabled = false;
            this.btn_borrarUsr.Location = new System.Drawing.Point(439, 162);
            this.btn_borrarUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_borrarUsr.Name = "btn_borrarUsr";
            this.btn_borrarUsr.Size = new System.Drawing.Size(86, 25);
            this.btn_borrarUsr.TabIndex = 6;
            this.btn_borrarUsr.Text = "Eliminar";
            this.btn_borrarUsr.UseVisualStyleBackColor = true;
            this.btn_borrarUsr.Click += new System.EventHandler(this.btn_borrarUsr_Click);
            // 
            // btn_updUsr
            // 
            this.btn_updUsr.Location = new System.Drawing.Point(292, 162);
            this.btn_updUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updUsr.Name = "btn_updUsr";
            this.btn_updUsr.Size = new System.Drawing.Size(81, 25);
            this.btn_updUsr.TabIndex = 1;
            this.btn_updUsr.Text = "Actualizar";
            this.btn_updUsr.UseVisualStyleBackColor = true;
            this.btn_updUsr.Click += new System.EventHandler(this.btn_updUsr_Click);
            // 
            // FrmUsrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.grpB_datosUsr);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsrs";
            this.Text = "Gestion de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsrs_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsrs_Load);
            this.grpB_datosUsr.ResumeLayout(false);
            this.grpB_datosUsr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaUsrs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_insUsr;
        private System.Windows.Forms.Label lbl_nroDoc;
        private System.Windows.Forms.TextBox txt_usrNick;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Label lbl_nomUsr;
        private System.Windows.Forms.TextBox txt_usrNom;
        private System.Windows.Forms.Label lbl_apPat;
        private System.Windows.Forms.TextBox txt_usrApePat;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_usrEmail;
        private System.Windows.Forms.GroupBox grpB_datosUsr;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.Label lbl_confirmarPass;
        private System.Windows.Forms.Label lbl_ruc;
        private System.Windows.Forms.TextBox txt_usrPass;
        private System.Windows.Forms.TextBox txt_usrApeMat;
        private System.Windows.Forms.Label lbl_nickUsr;
        private System.Windows.Forms.Label lbl_apMat;
        private System.Windows.Forms.ComboBox cb_verRolesUsr;
        private System.Windows.Forms.Label lbl_VerRolUsr;
        private System.Windows.Forms.DataGridView dgv_listaUsrs;
        private System.Windows.Forms.TextBox txt_usrDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usrTlf;
        private System.Windows.Forms.Label lbl_tlf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrarUsr;
        private System.Windows.Forms.Button btn_updUsr;
        private System.Windows.Forms.Button btn_limpiarCampos;
        private System.Windows.Forms.TextBox txt_usrRuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipoDoc;
    }
}

