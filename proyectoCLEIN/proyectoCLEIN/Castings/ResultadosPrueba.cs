using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Castings
{
    public partial class ResultadosPrueba : Form
    {
        int Id;
        verPruebas v;
        public ResultadosPrueba(int Id, verPruebas v)
        {
            InitializeComponent();
            this.Id = Id;
            this.v = v;
        }

        private void ResultadosPrueba_Load(object sender, EventArgs e)
        {
            MetodosPerfiles m = new MetodosPerfiles();
            m.MostrarPerfiles(dataGridView1);
            toolStripStatusLabel1.Text = "Id de prueba: "+Id;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere agregar este candidato a la prueba?", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No){
                  return;
              }
            else
            { try
                {
                    int pos = dataGridView1.CurrentCell.RowIndex;
                    int IdCandidato= (int)dataGridView1[0, pos].Value;
                    Resultados r = new Resultados(Id, IdCandidato, this);
                    r.MdiParent = this.MdiParent;
                    r.Show();
                }
                catch { MessageBox.Show("Primero seleccione a un candidato"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
