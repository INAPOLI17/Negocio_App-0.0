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
    public partial class InserPro : Form
    {
        public InserPro()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InserPro_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            cod_PRO.Clear();
            nom_Pro.Clear();
            txt_dis.Clear();
            txt_preven.Clear();
            txt_can.Clear();
        }

        public void llenado(Datospro prosel)
        {
            cod_PRO.Text = Convert.ToString(prosel.codigopro);
            nom_Pro.Text = prosel.nombrepro;
            txt_dis.Text = prosel.distribuidor;
            txt_preven.Text = Convert.ToString( prosel.precio);
            txt_can.Text = Convert.ToString(prosel.cantidad);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datospro Newprod = new Datospro();

            Newprod.codigopro = Convert.ToInt32(cod_PRO.Text);
            Newprod.nombrepro = nom_Pro.Text;
            Newprod.distribuidor = txt_dis.Text;
            Newprod.precio = Convert.ToDecimal(txt_pre.Text);
            Newprod.cantidad = Convert.ToInt32(txt_can.Text);
            Newprod.precioven = Convert.ToDecimal(txt_preven.Text);


            Conexión newpro = new Conexión();
            newpro.GuardarPro(Newprod);

            MessageBox.Show("Producto agregado");


        }

        private void cod_PRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void cod_PRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                nom_Pro.Focus();
            }
        }

        private void nom_Pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_dis.Focus();
            }
        }

        private void txt_dis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_pre.Focus();
            }
        }

        private void txt_pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_can.Focus();
            }
        }

        private void txt_can_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_preven.Focus();
            }
        }

        private void txt_preven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void BTNLIM_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
