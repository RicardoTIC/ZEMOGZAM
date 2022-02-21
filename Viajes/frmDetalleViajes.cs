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
    public partial class frmDetalleViajes : Form
    {

        C_Viajes func = new C_Viajes();
        Viaje viajes = new Viaje();
        public float venta;
        public float tarifa;

        public frmDetalleViajes()
        {
            InitializeComponent();
            txtFechaInicio.Value = new DateTime(2022,01,01);
            txtFechaFinal.Value = new DateTime(2022 ,01 ,01);


        }

        void mostrar(Viaje obj)
        {
            
            ListaDeViajes.DataSource = func.lista_Viajes(obj);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDetalleViajes_Load(object sender, EventArgs e)
        {
            
            toolVenta.ShowAlways = true;

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            viajes.buscardor = txtBuscar.Text;
            viajes.fechaInicial = txtFechaInicio.Value;
            viajes.fechafinal = txtFechaFinal.Value;

            mostrar(viajes);
        }

        private void ListaDeViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = ListaDeViajes.CurrentCell.RowIndex;

            try
            {
                txtNumeroViaje.Text = ListaDeViajes[0, fila].Value.ToString();
                txtCodigoArea.Text = ListaDeViajes[1, fila].Value.ToString();
                txtUnidad.Text = ListaDeViajes[2, fila].Value.ToString();
                txtFechaCita.Text = ListaDeViajes[3, fila].Value.ToString();
                txtFechaCaptura.Text = ListaDeViajes[37, fila].Value.ToString();
                txtRemolque1.Text = ListaDeViajes[5, fila].Value.ToString();
                txtRemolque2.Text = ListaDeViajes[6, fila].Value.ToString();
                txtDolly.Text = ListaDeViajes[7, fila].Value.ToString();
                txtNumbreRuta.Text = ListaDeViajes[9, fila].Value.ToString();
                lblIdRuta.Text = ListaDeViajes[10, fila].Value.ToString();
                txtOrigen.Text = ListaDeViajes[11, fila].Value.ToString();
                txtDestino.Text = ListaDeViajes[12, fila].Value.ToString();
                txtSucursal.Text = ListaDeViajes[17, fila].Value.ToString();
                txtKilometros.Text = ListaDeViajes[19, fila].Value.ToString();
                txtExpedicion.Text = ListaDeViajes[24, fila].Value.ToString();
                txtOperador.Text = ListaDeViajes[27, fila].Value.ToString();
                txtDireccion.Text = ListaDeViajes[36, fila].Value.ToString();
                txtEstatusViaje.Text = ListaDeViajes[41, fila].Value.ToString();
                txtUsuarioAlta.Text = ListaDeViajes[42, fila].Value.ToString();
                txtTipoCobro.Text = ListaDeViajes[44, fila].Value.ToString();
                txtNumeroGuia.Text = ListaDeViajes[21, fila].Value.ToString();
                txtFolio.Text = ListaDeViajes[20, fila].Value.ToString();
                txtFactura.Text = ListaDeViajes[45, fila].Value.ToString();
                lblEstatusFacturado.Text = ListaDeViajes[46,fila].Value.ToString();


                toolVenta.SetToolTip(txtNumbreRuta, ListaDeViajes[23, fila].Value.ToString());

                viajes.venta = float.Parse(ListaDeViajes[23, fila].Value.ToString());
                viajes.flete = float.Parse(ListaDeViajes[22, fila].Value.ToString());
                viajes.nombreRuta = ListaDeViajes[9, fila].Value.ToString();
                viajes.id_ruta = ListaDeViajes[10, fila].Value.ToString();
                viajes.destino = ListaDeViajes[12, fila].Value.ToString();
                viajes.origen = ListaDeViajes[11, fila].Value.ToString();
                viajes.codigoArea = int.Parse( ListaDeViajes[1, fila].Value.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        private void txtNumbreRuta_MouseHover(object sender, EventArgs e)
        {

            frmDetalleViajeRutasConvenios frm = new frmDetalleViajeRutasConvenios(viajes);
            frm.ShowDialog();

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            

            viajes.buscardor = txtBuscar.Text;
            mostrar(viajes);

        }
    }
}
