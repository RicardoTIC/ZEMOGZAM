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

namespace ZEMOGZAMMODIFICACIONES.Viajes
{
    public partial class frmDetalleViaje : Form
    {
        public frmDetalleViaje(Viaje obj)
        {
            InitializeComponent();
            txtVenta.Text = obj.venta.ToString();
            txtFlete.Text = obj.flete.ToString();
            lblRuta.Text = obj.nombreRuta;
            lblDestino.Text = obj.origen;
            lblOrigen.Text = obj.destino;
        }

        private void frmDetalleViaje_Load(object sender, EventArgs e)
        {

        }
    }
}
