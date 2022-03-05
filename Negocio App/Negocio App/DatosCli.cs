using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_App
{
    public class DatosCli
    {
        public int codigocli { get; set; }
        public string nombrecli { get; set; }
        public string apellidocli { get; set; }

        public string direccioncli { get; set; }

        public string telefonocli { get; set; }
        public DateTime fechacli = DateTime.Today;
    }
}
