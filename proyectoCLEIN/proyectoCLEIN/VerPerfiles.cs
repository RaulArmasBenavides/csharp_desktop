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
    public partial class VerPerfiles : Form
    {
        public VerPerfiles()
        {
            InitializeComponent();
        }

        private void VerPerfiles_Load(object sender, EventArgs e)
        {
            MetodosPerfiles met = new MetodosPerfiles();
            met.MostrarPerfiles(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                int dataPos = (int)dataGridView1[0, pos].Value;

                DetallesPerfil dtp = new DetallesPerfil(dataPos, this);
                dtp.MdiParent = this.MdiParent;
                dtp.Show();
                this.Dispose();
            }
            catch { MessageBox.Show("Seleccione un perfil de la tabla"); }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (textBox1.Text.Trim().Equals(""))
            {
                MetodosPerfiles m = new MetodosPerfiles();
                m.MostrarPerfiles(dataGridView1);
                return;
            }
            else
            {
                String Cad = "%" + textBox1.Text + "%";
                if (comboBox1.SelectedIndex == 0)
                {
                    String query = " Select *From Candidatos_Perfiles WHERE [Nombre] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Apellido] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Tipo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Sexo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Procedencia] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color del pelo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color de los ojos] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
            }
        }//

    }
}
