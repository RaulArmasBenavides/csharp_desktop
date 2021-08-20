using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
         /*   Usuarios u = new Usuarios();
            u.MostrarUsuario(textBox2, pictureBox1);
            CargarComponentes();*/


            
        }

        private void pwd1_KeyUp(object sender, KeyEventArgs e)
        {
            if (pwd1.Text.Length <= 4)
            {
                err1.Visible = true;
                ico1.Visible = false;
                pwd2.Enabled = false;
                weak.Visible = false;
                pwd2.Clear();
                status.Visible = false;
            }
            else if ((pwd1.Text.Length > 4))
            {
                if (pwd1.Text.Length > 9)
                {
                    if (pwd1.Text.Length > 14) {
                        pwd2.Enabled = true;
                        ico1.Visible = true;
                        weak.Text = "Contraseña Fuerte";
                        weak.ForeColor = Color.Blue;
                        weak.Visible = true;
                        err1.Visible = false;
                        
                    }
                    else
                    {

                    pwd2.Enabled = true;
                    ico1.Visible = true;
                    weak.Text = "Contraseña Media";
                    weak.ForeColor = Color.Green;
                    weak.Visible = true;
                    err1.Visible = false;
                    }//Mayor a 9 caracteres
                }
                else
                {
                    pwd2.Enabled = true;
                    ico1.Visible = true;
                    weak.Text = "Contraseña débil";
                    weak.ForeColor = Color.Yellow;
                    weak.Visible = true;
                    err1.Visible = false;
                }//Mayor a 4 caracteres

                if (pwd1.Text.Equals(pwd2.Text))
                {
                    ico2.Visible = true;
                    err2.Visible = false;
                    status.Text = "Coinciden";
                    status.ForeColor = Color.Blue;
                    status.Visible = true;
                    button1.Enabled = true;

                }
                else
                {
                    err2.Visible = true;
                    ico2.Visible = false;
                    status.Text = "No Coinciden";
                    status.ForeColor = Color.Red;
                    status.Visible = true;
                    button1.Enabled = false;
                }
            }
            
            }//

        public void CargarComponentes()
        {
            ico1.Visible = false;
            ico2.Visible = false;
            err1.Visible = false;
            err2.Visible = false;
            pwd2.Enabled = false;
            weak.Visible = false;
            status.Visible = false;
            button1.Enabled = false;
            user.Visible = false;
            }

        private void pwd1_KeyPress(object sender, KeyPressEventArgs e)
        {  Char caracter = e.KeyChar;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (pwd1.Text.Length > 16)
            {
               e.Handled = true;

            }else if (Char.IsSeparator(e.KeyChar))
            {
                    e.Handled = true;
           }
        }

        private void pwd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char caracter = e.KeyChar;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (pwd2.Text.Length > 16)
            {
                e.Handled = true;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pwd2_KeyUp(object sender, KeyEventArgs e)
        {
            if(pwd2.Text.Length==0){
                err2.Visible = true;
                ico2.Visible = false;
                status.Text = "No Coinciden";
                status.ForeColor = Color.Red;
                status.Visible = true;
                button1.Enabled = false;
            }else{ 
                
                if(pwd1.Text.Equals(pwd2.Text)){
                ico2.Visible = true;
                err2.Visible = false;
                status.Text = "Coinciden";
                status.ForeColor = Color.Blue;
                status.Visible = true;
                button1.Enabled = true;
               }
               else
                {
                err2.Visible = true;
                ico2.Visible = false;
                status.Text = "No Coinciden";
                status.ForeColor = Color.Red;
                status.Visible = true;
                button1.Enabled = false;
            }
          }
        }//

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(textBox2.Text.Length>4){
                user.Visible = true;
                userNo.Visible = false;
            }
            else
            {
                user.Visible = false;
                userNo.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) { MessageBox.Show("Primero seleccione una pregunta de seguridad", "Imposible almacenar",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBox2.TextLength<5)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 5 caracteres", "Imposible almacenar",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox1.TextLength<1)
            {
                MessageBox.Show("Responda la pregunta de seguridad", "Imposible almacenar",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pwd1.Text.Equals(pwd2.Text))
            {
              /*  Usuarios u = new Usuarios();
                u.ActualizarUsuario(textBox2.Text, pwd2.Text, comboBox1.SelectedItem.ToString(), textBox1.Text, pictureBox1);
                this.Hide();
                //*/
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*AgregarActividad i = new AgregarActividad();
            this.Hide();
            i.MdiParent = this;
            i.Close();
            
            Login l = new Login();
            l.Show(); 
            */
        }//

        private void user_Click(object sender, EventArgs e)
        {

        }
    }
}
