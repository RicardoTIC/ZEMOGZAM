using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Convenios
    {
        public string sucursal { get; set; }
        public string buscardo { get; set; }    
        public int id_convenio { get; set; }
        public int id_ruta { get; set; }
        public string desc_convenio { get; set; }  
        public string id_area { get; set; }
        public int id_remitente { get; set; }
        public string Remitente { get; set; }
        public int id_destinatario { get; set; }    
        public string Destinatario   { get; set; }   
        public int id_cliente { get; set; } 
        public string Cliente { get; set; }    
        public int id_origen { get; set; }  
        public string Origen { get; set; }
        public int id_destino { get; set; }
        public string Destino { get; set; }    
        public string desc_ruta    { get; set; }
        public int id_tipo_operacion  { get; set; }
        public string tipo_operacion { get; set; }
        public string nombreCliente { get; set; }
        public int kms_manual { get; set; }
        public int kms_ruta { get; set; }
        public double monto_factor_s { get; set; }
        public double monto_factor_f { get; set; }
        public double monto_factor_s_MT    { get; set; }
        public double monto_factor_f_MT    { get; set; }
        public int id_area_zemog    { get; set; }
        public double tarifa { get; set; }

    }
}
