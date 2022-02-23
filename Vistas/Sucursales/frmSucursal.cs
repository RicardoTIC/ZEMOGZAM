using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Modelo;

namespace ZEMOGZAMMODIFICACIONES.Vistas.Sucursales
{
    public partial class frmSucursal : Form
    {
        C_Sucursal func = new C_Sucursal();
        Sucursal sc = new Sucursal();

        public frmSucursal()
        {
            InitializeComponent();
        }

        void mostrar(Sucursal suc)
        {

            
            ListaDatos.DataSource = func.lista_Sucursales(suc);

        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {

            txtArea.Enabled = false;

            sc.buscador = "";
            sc.accion = 1;
            sc.nombrecorto = "";
            sc.costoPorEquipo = 0;
            sc.presupuesto = 0;
            sc.numeroUnidades = 0;

            try
            {
                
                mostrar(sc);
            }
            catch (Exception ex)
            {

                MessageBox.Show("error al mostrar los datos " + ex.Message);
                
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            sc.buscador = textBox6.Text;
            sc.accion = 1;
            sc.nombrecorto = "";
            sc.costoPorEquipo = 0;
            sc.presupuesto = 0;
            sc.numeroUnidades = 0;

            try
            {

                mostrar(sc);
            }
            catch (Exception ex)
            {

                MessageBox.Show("error al mostrar los datos " + ex.Message);

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            sc.buscador = "";
            sc.accion = 3;
            sc.nombrecorto = txtNombreSucursal.Text;
            sc.costoPorEquipo = int.Parse(txtCostoPorUnidad.Text);
            sc.presupuesto = Double.Parse(txtPresupuesto.Text);
            sc.numeroUnidades = int.Parse(txtNumeroUnidades.Text);

            try
            {
                MessageBox.Show(func.mantenimientoSucursales(sc));
                sc.accion = 1;
                mostrar(sc);
            }
            catch (Exception ex)
            {

                MessageBox.Show("error al actualizar los datos " + ex.Message);

            }


        }

        private void ListaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = ListaDatos.CurrentCell.RowIndex;
            try
            {

                txtArea.Text = ListaDatos[0, fila].Value.ToString();
                txtNumeroUnidades.Text = ListaDatos[4, fila].Value.ToString();
                txtNombreSucursal.Text = ListaDatos[1, fila].Value.ToString();
                txtPresupuesto.Text = ListaDatos[2, fila].Value.ToString();
                txtCostoPorUnidad.Text = ListaDatos[3, fila].Value.ToString();

            }
            catch (Exception ex )
            {

                MessageBox.Show("Error al seleccionar registro " + ex.Message);
            }


        }
    }
}
