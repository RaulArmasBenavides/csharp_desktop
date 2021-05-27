using AppAdo03.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo03.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        //instanciar objeto de la clase EmpleadoBLL
        EmpleadoBLL obj = new EmpleadoBLL();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (obj.EmpleadoValidar(txtUsuario.Text,txtClave.Text))
            {
                this.Hide();
                MDImenu f = new MDImenu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Password es Incorrecto", "error");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
