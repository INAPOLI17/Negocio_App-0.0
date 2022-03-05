using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Negocio_App
{
    public partial class ALLFACT : Form
    {
        public ALLFACT()
        {
            InitializeComponent();
        }

        Conexión facturas = new Conexión();

        private void ALLFACT_Load(object sender, EventArgs e)
        {
            dgvfactU.DataSource = facturas.consulta_Mos("SELECT FA.Cod_Fac AS [CODIGO], CL.Nom_Cli AS [NOMBRE], CL.Ape_Cli AS [APELLIDO], FA.Tip_Fac AS [TIPO] , FA.Fec_Fac AS [FECHA], FA.Tot_Fac AS [TOTAL] FROM Factura AS [FA] INNER JOIN Cliente AS CL ON CL.Cod_Cli = FA.Cod_Cli");
        }

        private void dgvfactU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
