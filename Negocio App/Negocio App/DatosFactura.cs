using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_App
{
    public class DatosFactura
    {
        public int codigofact { get; set; }
        public int cantidad { get; set; }
        public int CODproducto { get; set; }

        public string nombrepro { get; set; }
        
        public int total { get; set; }

        //public DateTime fecha = DateTime.Today;

    }
}
