namespace FormsApp
{
    partial class MasDeUnRol
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
            this.Atras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Atras
            // 
            this.Atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Atras.Image = global::FormsApp.Properties.Resources.Webp_net_resizeimage__15_;
            this.Atras.Location = new System.Drawing.Point(77, 278);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(100, 41);
            this.Atras.TabIndex = 82;
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 237);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // MasDeUnRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Atras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasDeUnRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasDeUnRol";
            this.Load += new System.EventHandler(this.MasDeUnRol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}