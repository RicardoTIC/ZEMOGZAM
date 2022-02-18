using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Configuration;

namespace CapaDatos
{
    public class D_Usuario
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        public DataTable lista(Usuario obj)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ZEMOG_mostrar_usuarios_ZAM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", obj.buscador);
                cmd.Parameters.AddWithValue("@clave", obj.password);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(dt);   
            


            }
            catch (Exception)
            {

                dt = null;  
            }
            return dt;
        }
        public bool login(Usuario obj)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("sp_ZEMOG_usuario_contrasena", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", obj.id_usuario);



                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    if (obj.password.Equals(dr.GetString(3)))
                    {
                        obj.id_usuario = dr.GetString(0);
                        obj.id_grupo = dr.GetString(1);
                        obj.nombre = dr.GetString(2);
                        obj.password = dr.GetString(3);

                        return true;
                    }
                    else
                    {
                        Console.WriteLine(dr.GetString(3));
                        return false;
                    }

                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }


        }

    }
}
