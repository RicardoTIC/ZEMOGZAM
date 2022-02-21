using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class C_Convenios
    {
        
       D_Convenios func = new D_Convenios();

        public List<Convenios> lista_Viajes(Convenios convenio)
        {
            return func.lista(convenio);
        }

        public List<Sucursal> listaSucursales()
        {
            return func.listaSucursales();
        }


        public DataTable lista_Convenios(Convenios con)
        {
            return func.showData(con);
        }

        public DataTable cargarComboBox()
        {
            return func.CargarComboBox();
        }


    }
}
