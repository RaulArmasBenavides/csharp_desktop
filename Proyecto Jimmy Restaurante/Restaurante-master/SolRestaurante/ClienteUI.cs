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
    public partial class ClienteUI : Form
    {
        ClienteBL cliente = new ClienteBL();
        string genero;

        public ClienteUI()
        {
            InitializeComponent();
        }
        private void btnGurdar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("¿Estás seguro que quiere agregar este cliente al sistema?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ClienteBL cliente = new ClienteBL();
                    if (cmbGenero.Text.Equals("Masculino"))
                        genero = "M";
                    else
                        genero = "F";

                    // cliente.Insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtCI.Text, txtDireccion.Text, mtxtTelefono.Text, Convert.ToInt32(npdEdad.Value), genero);
                    cliente.Insertar(txtNombre.Text, txtCI.Text, txtDireccion.Text, mtxtTelefono.Text, Convert.ToInt32(npdEdad.Value), genero);
                    this.ClienteUI_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere actualizar este cliente al sistema?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ClienteBL cliente = new ClienteBL();
                    if (cmbGenero.Text.Equals("Masculino"))
                        genero = "M";
                    else
                        genero = "F";

                    cliente.Actualizar(Convert.ToInt32(this.dtgCliente.CurrentRow.Cells[0].Value.ToString()), txtNombre.Text, txtCI.Text, txtDireccion.Text, mtxtTelefono.Text, Convert.ToInt32(npdEdad.Value), genero);
                    this.ClienteUI_Load(sender, e);
                }
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
                if (MessageBox.Show("¿Estás seguro que quiere eliminar este cliente del sistema?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                     ClienteBL cliente = new ClienteBL();
                    cliente.Eliminar(Convert.ToInt32(this.dtgCliente.CurrentRow.Cells[0].Value.ToString()));
                    this.ClienteUI_Load(sender, e);
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

   

        private void ClienteUI_Load(object sender, EventArgs e)
        {
            ClienteBL cliente = new ClienteBL();
            DataSet dsCliente = new DataSet();
            dsCliente = cliente.BuscarTodo();
            if (dsCliente.Tables.Count>0)
            {
                dtgCliente.DataSource= dsCliente.Tables[0];
                dtgCliente.AllowUserToAddRows = false;
               // dtgCliente.Columns[6].Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClienteBL cliente = new ClienteBL();
            DataSet dsCliente = new DataSet();
            dsCliente = cliente.BuscarId(Convert.ToInt32(this.dtgCliente.CurrentRow.Cells[0].Value.ToString()));
            if (dsCliente.Tables.Count > 0)
            {
                if (dsCliente.Tables[0].Rows.Count > 0)
                {
                    txtidentificador.Text = dsCliente.Tables[0].Rows[0][0].ToString();
                    txtNombre.Text = dsCliente.Tables[0].Rows[0][1].ToString();
                    txtCI.Text = dsCliente.Tables[0].Rows[0][2].ToString();
                    txtDireccion.Text = dsCliente.Tables[0].Rows[0][3].ToString();
                    mtxtTelefono.Text = dsCliente.Tables[0].Rows[0][4].ToString();
                    npdEdad.Value = Convert.ToDecimal(dsCliente.Tables[0].Rows[0][5].ToString());
                    cmbGenero.Text = dsCliente.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("No existe registro");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidentificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
