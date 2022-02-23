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

namespace ZEMOGZAMMODIFICACIONES.Covenios
{
    public partial class frmConvenios: Form
    {
        CapaNegocio.C_Convenios func = new CapaNegocio.C_Convenios();
        Convenios convenio = new Convenios();
        Sucursal suc = new Sucursal();
        public frmConvenios()
        {
            InitializeComponent();
        
        }


        void cargarComboSucursal() 
        {
            
            cboSucursal.DataSource = func.cargarComboBox();

            
            cboSucursal.DisplayMember = "nombrecorto";
            cboSucursal.ValueMember = "id_area";
            
        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {
            
            cargarComboSucursal();
            
            lblTotalRegistros.Text =  ListaCovenios.RowCount.ToString();

        }

        void mostrar(Convenios con)
        {
            try
            {
                ListaCovenios.DataSource = func.lista_Convenios(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se agrego un nombre incorrecto en el ProcedureSQL "+ex.Message);
                
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cboSucursal.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona una sucursal");
                return;
            }

           
            convenio.desc_convenio = txtBuscar.Text;         
            convenio.id_area_zemog = int.Parse(cboSucursal.SelectedValue.ToString());
       
            
        
            mostrar(convenio);
            lblTotalRegistros.Text = ListaCovenios.RowCount.ToString();

        }

        private void txtBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Abriendo formulario");
        }

        private void ListaCovenios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = ListaCovenios.CurrentCell.RowIndex;


            try
            {
                txtidconvenio.Text = ListaCovenios[0, fila].Value.ToString();
                txtNombreRuta.Text = ListaCovenios[15, fila].Value.ToString();
                txtRemitente.Text = ListaCovenios[5, fila].Value.ToString();
                txtidconvenio.Text = ListaCovenios[4, fila].Value.ToString();
                txtDestinatario.Text = ListaCovenios[7, fila].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el datos " + ex.Message);
                
            }

        }
    }
}
