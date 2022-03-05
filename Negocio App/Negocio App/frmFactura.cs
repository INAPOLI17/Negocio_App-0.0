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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        Conexión factura = new Conexión();
        public int codigocli = 0;
        int codifac = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void actualizardgv()
        {
            dgvfact.DataSource = null;
            dgvfact.DataSource = factura.consulta_Mos("SELECT DE.Cod_Det AS [LIST],DE.Cod_Pro AS [CODIGO PRO],DE.Can_Pro AS [CANTIDAD], DE.Nom_Pro AS [PRODUCTO], PR.Pre_Ven AS [PRECIO], DE.Can_Pro*PR.Pre_Ven AS TOTAL FROM Detalle AS DE INNER JOIN Producto AS [PR] ON DE.Cod_Pro=PR.Cod_Pro  WHERE DE.Cod_Fac = "+codifac);
            int total = 0;
            foreach (DataGridViewRow row in dgvfact.Rows)
            {
                total += int.Parse(row.Cells[5].Value.ToString());
            }
            txt_total.Text = total.ToString();
        }
    

        private void frmFactura_Load(object sender, EventArgs e)
        {
       
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            button1.Enabled = false;
            groupBox1.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_newcli_Click(object sender, EventArgs e)
        {
            
            //dgvfact.DataSource = factura.consulta_Mos("SELECT DE.Cod_Pro AS [CODIGO PRO],DE.Can_Pro AS [CANTIDAD], DE.Nom_Pro AS [PRODUCTO], PR.Pre_Ven AS [PRECIO], DE.Can_Pro*PR.Pre_Ven AS [TOTAL] FROM Detalle AS DE INNER JOIN Producto AS [PR] ON DE.Cod_Pro=PR.Cod_Pro WHERE DE.Cod_Fac = "+codifac);


            if (radioButton1.Checked == true)
            {
                factura.newfact(codigocli, "Contado");

            }
            else
            {
                factura.newfact(codigocli, "Crédito");
            }

            codifac = factura.buscarfact();
            btn_newfact.Enabled = false;
            actualizardgv();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Visible = true;
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string apellido;
            string codigo;
            string nombre;
            string cadena = "SELECT Ape_Cli, Cod_Cli,Nom_Cli FROM Cliente WHERE Nom_Cli LIKE '%" + txt_nom.Text+"%'";
            factura.buscar(cadena, out apellido, out codigo,out  nombre) ;
            if (codigo == "NULL")
            {
                MessageBox.Show("El cliente no se encuentra registrado en la base de datos, su factura solo puede ser al contado");
                radioButton1.Visible = true;
                codigocli = Convert.ToInt32(-1);
            }
            else
            {
                codigocli = int.Parse(codigo);
                txt_nom.Text = nombre;
                txt_ape.Text = apellido;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }

            button1.Enabled = true;
            
            
           

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmPrincipal newpri = new frmPrincipal();
            newpri.Visible = true;
            this.Close();
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button2.Focus();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizardgv();
        }

        private void bNTELIMINAR_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(dgvfact.SelectedCells[0].Value.ToString());
            actualizardgv();
            factura.Deletedet(cod);
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txt_nom.Clear();
            txt_ape.Clear();
            txt_total.Clear();
            dgvfact.DataSource = null;
            btn_newfact.Enabled = true;
            codifac = 0;


        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALLFACT facturas = new ALLFACT();
            facturas.Visible = true;



        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = codifac.ToString();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvfact.Rows)
            {
                total += int.Parse(row.Cells[5].Value.ToString());
            }
            txt_total.Text = total.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            
           
            int total = 0;
            foreach (DataGridViewRow row in dgvfact.Rows)
            {
                total += int.Parse(row.Cells[5].Value.ToString());
            }
            txt_total.Text = total.ToString();

            factura.cerrarfac(total, codifac);

        }
    }
}
