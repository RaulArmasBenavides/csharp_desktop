//using AppAdoNet07.Controller;

using AppAdo07.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo07.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //instanciar oobjeto de la clase EmpleadoBLL
        EmpleadoBLL obj = new EmpleadoBLL();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = obj.EmpleadoValidar(txtUsuario.Text, txtPassword.Text);
                if (id != 0)
                {
                    this.Hide();
                    Formulario formulario = new Formulario(id);
                    
                    formulario.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuario o Password es Incorrecto !", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
