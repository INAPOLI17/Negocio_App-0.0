namespace Negocio_App
{
    partial class ALLFACT
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
            this.dgvfactU = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactU)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfactU
            // 
            this.dgvfactU.AllowUserToAddRows = false;
            this.dgvfactU.AllowUserToDeleteRows = false;
            this.dgvfactU.AllowUserToResizeColumns = false;
            this.dgvfactU.AllowUserToResizeRows = false;
            this.dgvfactU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfactU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfactU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfactU.Location = new System.Drawing.Point(-2, -1);
            this.dgvfactU.Name = "dgvfactU";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.dgvfactU.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfactU.Size = new System.Drawing.Size(960, 547);
            this.dgvfactU.TabIndex = 2;
            this.dgvfactU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfactU_CellContentClick);
            // 
            // ALLFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 547);
            this.Controls.Add(this.dgvfactU);
            this.Name = "ALLFACT";
            this.Text = "ALLFACT";
            this.Load += new System.EventHandler(this.ALLFACT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfactU;
    }
}