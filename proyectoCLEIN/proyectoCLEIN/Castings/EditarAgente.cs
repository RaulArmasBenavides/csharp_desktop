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
    public partial class EditarAgente : Form
    {
       
        public EditarAgente()
        {
            InitializeComponent();
        }

        private void EditarAgente_Load(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            m.MostrarAgentes(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try {
                pos = dataGridView1.CurrentCell.RowIndex;
                int datoId = (int)dataGridView1[0, pos].Value;

                DetallesAgente d = new DetallesAgente(datoId, this);
                d.MdiParent = this.MdiParent;
                d.Show();
                this.Dispose();
            }
            catch { MessageBox.Show("Seleccione un agente de la lista"); }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Trim().Equals(""))
            {
                MetodosCasting m = new MetodosCasting();
                m.MostrarAgentes(dataGridView1);
                return;
            }
            else
            {
                String Cad = "%"+textBox2.Text+"%";

                if (comboBox2.SelectedIndex == 0)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [# de Empleado] like '" + Cad + "'";

                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Cédula] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);

                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Nombre] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);

                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    String Query = "SELECT *FROM MostrarAgentes WHERE [Apellido] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    String Query = "Select *From MostrarAgentes WHERE [Estado] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);
                }
            }///
        }



    }
}
