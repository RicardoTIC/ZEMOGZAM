using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Modelo;

namespace CapaDatos
{
    public class D_Convenios
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
         
        // este metodo solo regresa el id convenio
        public List<Convenios> lista(Convenios obj)
        {
            List<Convenios> listas = new List<Convenios>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ZEMOG_consultar_convenio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoRuta", obj.id_ruta);
                cmd.Parameters.AddWithValue("@CCodigoArea", obj.id_area_zemog);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj.id_convenio = reader.GetInt32(0);
                    obj.Remitente = reader.GetString(5);
                    obj.Destinatario = reader.GetString(7);
                    listas.Add(obj);
                }

            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                listas = null;
            }
            finally
            {
                con.Close();
            }
            return listas;
        }

        public DataTable showData(Convenios obj)
        {
            DataTable dt;
            dt = new DataTable();



            SqlCommand cmd = new SqlCommand("sp_ZEMOG_convenios", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigoArea", obj.id_area_zemog);
            cmd.Parameters.AddWithValue("@NombreRuta", obj.desc_convenio);
                
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            


            adapter.Fill(dt);



            con.Close();
            return dt;


            
        }

        public DataTable CargarComboBox()
        {
            DataTable dt;
            string query;
            query = "select 0 id_area, 'Seleciona la sucursal' as nombrecorto union select id_area, nombrecorto from general_area where nombre != 'SIN ASIGNAR'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
   
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public List<Sucursal> listaSucursales()
        {

            List<Sucursal> listas = new List<Sucursal>();
            
            string query = "";
            Sucursal objeto;
            try
            {
                query = "select * from general_area";
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                objeto = new Sucursal();
                objeto.id_area = 0;
                objeto.nombrecorto = "Selecciona una sucursal";
                listas.Add(objeto); 

                while (reader.Read())
                {
                    objeto = new Sucursal();
                    objeto.id_area = reader.GetInt32(0);
                    objeto.nombrecorto = reader.GetString(19);
                    listas.Add(objeto);
                }

                return listas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return listas = null;
            }
            finally
            {
                con.Close();
            }
            
        }



    }
}
