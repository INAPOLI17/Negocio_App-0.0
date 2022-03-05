using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_App
{
    public class Datospro
    {
        public int codigopro { get; set; }
        public string nombrepro { get; set; }
        public string distribuidor { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }

        public decimal precioven { get; set; }

        public DateTime fecha = DateTime.Today;
    }
}
