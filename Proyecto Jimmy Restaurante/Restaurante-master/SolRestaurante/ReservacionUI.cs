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
    public partial class ReservacionUI : Form
    {
        DataSet dsClientes = new DataSet();
        public ReservacionUI()
        {
            InitializeComponent();
        }

        private void ReservacionUI_Load(object sender, EventArgs e)
        {
            ReservacionBL reservacion = new ReservacionBL();
            DataSet dsReservacion = new DataSet();
            dsReservacion = reservacion.BuscarTodo();
            if (dsReservacion.Tables.Count > 0)
            {
                dtgReservas.DataSource = dsReservacion.Tables[0];
                dtgReservas.AllowUserToAddRows = false;
                dtgReservas.Columns[1].Visible = false;
            }
            consultarClientes();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ReservacionBL menu = new ReservacionBL();

                menu.Insertar(Convert.ToInt32(txtIdReservacion.Text), Convert.ToInt32(cmbCliente.SelectedValue.ToString()), dtpFecha.Value, cmbEstado.Text);
                this.ReservacionUI_Load(sender, e);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Infracción"))
                {
                    MessageBox.Show("Clave Repetida");


                }
                else
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
        }
        public void consultarClientes() 
        {
            ClienteBL cliente = new ClienteBL();
            dsClientes = cliente.BuscarTodo();
            cmbCliente.DataSource = dsClientes.Tables[0];
            cmbCliente.ValueMember = "IDCLIENTE";
            cmbCliente.DisplayMember = "NOMBRECLIENTE";
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
