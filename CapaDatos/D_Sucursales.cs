using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using System.Configuration;


namespace CapaDatos
{
    public class D_Sucursales
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable MostrarSucursales(Sucursal obj)
        {

            DataTable dt;
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_ZEMOG_mantenimiento_sucursal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", obj.accion);
            cmd.Parameters.AddWithValue("@buscador", obj.buscador);
            cmd.Parameters.AddWithValue("@costoPorEquipo", obj.costoPorEquipo);
            cmd.Parameters.AddWithValue("@presupuesto", obj.presupuesto);
            cmd.Parameters.AddWithValue("@numeroUnidades", obj.numeroUnidades);
            cmd.Parameters.AddWithValue("@sucursal", obj.nombrecorto);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            con.Close();
            return dt;


        }

        public string mantenimmiento_sucursales(Sucursal obj)
        {
            string mensaje = "";
            int filasAfectadas = 0;


            con.Open();

            SqlCommand cmd = new SqlCommand("sp_ZEMOG_mantenimiento_sucursal", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accion", obj.accion);
                cmd.Parameters.AddWithValue("@buscador", obj.buscador);
                cmd.Parameters.AddWithValue("@costoPorEquipo", obj.costoPorEquipo);
                cmd.Parameters.AddWithValue("@presupuesto", obj.presupuesto);
                cmd.Parameters.AddWithValue("@numeroUnidades", obj.numeroUnidades);
                cmd.Parameters.AddWithValue("@sucursal", obj.nombrecorto);

                

                if (obj.accion == 2) // eliminar
                {
                    mensaje = "Se eliminaron correctamente los registros";
                }
                else if (obj.accion == 3 ) // actualizar
                {
                    mensaje = "Se actualizaron correctamente los registros";
                }
                else if (obj.accion == 4)
                {
                    mensaje = "Insertando registros";
                }
                else
                {
                    mensaje = "No se realizo ninguna operacion";
                }


                filasAfectadas = cmd.ExecuteNonQuery();
                con.Close();

            if (filasAfectadas <= 0)
            {
                mensaje = "No se realizo ninguna operacion";
            }

            return mensaje;
        }
    } 
    
}
