namespace Negocio_App
{
    partial class InserPro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_preven = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txt_can = new System.Windows.Forms.TextBox();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.nom_Pro = new System.Windows.Forms.TextBox();
            this.cod_PRO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNLIM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNLIM);
            this.groupBox1.Controls.Add(this.txt_preven);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_can);
            this.groupBox1.Controls.Add(this.txt_pre);
            this.groupBox1.Controls.Add(this.txt_dis);
            this.groupBox1.Controls.Add(this.nom_Pro);
            this.groupBox1.Controls.Add(this.cod_PRO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_preven
            // 
            this.txt_preven.Location = new System.Drawing.Point(212, 308);
            this.txt_preven.Name = "txt_preven";
            this.txt_preven.Size = new System.Drawing.Size(149, 29);
            this.txt_preven.TabIndex = 18;
            this.txt_preven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_preven_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio Venta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnGuardar.Location = new System.Drawing.Point(0, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_can
            // 
            this.txt_can.Location = new System.Drawing.Point(212, 252);
            this.txt_can.Name = "txt_can";
            this.txt_can.Size = new System.Drawing.Size(149, 29);
            this.txt_can.TabIndex = 15;
            this.txt_can.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_can_KeyPress);
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(212, 196);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(149, 29);
            this.txt_pre.TabIndex = 14;
            this.txt_pre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pre_KeyPress);
            // 
            // txt_dis
            // 
            this.txt_dis.Location = new System.Drawing.Point(212, 140);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(230, 29);
            this.txt_dis.TabIndex = 13;
            this.txt_dis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dis_KeyPress);
            // 
            // nom_Pro
            // 
            this.nom_Pro.Location = new System.Drawing.Point(212, 87);
            this.nom_Pro.Name = "nom_Pro";
            this.nom_Pro.Size = new System.Drawing.Size(230, 29);
            this.nom_Pro.TabIndex = 7;
            this.nom_Pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_Pro_KeyPress);
            // 
            // cod_PRO
            // 
            this.cod_PRO.Location = new System.Drawing.Point(212, 42);
            this.cod_PRO.Name = "cod_PRO";
            this.cod_PRO.Size = new System.Drawing.Size(230, 29);
            this.cod_PRO.TabIndex = 6;
            this.cod_PRO.TextChanged += new System.EventHandler(this.cod_PRO_TextChanged);
            this.cod_PRO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_PRO_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distribuidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNLIM
            // 
            this.BTNLIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.BTNLIM.Location = new System.Drawing.Point(451, 367);
            this.BTNLIM.Name = "BTNLIM";
            this.BTNLIM.Size = new System.Drawing.Size(120, 36);
            this.BTNLIM.TabIndex = 19;
            this.BTNLIM.Text = "Limpiar";
            this.BTNLIM.UseVisualStyleBackColor = false;
            this.BTNLIM.Click += new System.EventHandler(this.BTNLIM_Click);
            // 
            // InserPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(608, 439);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InserPro";
            this.Text = "InserPro";
            this.Load += new System.EventHandler(this.InserPro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_Pro;
        private System.Windows.Forms.TextBox cod_PRO;
        private System.Windows.Forms.TextBox txt_can;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txt_preven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNLIM;
    }
}