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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        Conexión productos = new Conexión();

        Datospro prodsel = new Datospro();

        private void actualizardgv()
        {
            dgv_Producto.DataSource = null;
            dgv_Producto.DataSource = productos.consulta_Mos("SELECT Cod_Pro AS [CÓDIGO], Nom_Pro AS [NOMBRE], Dis_Pro AS [DISTRIBUIDOR], Pre_Ven AS [PRECIO], Can_Pro AS [CANTIDAD], Fec_Com AS [FECHA DE COMPRA] FROM Producto");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            InserPro prod = new InserPro();
            prod.Visible = true;
         
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            InserPro prod = new InserPro();
            prod.llenado(prodsel);
            prod.Visible = true;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgv_Producto.DataSource = productos.consulta_Mos("SELECT Cod_Pro AS [CÓDIGO], Nom_Pro AS [NOMBRE], Dis_Pro AS [DISTRIBUIDOR], Pre_Ven AS [PRECIO], Can_Pro AS [CANTIDAD], Fec_Com AS [FECHA DE COMPRA] FROM Producto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productos.DeletePro(prodsel.codigopro);
            actualizardgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizardgv();
        }

        private void dgv_Producto_DoubleClick(object sender, EventArgs e)
        {
            prodsel.codigopro = Convert.ToInt32(dgv_Producto.SelectedCells[0].Value.ToString());
            prodsel.nombrepro = dgv_Producto.SelectedCells[1].Value.ToString();
            prodsel.distribuidor = dgv_Producto.SelectedCells[2].Value.ToString();
            prodsel.precio =Convert.ToInt32(dgv_Producto.SelectedCells[3].Value.ToString());
            prodsel.cantidad = Convert.ToInt32(dgv_Producto.SelectedCells[4].Value.ToString());



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmPrincipal newpri = new frmPrincipal();
            newpri.Visible = true;
            this.Close();
        }

        private void dgv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
