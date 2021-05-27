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
    public partial class SucursalUI : Form
    {
        public SucursalUI()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalBL suc = new SucursalBL();

                suc.Insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(txtCapacidad.Text), txtEstablecimineto.Text, txtCiudad.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToInt32(txtSerie.Text), Convert.ToInt32(txtNumAutorizacion.Text), Convert.ToInt32(txtInicioFact.Text), Convert.ToInt32(txtFinFact.Text), dtpFechaVigencia.Value);
                this.SucursalUI_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalBL suc = new SucursalBL();

                suc.Actualizar(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(txtCapacidad.Text), txtEstablecimineto.Text, txtCiudad.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToInt32(txtSerie.Text), Convert.ToInt32(txtNumAutorizacion.Text), Convert.ToInt32(txtInicioFact.Text), Convert.ToInt32(txtFinFact.Text), dtpFechaVigencia.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalBL suc = new SucursalBL();
                suc.Eliminar(Convert.ToInt32(this.dtgSucursal.CurrentRow.Cells[0].Value.ToString()));
                this.SucursalUI_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SucursalBL suc = new SucursalBL();
            DataSet dsSuc = new DataSet();
            dsSuc = suc.BuscarId(Convert.ToInt32(txtId.Text));
            if (dsSuc.Tables.Count > 0)
            {
                if (dsSuc.Tables[0].Rows.Count > 0)
                {
                    txtId.Text = dsSuc.Tables[0].Rows[0][0].ToString();
                    txtNombre.Text = dsSuc.Tables[0].Rows[0][1].ToString();
                    txtCapacidad.Text = dsSuc.Tables[0].Rows[0][2].ToString();
                    txtEstablecimineto.Text = dsSuc.Tables[0].Rows[0][3].ToString();
                    txtCiudad.Text = dsSuc.Tables[0].Rows[0][4].ToString();
                    txtDireccion.Text = dsSuc.Tables[0].Rows[0][5].ToString();
                    txtTelefono.Text = dsSuc.Tables[0].Rows[0][6].ToString();
                    txtSerie.Text = dsSuc.Tables[0].Rows[0][7].ToString();
                    txtNumAutorizacion.Text = dsSuc.Tables[0].Rows[0][8].ToString();
                    txtInicioFact.Text = dsSuc.Tables[0].Rows[0][9].ToString();
                    txtFinFact.Text = dsSuc.Tables[0].Rows[0][10].ToString();
                    dtpFechaVigencia.Value = Convert.ToDateTime(dsSuc.Tables[0].Rows[0][11].ToString());
                }
                else
                {
                    MessageBox.Show("No existe registro");
                }
            }
        }

        private void SucursalUI_Load(object sender, EventArgs e)
        {
            SucursalBL suc = new SucursalBL();
            DataSet dsSuc = new DataSet();
            dsSuc = suc.BuscarTodo();
            if (dsSuc.Tables.Count > 0)
            {
                dtgSucursal.DataSource = dsSuc.Tables[0];
                dtgSucursal.AllowUserToAddRows = false;
               /* dtgSucursal.Columns[3].Visible = false;
                dtgSucursal.Columns[7].Visible = false;
                dtgSucursal.Columns[8].Visible = false;
                dtgSucursal.Columns[9].Visible = false;
                dtgSucursal.Columns[10].Visible = false;
                dtgSucursal.Columns[11].Visible = false;*/
            
    }
        }

        private void dtgSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
