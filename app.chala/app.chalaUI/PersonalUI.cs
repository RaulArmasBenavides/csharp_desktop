using System;
using System.Data;
using System.Windows.Forms;
using app.cochachi.datos.Entidades;
using app.chala.negocios;

namespace com.app.comprobante.UI
{
    public partial class PersonalUI : Form
    {
        #region Declaracion de variables
        ChalaBo _boChala =null;
        Personal pe = null;
        #endregion



        #region Métodos 

        public void LeerDatos()
        {
            _boChala = new ChalaBo();
             DataSet dsPersonal = new DataSet(); //creamos un dataset 
          //  DataTable dtPersonal = new DataTable();
            dtPersonal = _boChala.LeerTodoPersonal();
            //dsEmpleado = empleado.buscarTodo();
            if (dsPersonal.Tables.Count > 0)
            {

                dtgPersonal.DataSource = dsPersonal;
                //dtgEmpleado.AllowUserToAddRows = false;
                //dtgEmpleado.Columns[2].Visible = false;
                //dtgPersonal.Columns[13].Visible = false;
            }
            else
            {
                dtPersonal.Rows.Clear();
               // MessageBox.Show("Error" + ex.Message);
            }

        }


     
        #endregion
        public PersonalUI()
        {
            InitializeComponent();
        }
    
       private void EmpleadoUI_Load(object sender, EventArgs e)
        {
            try
            {
                LeerDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere agregar este personal al sistema?", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //EmpleadoBo empleado = new EmpleadoBo();
                    //empleado.insertar(Convert.ToInt32(txtIdEmp.Text), txtNombreEmp.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, dtpFechaNacEmp.Value);
                    //Empleado.insertar(txtNombreEmp.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, Convert.ToDateTime(dtFecha.Text));
                    _boChala = new ChalaBo();
                    pe = new Personal();
                    //seteando valores 
                    pe.ApeMat = txtApeMat.Text.Trim();
                    pe.ApePat = txtApePat.Text.Trim();
                    pe.Correo = txtCorreo.Text.Trim();
                    pe.CtaAbono = txtCAbono.Text.Trim();
                    pe.Domicilio = txtDomicilio.Text.Trim();
                    pe.Nombre1 = txtNombre2.Text.Trim();
                    pe.Nombre2 = txtNombre2.Text.Trim();
                    //emp.Nombre3 = txtNombre2.Text.Trim();
                    pe.Telf1 = txtTelf1.Text.Trim();
                    pe.Telf2 = txtTelf2.Text.Trim();
                    pe.Telf3 = txtTelf3.Text.Trim();
                    _boChala.InsertarPersonal(pe);
                    //empleado.insertar(emp);
                    LeerDatos();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere actualizar este empleado al sistema?", "",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //EmpleadoBo empleado = new EmpleadoBo();
                    //empleado.actualizar(Convert.ToInt32(this.dtgEmpleado.CurrentRow.Cells[0].Value.ToString()), txtNombre2.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, Convert.ToDateTime(dtFecha.Text));
                    LeerDatos();
                    //this.EmpleadoUI_Load(sender, e);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere eliminar este empleado del sistema?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                   //EmpleadoBo empleado = new EmpleadoBo();
                   //empleado.eliminar(Convert.ToInt32(this.dtgPersonal.CurrentRow.Cells[0].Value.ToString()));
                   //this.EmpleadoUI_Load(sender, e);
                }       
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //EmpleadoBo empleado = new EmpleadoBo();
                DataSet dsEmpleado = new DataSet();
               // dsEmpleado = empleado.buscarId(Convert.ToInt32(txtidentificador.Text));
                if (dsEmpleado.Tables.Count > 0)
                {
                   // if (dsEmpleado.Tables[0].Rows.Count > 0)
                    //txtidentificador.Text = dsEmpleado.Tables[0].Rows[0][0].ToString();
                    //txtNombre2.Text = dsEmpleado.Tables[0].Rows[0][1].ToString();
                    //cmbGeneroEmp.Text = dsEmpleado.Tables[0].Rows[0][2].ToString();
                    //cmbCargoEmp.Text = dsEmpleado.Tables[0].Rows[0][3].ToString();
                    //dtFecha.Value = Convert.ToDateTime(dsEmpleado.Tables[0].Rows[0][4].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
