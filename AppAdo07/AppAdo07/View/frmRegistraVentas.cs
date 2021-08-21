using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using AppAdo07.Controller;
using AppAdo07.Entity;

namespace AppAdo07.View
{
    public partial class frmRegistraVentas : Form
    {
        int id;
        public frmRegistraVentas(int index)
        {
            InitializeComponent();
            id = index;
        }

        #region Metodos
        void CargarCombos()
        {
            cboCliente.DataSource = VentaBll.ClienteListar();
            cboCliente.DisplayMember = "NombreCompañía";
            cboCliente.ValueMember = "idCliente";

            cboEmpleado.DataSource = VentaBll.EmpleadoListar();
            cboEmpleado.DisplayMember = "Empleado";
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.SelectedValue = id;
            cboEmpleado.Enabled = false;

            cboProducto.DataSource = VentaBll.ProductoListar();
            cboProducto.DisplayMember = "NombreProducto";
            cboProducto.ValueMember = "idProducto";
        }
        int stock;
        bool blnInicio;
        DataSet ds = new DataSet();
        DataTable tbDetalle;
        DataRow drw;
        decimal total = 0;

        void ConfigurarTabla()
        {
            tbDetalle = ds.Tables.Add();
            tbDetalle.Columns.Add("Codigo");
            tbDetalle.Columns.Add("Nombre");
            tbDetalle.Columns.Add("Precio");
            tbDetalle.Columns.Add("Cantidad");
            tbDetalle.Columns.Add("SubTotal");
            dgdDetalle.DataSource = tbDetalle;
        }

        void AgregarFila()
        {
            drw = tbDetalle.NewRow();
            drw["Codigo"] = txtCodigo.Text;
            drw["Nombre"] = cboProducto.Text;
            drw["Precio"] = txtPrecio.Text;
            drw["Cantidad"] = txtCantidad.Text;
            drw["SubTotal"] = txtSubTotal.Text;
            tbDetalle.Rows.Add(drw);
            total += decimal.Parse(txtSubTotal.Text);
            txtTotal.Text = total.ToString();
        }

        void EliminaFila()
        {
            if (tbDetalle.Rows.Count > 0)
            {
                total -= decimal.Parse((string)dgdDetalle.Rows[dgdDetalle.CurrentCell.RowIndex].Cells[4].Value);
                txtTotal.Text = total.ToString("N2");
                tbDetalle.Rows.RemoveAt(dgdDetalle.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Seleccionar fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int nFactura;
        void registrar()
        {
            Venta ve = new Venta();

            List<Detalle> lista = new List<Detalle>();

            foreach (DataRow item in tbDetalle.Rows)
            {
                Detalle d = new Detalle();
                d.IdProducto = Int32.Parse(item[0].ToString());
                d.Precio = decimal.Parse(item[2].ToString());
                d.Cantidad = Int32.Parse(item[3].ToString());
                d.Descuento = 0;
                lista.Add(d);
            }
            try
            {
                ve.IdCliente = cboCliente.SelectedValue.ToString();
                ve.IdEmpleado = (int)cboEmpleado.SelectedValue;
               
                ve.Monto = decimal.Parse(txtTotal.Text);
                ve.Item = lista;
                txtNro.Text = VentaBll.RegistrarVenta(ve).ToString();
                nFactura = int.Parse(txtNro.Text);
                MessageBox.Show("Venta registrada correctamente", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fatal");
            }
        }
        void NuevaVenta()
        {
            txtNro.Clear();
            txtTotal.Clear();
            tbDetalle.Rows.Clear();
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        void NuevoDetalle()
        {
            txtSubTotal.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigo.Clear();
            //cboProducto.SelectedIndex = -1;
        }

        #endregion

        private void frmRegistraVentas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarTabla();
            blnInicio = true;
            NuevaVenta();
        }



        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (blnInicio)
                {
                    int idpro = (int)cboProducto.SelectedValue;
                    SqlDataReader dr = VentaBll.DatosProducto(idpro);
                    dr.Read();
                    txtCodigo.Text = dr[0].ToString();
                    txtPrecio.Text = dr[1].ToString();
                    stock = Int32.Parse(dr[2].ToString());
                    txtCantidad.Text = "1";
                    txtCantidad.SelectAll();
                    txtCantidad.Focus();
                }

            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text != string.Empty)
                {
                    int cant = Int32.Parse(txtCantidad.Text);
                    if (cant < stock)
                    {
                        txtSubTotal.Text = (cant * decimal.Parse(txtPrecio.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Solo quedan " + stock.ToString() + " unidades en stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantidad.SelectAll();
                        txtCantidad.Focus();
                    }
                }
                else
                {
                    txtSubTotal.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtSubTotal.Text != "")
            {
                AgregarFila();
                NuevoDetalle();
            }
        }


        private void btnEliminaDetalle_Click(object sender, EventArgs e)
        {
            EliminaFila();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            registrar();
            NuevaVenta();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //frmReporte f = new frmReporte(nFactura);
            //f.ShowDialog();
        }
    }
}
