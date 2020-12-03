using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDatos
{
    public class ClaseDatosEnvioResumenCarga
    {
        public string NRO_IDENT_PART { get; set; }
        public string COD_PART { get; set; }
        public string Transaccion { get; set; }
        public string TransaccionPadre { get; set; }
        public string NombreArchivo { get; set; }
    }
}
