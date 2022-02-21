using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sucursal
    {

        public int id_area { get; set; }
        public string nombre { get; set; }
        public string  direccion { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }  
        public int codePostal { get; set; } 
        public string telefono { get; set; }
        public int fax { get; set; }
        public int areacont { get; set; }
        public int consecutivo_poliza { get; set; }
        public string activa { get; set; }
        public string nombrecorto { get; set; }
        public double presupuesto { get; set; }
        public int costoPorEquipo { get; set; }
        public int numeroUnidades { get; set; } 


    }
}
