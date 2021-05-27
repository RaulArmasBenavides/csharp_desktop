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
    public partial class Resultados : Form
    {
        int IdPrueba;
        int IdCandidato;
        ResultadosPrueba r;
        public Resultados(int IdPrueba, int IdCandidato, ResultadosPrueba r)
        {
            InitializeComponent();
            this.IdPrueba = IdPrueba;
            this.IdCandidato = IdCandidato;
            this.r = r;

        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado de la prueba");
            }
            else
            {
                m.ResultadoPrueba(IdPrueba, IdCandidato, comboBox1.SelectedItem.ToString());
                this.Hide();
            }
        }//

    }
}
