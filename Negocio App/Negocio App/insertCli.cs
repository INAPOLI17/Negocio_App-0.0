using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Negocio_App
{
    public partial class insertCli : Form
    {
        public insertCli()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void insertCli_Load(object sender, EventArgs e)
        {
            

        }

        private void limpiar()
        {
            txt_cli.Clear();
            txt_ape.Clear();
            txt_dir.Clear();
            txt_tel.Clear();
        }

        private void txt_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_ape.Focus();
            }
        }

        private void txt_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_dir.Focus();
            }
        }

        private void txt_dir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_tel.Focus();
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
           
        }

        public void llenar(DatosCli clipre)
        {
            txt_cli.Text = clipre.nombrecli;
            txt_ape.Text = clipre.apellidocli;
            txt_dir.Text = clipre.direccioncli;
            txt_tel.Text = clipre.telefonocli;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosCli newcli = new DatosCli();
            newcli.nombrecli = txt_cli.Text;
            newcli.apellidocli = txt_ape.Text;
            newcli.direccioncli = txt_dir.Text;
            newcli.telefonocli = txt_tel.Text;

            Conexión Newcli = new Conexión();
            Newcli.GuardarCli(newcli);

            MessageBox.Show("Cliente agregado");

        }

        private void btnlim_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
