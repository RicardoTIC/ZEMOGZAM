using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using CapaDatos;

namespace CapaNegocio
{
    public class C_Usuarios
    {


        D_Usuario func = new D_Usuario();

        public DataTable lista_Usuarios(Usuario user)
        {
            return func.lista(user);
        }

        public bool validacion_usuario(Usuario user)
        {
            return func.login(user);
        }


    }
}
