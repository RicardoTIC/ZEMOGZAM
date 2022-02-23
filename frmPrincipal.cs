using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZEMOGZAMMODIFICACIONES.Viajes;
using ZEMOGZAMMODIFICACIONES.Covenios;
using ZEMOGZAMMODIFICACIONES.Vistas.Sucursales;
using ZEMOGZAMMODIFICACIONES.Vistas.Resumen_de_kilometros;

using Modelo;

namespace ZEMOGZAMMODIFICACIONES

{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public frmPrincipal(Usuario user)
        {
            InitializeComponent();
            lblInformacion.Text = "Usuario : " + user.nombre + " Tipo de usuario " + user.id_grupo;

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmConvenios hijo = new frmConvenios();
            hijo.MdiParent = this;
            hijo.Show();

            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

            
           
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.frmLogin frmLogin = new Login.frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }




        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal frm = new frmSucursal();
            frm.MdiParent = this;
            frm.Show();

        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDetalleViajes viajes = new frmDetalleViajes();
            viajes.MdiParent = this;
            viajes.Show();



        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resumenDeKilometrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResumenViajes frm = new frmResumenViajes();

            frm.MdiParent = this;
            frm.Show();

        }
    }
}
