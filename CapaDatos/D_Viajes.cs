using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Configuration;

namespace CapaDatos
{
    public class D_Viajes
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable lista(Viaje obj)
        {
            DataTable dt;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ZEMOG_mostrarviajesZemog", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechainicio", obj.fechaInicial);
                cmd.Parameters.AddWithValue("@fechafinal",obj.fechafinal);
                cmd.Parameters.AddWithValue("@buscar", obj.buscardor);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();

                adapter.Fill(dt);



            }
            catch (Exception)
            {

                dt = null;
            }finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
