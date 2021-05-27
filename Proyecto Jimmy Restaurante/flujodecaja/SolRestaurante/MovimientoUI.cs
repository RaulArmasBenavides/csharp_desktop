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
    public partial class MovimientoUI : Form
    {
        public MovimientoUI()
        {
            InitializeComponent();
        }

        #region Declaración de variables

        FlujoCajaBo flujoBo = new FlujoCajaBo();
        #endregion

        #region Eventos 
        private void MenuUI_Load(object sender, EventArgs e)
        {
            LeerDatos();
            cbmSubtipo.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MenuBL menu = new MenuBL();
            //DataSet dsMenu = new DataSet();
            //dsMenu = menu.BuscarId(Convert.ToInt32(txtConcepto.Text));
            //if (dsMenu.Tables.Count > 0)
            //{
            //    if (dsMenu.Tables[0].Rows.Count > 0)
            //    {
            //        txtConcepto.Text = dsMenu.Tables[0].Rows[0][0].ToString();
            //        txtTipo.Text = dsMenu.Tables[0].Rows[0][1].ToString();
            //        rtbDescripcionMov.Text = dsMenu.Tables[0].Rows[0][2].ToString();
            //        txtFecha.Text = dsMenu.Tables[0].Rows[0][3].ToString();
            //        txtSubtipo.Text = dsMenu.Tables[0].Rows[0][4].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No existe registro");
            //    }
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (MessageBox.Show("¿Estás seguro que quiere eliminar este movimiento del sistema?", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {

                        flujoBo.Eliminar(Convert.ToInt32(this.dtgMov.CurrentRow.Cells[0].Value.ToString()));
                    //this.MenuUI_Load(sender, e);
                    LeerDatos();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //MenuBL menu = new MenuBL();

                //flujoBo.Actualizar(Convert.ToInt32(txtConcepto.Text), txtTipo.Text, rtbDescripcionMov.Text, Convert.ToDecimal(txtFecha.Text), txtSubtipo.Text);
                //flujoBo.Actualizar()

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
               try
                {
                    if (MessageBox.Show("¿Estás seguro que quiere agregar este movimiento al sistema?", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                    flujoBo.Insertar(cmbConcepto.Text, cbmTipo.Text, cbmSubtipo.Text, txtFecha.Text, Decimal.Parse(txtMonto.Text), txtMes.Text);
                    LeerDatos();
                }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
       
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region Métodos 

        public void LeerDatos()
        {
            DataSet dsMov = new DataSet();
            dsMov = flujoBo.BuscarTodo();
            if (dsMov.Tables.Count > 0)
            {
                dtgMov.DataSource = dsMov.Tables[0];
                dtgMov.AllowUserToAddRows = false;
            }

        }

        #endregion

        private void txtSubtipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmSubtipo.Enabled = true;

            if(cbmTipo.Text == "I")
            {
                cbmSubtipo.Text = "1";
            }
            else if(cbmTipo.Text=="G")
            {
                //cbmSubtipo.t
            }
        
    }
    }
}

