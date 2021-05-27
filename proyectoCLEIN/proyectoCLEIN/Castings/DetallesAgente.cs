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
    public partial class DetallesAgente : Form
    {

        int Id;
        EditarAgente editar;
        MetodosCasting m;
        public DetallesAgente(int Id, EditarAgente editar)
        {
            InitializeComponent();
            nombre.Enabled = false;
            apellido.Enabled = false;
            numEmpleado.Enabled = false;
            ced.Enabled = false;
            dir.Enabled = false;
            pic1.Visible = false;
            pic2.Visible = false;

            this.Id = Id;
            this.editar = editar;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true){
                nombre.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                nombre.Enabled = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                apellido.Enabled = true;
            }
            else if (checkBox2.Checked == false)
            {
                apellido.Enabled = false;

            }

        }

        private void DetallesAgente_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            m = new MetodosCasting();
            m.MostrarDetalleAgente(Id, nombre, apellido, numEmpleado, ced, dir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || dir.Text.Length == 0)
            {
                MessageBox.Show("Complete los campos obligatorios");
                pic1.Visible = true;
                pic2.Visible = true;
            }
            else
            {
                m.ActualizarAgente(Id, nombre.Text, apellido.Text, dir.Text, comboBox1.SelectedItem.ToString());
                editar = new EditarAgente();
                editar.MdiParent = this.MdiParent;
                editar.Show();
                this.Dispose();

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true){
                dir.Enabled = true;
            }else if (checkBox3.Checked == false)
            {
                dir.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }//


    }
}
