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
    public partial class frmPendientes : Form
    {
        public frmPendientes()
        {
            InitializeComponent();
        }

        Conexión clientes = new Conexión();
        DatosCli climod = new DatosCli();

        private void actualizardgv()
        {
            dgvcli.DataSource = null;
            dgvcli.DataSource = clientes.consulta_Mos("SELECT Cod_Cli AS [CÓDIGO], Nom_Cli AS [NOMBRE], Ape_Cli AS [APELLIDO], Fec_Cli AS [FECHA], Dir_Cli AS [DIRECCIÓN], Tel_Cli AS [TELEFONO] FROM Cliente");
        }

        private void btn_newcli_Click(object sender, EventArgs e)
        {
            insertCli cli = new insertCli();
            cli.llenar(climod);
            cli.Visible = true;

        }

        private void btn_modi_Click(object sender, EventArgs e)
        {
            clientes.DeleteCli(climod.codigocli);
            actualizardgv();
        }

        private void frmPendientes_Load(object sender, EventArgs e)
        {
           dgvcli.DataSource= clientes.consulta_Mos("SELECT Cod_Cli AS [CÓDIGO], Nom_Cli AS [NOMBRE], Ape_Cli AS [APELLIDO], Fec_Cli AS [FECHA], Dir_Cli AS [DIRECCIÓN], Tel_Cli AS [TELEFONO] FROM Cliente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizardgv();
        }

        private void dgvcli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string codigo = dgvcli.SelectedCells[0].Value.ToString();
            climod.codigocli = Convert.ToInt32(codigo);
            climod.nombrecli = dgvcli.SelectedCells[1].Value.ToString();
            climod.apellidocli= dgvcli.SelectedCells[2].Value.ToString();
            climod.direccioncli= dgvcli.SelectedCells[4].Value.ToString();
            climod.telefonocli= dgvcli.SelectedCells[5].Value.ToString();


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmPrincipal newpri = new frmPrincipal();
            newpri.Visible = true;
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgvcli.DataSource=clientes.consulta_Mos("SELECT * FROM Cliente WHERE Nom_Cli LIKE '%" + textBox1.Text+"%'");

        }
    }
}
