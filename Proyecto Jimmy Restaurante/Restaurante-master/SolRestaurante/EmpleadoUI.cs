using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestauranteBL;

namespace SolRestaurante
{
    public partial class EmpleadoUI : Form
    {
        public EmpleadoUI()
        {
            InitializeComponent();
        }
    
       private void EmpleadoUI_Load(object sender, EventArgs e)
        {
            try
            {
                EmpleadoBL empleado = new EmpleadoBL();
                DataSet dsEmpleado = new DataSet();
                dsEmpleado = empleado.buscarTodo();
                if (dsEmpleado.Tables.Count>0)
                {
                    dtgEmpleado.DataSource = dsEmpleado.Tables[0];
                    //dtgEmpleado.AllowUserToAddRows = false;
                   //  dtgEmpleado.Columns[2].Visible = false;
                   //  dtgEmpleado.Columns[4].Visible = false;
                }
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
                if (MessageBox.Show("¿Estás seguro que quiere agregar este empleado al sistema?", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    EmpleadoBL empleado = new EmpleadoBL();
                    //   empleado.insertar(Convert.ToInt32(txtIdEmp.Text), txtNombreEmp.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, dtpFechaNacEmp.Value);
                    empleado.insertar(txtNombreEmp.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, Convert.ToDateTime(dtFecha.Text));
                    this.EmpleadoUI_Load(sender, e);
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
                    EmpleadoBL empleado = new EmpleadoBL();
                    empleado.actualizar(Convert.ToInt32(this.dtgEmpleado.CurrentRow.Cells[0].Value.ToString()), txtNombreEmp.Text, cmbGeneroEmp.Text, cmbCargoEmp.Text, Convert.ToDateTime(dtFecha.Text));
                    this.EmpleadoUI_Load(sender, e);
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
                    EmpleadoBL empleado = new EmpleadoBL();
                    empleado.eliminar(Convert.ToInt32(this.dtgEmpleado.CurrentRow.Cells[0].Value.ToString()));
                    this.EmpleadoUI_Load(sender, e);
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
                EmpleadoBL empleado = new EmpleadoBL();
                DataSet dsEmpleado = new DataSet();
                dsEmpleado = empleado.buscarId(Convert.ToInt32(txtidentificador.Text));
                if (dsEmpleado.Tables.Count > 0)
                {
                    if (dsEmpleado.Tables[0].Rows.Count > 0)
                        txtidentificador.Text = dsEmpleado.Tables[0].Rows[0][0].ToString();
                    txtNombreEmp.Text = dsEmpleado.Tables[0].Rows[0][1].ToString();
                    cmbGeneroEmp.Text = dsEmpleado.Tables[0].Rows[0][2].ToString();
                    cmbCargoEmp.Text = dsEmpleado.Tables[0].Rows[0][3].ToString();
                    dtFecha.Value = Convert.ToDateTime(dsEmpleado.Tables[0].Rows[0][4].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
