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
    public partial class ResultadosCandidatos : Form
    {
        int Id;
        verPruebas v;
        public ResultadosCandidatos(int Id, verPruebas v)
        {
            InitializeComponent();
            this.Id = Id;
            this.v = v;
        }

        private void ResultadosCandidatos_Load(object sender, EventArgs e)
        {
            MetodosNav nav = new MetodosNav();
            nav.ResultadosPrueba(Id, dataGridView1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MetodosNav nav = new MetodosNav();
                nav.ResultadosPrueba(Id, dataGridView1);
                return;
            }
            else
            {
                String Cad = "%" + textBox1.Text + "%";
                if (comboBox1.SelectedIndex == 0)
                {
                    String query = "Select prueba_candidato.estado as 'Estado de la prueba',fecha as 'Fecha de realización', nombre as 'Nombre', apellido as 'apellido',"
                    + " dir as 'Dirección', tel as 'Teléfono', tipo as 'Tipo', fecha_nac as 'Fecha de nacimiento'  From Candidatos inner join prueba_candidato"
                    + " on Candidatos.Pk_candidato= prueba_candidato.fk_cand"
                    + " inner join Pruebas on Pruebas.Pk_prueba= prueba_candidato.fk_prueba"
                    + " WHERE Pk_prueba=" +Id+" AND nombre like '" +Cad+ "'";
                    
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    String query = "Select prueba_candidato.estado as 'Estado de la prueba',fecha as 'Fecha de realización', nombre as 'Nombre', apellido as 'apellido',"
                    + " dir as 'Dirección', tel as 'Teléfono', tipo as 'Tipo', fecha_nac as 'Fecha de nacimiento'  From Candidatos inner join prueba_candidato"
                    + " on Candidatos.Pk_candidato= prueba_candidato.fk_cand"
                    + " inner join Pruebas on Pruebas.Pk_prueba= prueba_candidato.fk_prueba"
                    + " WHERE Pk_prueba=" + Id + " AND apellido like '" + Cad + "'";

                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    String query = "Select prueba_candidato.estado as 'Estado de la prueba',fecha as 'Fecha de realización', nombre as 'Nombre', apellido as 'apellido',"
                    + " dir as 'Dirección', tel as 'Teléfono', tipo as 'Tipo', fecha_nac as 'Fecha de nacimiento'  From Candidatos inner join prueba_candidato"
                    + " on Candidatos.Pk_candidato= prueba_candidato.fk_cand"
                    + " inner join Pruebas on Pruebas.Pk_prueba= prueba_candidato.fk_prueba"
                    + " WHERE Pk_prueba=" + Id + " AND tipo like '" + Cad + "'";

                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);
                }
              
               
            }

        }//



    }
}
