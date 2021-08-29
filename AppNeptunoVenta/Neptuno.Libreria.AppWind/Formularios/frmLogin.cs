using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Neptuno.Libreria.AppWind.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ProductoBL obj = new ProductoBL();
            //if (obj.ValidaUsuario(txtUsuario.Text,txtPassword.Text) )
            //{
            //    this.Visible = false;
            //    frmRegistraVentas f = new frmRegistraVentas();
            //    f.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Password Incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
        }
    }
}
