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
    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        Conexión productos = new Conexión();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvpro.DataSource = productos.consulta_Mos("SELECT Cod_Pro AS [CÓDIGO], Nom_Pro AS [NOMBRE], Dis_Pro AS [DISTRIBUIDOR], Pre_Ven AS [PRECIO], Can_Pro AS [CANTIDAD], Fec_Com AS [FECHA DE COMPRA] FROM Producto");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvpro.DataSource = productos.consulta_Mos("SELECT Cod_Pro AS [CÓDIGO], Nom_Pro AS [NOMBRE], Dis_Pro AS [DISTRIBUIDOR], Pre_Ven AS [PRECIO], Can_Pro AS [CANTIDAD], Fec_Com AS [FECHA DE COMPRA] FROM Producto WHERE Nom_Pro LIKE '%"+TXTBUS.Text+"%'");
        }

        private void TXTBUS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXTBUS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnbuscar_Click(sender, e);

            }
        }

        private void dgvpro_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            DatosFactura newfact = new DatosFactura();
            newfact.cantidad = Convert.ToInt32(dgvpro.SelectedCells[0].Value.ToString());
            newfact.nombrepro = dgvpro.SelectedCells[1].Value.ToString();
            newfact.total = int.Parse(dgvpro.SelectedCells[3].Value.ToString()) * int.Parse(dgvpro.SelectedCells[4].Value.ToString());
            MessageBox.*/

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigofactu = 0;
              codigofactu = productos.buscarfact();
                DatosFactura newPro = new DatosFactura();
                newPro.codigofact = codigofactu;
                newPro.cantidad = int.Parse(txt_can.Text);
                newPro.CODproducto = int.Parse(dgvpro.SelectedCells[0].Value.ToString());
                newPro.nombrepro = dgvpro.SelectedCells[1].Value.ToString();
                newPro.total = int.Parse(dgvpro.SelectedCells[3].Value.ToString()) * int.Parse(txt_can.Text);

                productos.InsertFact(newPro);
                //MessageBox.Show(codigofactu.ToString());
            }
            catch
            {
                MessageBox.Show("Debes dar doble click sobre el indicador del producto");
            }

            
        }
    }
}
