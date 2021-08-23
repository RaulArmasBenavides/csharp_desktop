using appcongreso.EF;
using CapaDatos.Controller;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{

    public partial class Login : Form
    {


        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        UsuarioBll obj = new UsuarioBll();
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*    if(MessageBox.Show("¿Desea abrir un nuevo formularios\n"
               +"de recuperación de contraseña?","Información",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
               {

                   return;
               }
               else {

                   Recuperacion1 r = new Recuperacion1();
                   this.Hide();
                   r.Show();

               */
        }

        private void Login_Load(object sender, EventArgs e)
         {
         }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(txtUsuario.Equals("") || txtClave.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar usuario y password", "ERROR");
                return;
            }

            usp_usuarios_listar_all_Result pro2 = new usp_usuarios_listar_all_Result();
           //usuarios usuarioep = new usuarios();
            pro2.usuario= txtUsuario.Text.Trim();
            pro2.clave = txtClave.Text.Trim();
            if (obj.UsuarioValidar(pro2) != null)
            {
                this.Hide();
                Inicio f = new Inicio();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Password es Incorrecto", "ERROR");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
            }

        }


    }
}

