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
        
        
        public frmDetalleViajes()
        {
            InitializeComponent();
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            viajes.buscardor = txtBuscar.Text;
            viajes.fechaInicial = txtFechaInicio.Value;
            viajes.fechafinal = txtFechaFinal.Value;

            mostrar(viajes);
        }
    }
}
