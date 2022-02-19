using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Viaje
    {
        public DateTime fechaInicial { get; set; }
        public DateTime fechafinal { get; set; }
        public string buscardor { get; set; }
        public int numeroViajes { get; set; }
        public int codigoArea { get; set; }
        public string id_unidad { get; set; }
        public DateTime fechaCita { get; set; }
        public DateTime fechaCaptura { get; set; }
        public string remolque1 { get; set; }
        public string remolque2 { get; set; }
        public string dolly { get; set; }
        public string nombreRuta { get; set; }
        public string id_ruta { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int asignacion { get; set; }
        public int totalViatico { get; set; }
        public string sucursal { get; set; }
        public int km { get; set; }
        public string folio { get; set; }
        public string numeroGuia { get; set; }
        public float flete { get; set; }
        public float venta { get; set; }
        public string expedicion { get; set; }
        public string nombreOperador { get; set; }
        public int id_operador { get; set; }
        public string direccion { get; set; }
        public string operacion { get; set; }
        public string estatus { get; set; }
        public string usuarioAlta { get; set; }
        public string tipo_cobro { get; set; }
        public string factura { get; set; }
        public string estatusFactura { get; set; }
        public int horas_transcurridas { get; set; }




    }
}
