using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Casting.Castings;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class ContratarCasting : Form
    {
        MetodosCasting m;
        public ContratarCasting()
        {
            InitializeComponent();
        }

        private void ContratarCasting_Load(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            m.MostrarClientes(dataGridView1);
            m.MostrarAgentesActivos(dataGridView2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {       m = new MetodosCasting();
            if (comboBox1.SelectedIndex==0){ m.ClienteTipo(textBox1, dataGridView1);
            } else if (comboBox1.SelectedIndex == 1) { m.ClienteNombre(textBox1, dataGridView1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                textBox3.Text = Convert.ToString((int)dataGridView1[0, pos].Value);
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Equals("") || textBox4.Text.Equals("")){
                MessageBox.Show("Primero seleccione un cliente y un agente para este casting.\n"
                                +"Por favor, revise en intentelo de nuevo", "No se puede procesar su solicitud",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                Cliente_Agente c = new Cliente_Agente(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                c.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int pos = 0;
            try
            {
                pos = dataGridView2.CurrentCell.RowIndex;
                textBox4.Text = Convert.ToString(dataGridView2[0, pos].Value);
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char caracter = e.KeyChar;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (textBox3.Text.Length > 10)
            {
                e.Handled = true;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(Char.IsLetter(e.KeyChar)){
                e.Handled = true;
            }
            else if(Char.IsPunctuation(e.KeyChar)){
                e.Handled = true;
            }else
            {
                e.Handled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char caracter = e.KeyChar;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (textBox4.Text.Length > 10)
            {
                e.Handled = true;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Trim().Equals(""))
            {
                m = new MetodosCasting();
                m.MostrarAgentes(dataGridView2);
                return;
            }
            else
            {
                String Cad = "%" + textBox2.Text + "%";
                
                if(comboBox2.SelectedIndex==0){
                String Query = "SELECT *FROM MostrarAgentes WHERE [Estado]='Activo' AND [# de Empleado] like'" + Cad + "'";
                
                MetodosNav nav = new MetodosNav();
                nav.Buscar(Query, dataGridView2);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Estado]='Activo' AND [Cédula] like'" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView2);

                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Estado]='Activo' AND [Nombre] like'" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView2);

                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Estado]='Activo' AND [Apellido] like'" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView2);
                }
            }///
        }//

    }
}
