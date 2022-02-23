using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class C_Sucursal
    {
        D_Sucursales func = new D_Sucursales();

        public DataTable lista_Sucursales(Sucursal suc)
        {
            return func.MostrarSucursales(suc);
        }

        public string mantenimientoSucursales(Sucursal suc)
        {
            return func.mantenimmiento_sucursales(suc);
        }

    }
}
