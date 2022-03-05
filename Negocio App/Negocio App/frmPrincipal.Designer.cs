namespace Negocio_App
{
    partial class frmPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPro.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.White;
            this.btnPro.Location = new System.Drawing.Point(22, 12);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(244, 92);
            this.btnPro.TabIndex = 1;
            this.btnPro.Text = "PRODUCTOS";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click_1);
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuentas.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.Color.White;
            this.btnCuentas.Location = new System.Drawing.Point(340, 12);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(244, 92);
            this.btnCuentas.TabIndex = 2;
            this.btnCuentas.Text = "CUENTAS PENDIENTES";
            this.btnCuentas.UseVisualStyleBackColor = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click_1);
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFact.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.ForeColor = System.Drawing.Color.White;
            this.btnFact.Location = new System.Drawing.Point(661, 12);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(244, 92);
            this.btnFact.TabIndex = 3;
            this.btnFact.Text = "FACTURADOR";
            this.btnFact.UseVisualStyleBackColor = false;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(931, 530);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

