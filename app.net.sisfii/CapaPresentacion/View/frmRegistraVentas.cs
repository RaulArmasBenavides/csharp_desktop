using System;
using System.Data;
using System.Windows.Forms;

namespace Neptuno.Venta.AppWind.Formularios
{
    public partial class frmRegistraVentas : Form
    {
        public frmRegistraVentas()
        {
            InitializeComponent();
        }

        #region Metodos
      //   private  VentaBll oVenta = new VentaBll();
         private DataSet Ds =new DataSet() ;
         private DataTable dtDetalle ;
         private DataRow drw;
         private decimal total=0;

         private int stk;

         void LlenarCombos()
         {
            // cboCliente.DataSource = oVenta.ClienteListar();
             cboCliente.DisplayMember = "NombreCompañía";
             cboCliente.ValueMember = "IdCliente";
            
            // cboEmpleado.DataSource = oVenta.EmpleadoListar();
             cboEmpleado.DisplayMember = "Empleado";
             cboEmpleado.ValueMember = "IdEmpleado";

             //cboProducto.DataSource = oVenta.ProductoListar();
             cboProducto.DisplayMember = "NombreProducto";
             cboProducto.ValueMember = "IdProducto";
         }

         private void ConfigurarTabla()
         {
             dtDetalle = Ds.Tables.Add();
             dtDetalle.Columns.Add("Codigo");
             dtDetalle.Columns.Add("Nombre");
             dtDetalle.Columns.Add("Precio");
             dtDetalle.Columns.Add("Cantidad");
             dtDetalle.Columns.Add("SubTotal");
             dgdDetalle.DataSource = dtDetalle;
         }

         private void AgregarFila()
         {
             drw = dtDetalle.NewRow();
             drw["Codigo"] = txtCodigo.Text;
             drw["Nombre"] = cboProducto.Text;
             drw["Precio"] = txtPrecio.Text;
             drw["Cantidad"] = txtCantidad.Text;
             drw["SubTotal"] = txtSubTotal.Text;
             dtDetalle.Rows.Add(drw);
             total += decimal.Parse(txtSubTotal.Text);
             txtTotal.Text = total.ToString();
         }

         private void EliminarFila()
         {

             if (dtDetalle.Rows.Count > 0)
             {
                 total -= decimal.Parse((string)dgdDetalle.Rows[dgdDetalle.CurrentCell.RowIndex].Cells[4].Value);
                 txtTotal.Text = total.ToString("N2");
                 dtDetalle.Rows.RemoveAt(dgdDetalle.CurrentCell.RowIndex);
             }
             else
             {
                 MessageBox.Show("Seleccionar fila");
             }
         }


        #endregion

        private void frmRegistraVentas_Load(object sender, EventArgs e)
        {
            try
            {
             LlenarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
            ConfigurarTabla();
            NuevaVenta();
        }

        private void NuevaVenta()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtNro.Clear();
            txtTotal.Clear();
            dtDetalle.Rows.Clear();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //int x =Convert.ToInt32(cboProducto.SelectedValue);
                //Producto pro = oVenta.ProductosPorCodigo(x);               
                //txtCodigo.Text = pro.IdProducto.ToString();
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //stk = pro.Stock;             
                //txtCantidad.Text = "1";
                //txtCantidad.SelectAll();
                //txtCantidad.Focus();
             }
            catch (Exception ex)
            {
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text != "")
                {
                    int cant = Int32.Parse(txtCantidad.Text);
                    if (cant<stk)
                    {
                        txtSubTotal.Text = (cant * decimal.Parse(txtPrecio.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Solo quedan: " + stk.ToString() + " unidades en stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
           }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFila();
            LimpiaControles();
        }

        private void LimpiaControles()
        {
            txtSubTotal.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigo.Clear();
            cboProducto.Focus();
        }

        private void btnEliminaDetalle_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Ventas o = new Ventas();

            //List<Detalle> detalle = new List<Detalle>();
            //foreach (DataRow item in dtDetalle.Rows)
            //{
            //    Detalle x = new Detalle();
            //    x.IdProducto = Convert.ToInt32(item[0].ToString());
            //    x.Precio = Convert.ToDecimal(item[2].ToString());
            //    x.Cantidad = Convert.ToInt32(item[3].ToString());
            //    detalle.Add(x);
            //}

            //try
            //{
            //o.IdCliente = cboCliente.SelectedValue.ToString();
            //o.IdEmpleado = (int)cboEmpleado.SelectedValue;
            //o.FechaVenta = DateTime.Parse(txtFecha.Text);
            //o.Monto = decimal.Parse(txtTotal.Text);
            //o.Item = detalle;
            //txtNro.Text = oVenta.RegistraVenta(o).ToString();// registra venta
            //MessageBox.Show("Gracias por su compra","exito",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            //NuevaVenta();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
