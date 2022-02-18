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

namespace ZEMOGZAMMODIFICACIONES.Login
{
    public partial class frmLogin : Form
    {
        Usuario  user = new Usuario();
        C_Usuarios func = new C_Usuarios();

        public frmLogin()
        {
            InitializeComponent();
        }

        void log(Usuario user)
        {


            bool validacion = func.validacion_usuario(user);

            if (validacion)
            {
                MessageBox.Show("Bienvenido " + user.id_usuario + " Usuario : " + user.id_grupo);

                frmPrincipal frm = new frmPrincipal(user);
                frm.Show();
                this.Visible = false;

                //formularioPrincipal = new frmPrincipal(user);
                //formularioPrincipal.Show();
                //this.Visible = false;
            }
            else
            {

                //lblAlerta.Visible = true;
                //lblAlerta.ForeColor = Color.White;
                //lblAlerta.Font = new Font(lblAlerta.Font, FontStyle.Bold);


                //lblAlerta.Text = "Usuario  o contrasena incorrecto";
                MessageBox.Show("NO pudimos encontrar tu usuario concacta al admin del sistem");

            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios.Text.Length == 0)
            {
                MessageBox.Show("Ingresa un usuario");
                txtUsuarios.Focus();
                return;
            }

            if (txtContrasena.Text.Length == 0)
            {
                MessageBox.Show("Ingresa una contrasena");
                txtContrasena.Focus();
                return;
            }

            user.id_usuario = txtUsuarios.Text;
            user.password = txtContrasena.Text;

            log(user);



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resultado =  MessageBox.Show("Deseas cerrar la aplicacion","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

           
        }
    }
}
