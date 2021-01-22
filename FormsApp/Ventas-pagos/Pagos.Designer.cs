namespace NS_WinFormsApps.Ventas_pagos
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEfectivo = new System.Windows.Forms.RadioButton();
            this.radMaster = new System.Windows.Forms.RadioButton();
            this.radVisa = new System.Windows.Forms.RadioButton();
            this.boxEfectivo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnEnterar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb100 = new System.Windows.Forms.PictureBox();
            this.pb50 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.boxEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(417, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar pago";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEmitir
            // 
            this.btnEmitir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.Location = new System.Drawing.Point(265, 470);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(137, 34);
            this.btnEmitir.TabIndex = 13;
            this.btnEmitir.Text = "Emitir Comprobante";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtComprobante);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 106);
            this.panel1.TabIndex = 14;
            // 
            // txtComprobante
            // 
            this.txtComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.txtComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComprobante.Location = new System.Drawing.Point(416, 46);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.Size = new System.Drawing.Size(188, 15);
            this.txtComprobante.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comprobante";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Location = new System.Drawing.Point(72, 44);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(188, 15);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEfectivo);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.radMaster);
            this.groupBox1.Controls.Add(this.radVisa);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 295);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elejir método de pago";
            // 
            // radEfectivo
            // 
            this.radEfectivo.AutoSize = true;
            this.radEfectivo.Location = new System.Drawing.Point(21, 236);
            this.radEfectivo.Name = "radEfectivo";
            this.radEfectivo.Size = new System.Drawing.Size(14, 13);
            this.radEfectivo.TabIndex = 17;
            this.radEfectivo.TabStop = true;
            this.radEfectivo.UseVisualStyleBackColor = true;
            this.radEfectivo.CheckedChanged += new System.EventHandler(this.radEfectivo_CheckedChanged);
            // 
            // radMaster
            // 
            this.radMaster.AutoSize = true;
            this.radMaster.Location = new System.Drawing.Point(21, 146);
            this.radMaster.Name = "radMaster";
            this.radMaster.Size = new System.Drawing.Size(14, 13);
            this.radMaster.TabIndex = 15;
            this.radMaster.TabStop = true;
            this.radMaster.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            this.radVisa.AutoSize = true;
            this.radVisa.Location = new System.Drawing.Point(21, 61);
            this.radVisa.Name = "radVisa";
            this.radVisa.Size = new System.Drawing.Size(14, 13);
            this.radVisa.TabIndex = 14;
            this.radVisa.TabStop = true;
            this.radVisa.UseVisualStyleBackColor = true;
            // 
            // boxEfectivo
            // 
            this.boxEfectivo.Controls.Add(this.label5);
            this.boxEfectivo.Controls.Add(this.txtVuelto);
            this.boxEfectivo.Controls.Add(this.label4);
            this.boxEfectivo.Controls.Add(this.pb100);
            this.boxEfectivo.Controls.Add(this.pb50);
            this.boxEfectivo.Controls.Add(this.pb20);
            this.boxEfectivo.Controls.Add(this.pb10);
            this.boxEfectivo.Controls.Add(this.txtMonto);
            this.boxEfectivo.Controls.Add(this.btnEnterar);
            this.boxEfectivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEfectivo.Location = new System.Drawing.Point(244, 235);
            this.boxEfectivo.Name = "boxEfectivo";
            this.boxEfectivo.Size = new System.Drawing.Size(503, 204);
            this.boxEfectivo.TabIndex = 16;
            this.boxEfectivo.TabStop = false;
            this.boxEfectivo.Text = "Pago de efectivo";
            this.boxEfectivo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vuelto";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Location = new System.Drawing.Point(339, 103);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(142, 22);
            this.txtVuelto.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto Efectivo";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(340, 47);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(142, 22);
            this.txtMonto.TabIndex = 11;
            this.txtMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnEnterar
            // 
            this.btnEnterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterar.Location = new System.Drawing.Point(340, 136);
            this.btnEnterar.Name = "btnEnterar";
            this.btnEnterar.Size = new System.Drawing.Size(141, 52);
            this.btnEnterar.TabIndex = 10;
            this.btnEnterar.Text = "Enterar Efectivo";
            this.btnEnterar.UseVisualStyleBackColor = true;
            this.btnEnterar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(475, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(188, 33);
            this.txtTotal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total a Pagar:";
            // 
            // pb100
            // 
            this.pb100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb100.Image = global::FormsApp.Properties.Resources._1001;
            this.pb100.Location = new System.Drawing.Point(172, 105);
            this.pb100.Name = "pb100";
            this.pb100.Size = new System.Drawing.Size(150, 80);
            this.pb100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb100.TabIndex = 15;
            this.pb100.TabStop = false;
            this.pb100.Click += new System.EventHandler(this.pb100_Click);
            // 
            // pb50
            // 
            this.pb50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb50.Image = global::FormsApp.Properties.Resources._50;
            this.pb50.Location = new System.Drawing.Point(21, 105);
            this.pb50.Name = "pb50";
            this.pb50.Size = new System.Drawing.Size(150, 80);
            this.pb50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb50.TabIndex = 14;
            this.pb50.TabStop = false;
            this.pb50.Click += new System.EventHandler(this.pb50_Click);
            // 
            // pb20
            // 
            this.pb20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb20.Image = global::FormsApp.Properties.Resources._20;
            this.pb20.Location = new System.Drawing.Point(172, 26);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(150, 80);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb20.TabIndex = 13;
            this.pb20.TabStop = false;
            this.pb20.Click += new System.EventHandler(this.pb20_Click);
            // 
            // pb10
            // 
            this.pb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb10.Image = global::FormsApp.Properties.Resources._10;
            this.pb10.Location = new System.Drawing.Point(21, 25);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(150, 80);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb10.TabIndex = 12;
            this.pb10.TabStop = false;
            this.pb10.Click += new System.EventHandler(this.pb10_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FormsApp.Properties.Resources._100;
            this.pictureBox7.Location = new System.Drawing.Point(41, 209);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 70);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(41, 118);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FormsApp.Properties.Resources.Visa;
            this.pictureBox5.Location = new System.Drawing.Point(41, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // Pagos
            // 
            this.AcceptButton = this.btnEmitir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(759, 542);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxEfectivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.boxEfectivo.ResumeLayout(false);
            this.boxEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMaster;
        private System.Windows.Forms.RadioButton radVisa;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton radEfectivo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox boxEfectivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb100;
        private System.Windows.Forms.PictureBox pb50;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnEnterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
    }
}