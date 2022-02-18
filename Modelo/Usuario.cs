using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {

        /// <summary>
        /// Propiedades
        /// </summary>
        public string id_usuario { get; set; }
        public string password { get; set; }
        public string id_grupo { get; set; }
        public string buscador { get; set; }
        public string nombre { get; set; }

        //Metodo constructor
        public Usuario() { }



    }
}
