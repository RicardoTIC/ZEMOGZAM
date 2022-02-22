using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using CapaNegocio;

namespace ZEMOGZAMMODIFICACIONES.Viajes
{
    public partial class frmDetalleViajeRutasConvenios : Form
    {

        C_Convenios convenios = new C_Convenios();
        Convenios con = new Convenios();


        public frmDetalleViajeRutasConvenios(Viaje obj)
        {
            InitializeComponent();
            txtVenta.Text = obj.venta.ToString();
            txtFlete.Text = obj.flete.ToString();

            lblDestino.Text ="Origen " + obj.origen;
            lblOrigen.Text ="Destino " + obj.destino;
            lblIdRuta.Text = obj.id_ruta;
            txtRutas.Text = obj.nombreRuta;
            lblCodigoRuta.Text = obj.codigoArea.ToString();
            con.id_ruta = int.Parse(obj.id_ruta);
            con.id_area_zemog = obj.codigoArea;

            cargaCodigoConvenio();



        }

        void cargaCodigoConvenio()
        {
            try
            {
                foreach (var item in convenios.lista_Viajes(con))
                {
                    txtCodigoConvenio.Text = item.id_convenio.ToString();
                    txtOriginario.Text = item.Destinatario;
                    txtDestinatario.Text = item.Destinatario;
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void frmDetalleViaje_Load(object sender, EventArgs e)
        {

        }
    }
}
