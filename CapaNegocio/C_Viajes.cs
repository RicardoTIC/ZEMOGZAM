using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Modelo;
using System.Data;
namespace CapaNegocio
{
    public class C_Viajes
    {
        D_Viajes func = new D_Viajes();
        
        public DataTable lista_Viajes(Viaje user)
        {
            return func.lista(user);
        }



    }
}
