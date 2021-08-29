
using Alumnos.Controller;
using Alumnos.Entity;
using System;
using System.Windows.Forms;

namespace AppDemo11.View
{
    public partial class FrmRectificacion : Form
    {
        public FrmRectificacion()
        {
            InitializeComponent();
            verAlumnos();
            verCursosIncluir();
            verCursosExcluir();
        }

        //instanciar objeto de la clase ProductoBll
        //Alumnobll obj = new Alumnobll();
        //Cursobll objcur1 = new Cursobll();
        //Cursobll objcur2 = new Cursobll();

        //variables de la clases Alumno y Curso 
        Alumno a;
        //Curso ci,ce;

        private void verAlumnos()
        {
            dgvProducto.DataSource = null; 
            dgvProducto.DataSource = obj.AlumnoListar();
        }
        private void verCursosIncluir()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = objcur1.CursoListar();
        }
        private  void verCursosExcluir()
        {

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = objcur2.CursoListar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            procesar(1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            procesar(2);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            procesar(3);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }                

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void procesar(int v)
        {
            string msg = "";
            switch (v)
            {
                case 1:
                    obj.AlumnoAdicionar(leerDatos());
                    DialogResult result1 = MessageBox.Show("Deseas incluirte en algun curso?",
                    "Important Question",
                     MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                        objcur1.CursoAdicionar(leerDatosCursosaIncluir());
                    else
                    {
                        MessageBox.Show("Ningun curso agregado");
                    }
                    DialogResult result2 = MessageBox.Show("Deseas excluirte en algun curso?",
                    "Important Question",
                     MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                        objcur2.CursoAdicionar(leerDatosCursosaExcluir());
                    else
                    {
                        MessageBox.Show("Ningun curso excluido");
                    }
                    msg = "Alumno registrado con exito";
                    break;
                case 2:
                    obj.AlumnoActualizar(leerDatos());
                    msg = "Producto actualizado con exito";
                    break;
                case 3:
                    obj.AlumnoEliminar(leerDatos());
                    objcur1.CursoEliminar(leerDatosCursosaIncluir());
                    objcur2.CursoEliminar(leerDatosCursosaExcluir());
                    msg = "Alumno eliminado con exito";
                    break;
                case 4:
                    mostrarAlumnos();
                    return;
            }
            MessageBox.Show(msg, "exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            verAlumnos();
            verCursosIncluir();
            verCursosExcluir();
        }

        private void mostrarAlumnos()
        {
            a = obj.AlumnoBuscar(int.Parse(txtCodigo.Text));
            if (a != null)
            {   
             
                //txtNombre.Text = a.Nombre;
                //txtCreditos.Text = a.Precio.ToString();
                //txtCantidad.Text = a.Stock.ToString();
               // cboCategoria.Text = a.Categoria;
            }
            else
            {
                MessageBox.Show("Producto no existe", "aviso");
            }
        }

        private Alumno leerDatos()
        {
            //crear objeto alumno
            a = new Alumno();
            //asignar valores al objeto a
            a.codigo = int.Parse(txtCodigo.Text);
            a.nombre = txtNombre.Text;
            a.escuela = txtEscuela.Text;
            a.creditos = int.Parse(txtCreditos.Text);
            if(radioButton1.Checked == true)
            a.creditos= a.creditos + int.Parse(comboBox1.Text);
            return a;

        } 
        private Curso leerDatosCursosaIncluir()
        {
             //crear objeto curso
            ci = new Curso();
            ci.codigocurso = int.Parse(txtcodigo1.Text);
            ci.nombrecurso = txtCursoIncluir.Text;
            ci.docente = txtdocente1.Text;
            ci.creditaje = int.Parse(txtcreditos1.Text);
            ci.seccion = int.Parse(txtsecc1.Text);
            return ci;
        }
        private Curso leerDatosCursosaExcluir()
        {
            //crear objeto curso
            ce = new Curso();
            ce.codigocurso = int.Parse(txtcodigo2.Text);
            ce.nombrecurso = txtCursoExcluir.Text;
            ce.docente = txtdocente2.Text;
            ce.creditaje = int.Parse(txtcreditos2.Text);
            ce.seccion = int.Parse(txtsecc2.Text);
            return ce;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmRectificacion_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdocente1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
