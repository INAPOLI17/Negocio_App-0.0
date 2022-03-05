using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Negocio_App
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPro_Click_1(object sender, EventArgs e)
        {
            frmProductos pro = new frmProductos();
            pro.Visible = true;
            this.Visible = false;
        }

        private void btnCuentas_Click_1(object sender, EventArgs e)
        {
            frmPendientes pen = new frmPendientes();
            pen.Visible = true;
            this.Visible = false;
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            frmFactura fact = new frmFactura();
            fact.Visible = true;
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fORMULACUADRÁTICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formula = new Form1();
            formula.Visible = true;
            this.Close();
        }

    }
}
