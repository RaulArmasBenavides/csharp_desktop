using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestauranteBL;
using SolRestaurante.Util;
using System.Globalization;

namespace SolRestaurante
{
    public partial class ReporteUI : Form
    {
        DataSet dsClientes = new DataSet();

        #region Declaración de variables
        private ImpresionEstandar t = null;
        FlujoCajaBo flujoBo = new FlujoCajaBo();
        #endregion



        public ReporteUI()
        {
            InitializeComponent();
        }
        private void ReservacionUI_Load(object sender, EventArgs e)
        {
            LeerDatos();
            //ReservacionBL reservacion = new ReservacionBL();
            //DataSet dsReservacion = new DataSet();
            //dsReservacion = reservacion.BuscarTodo();
            //if (dsReservacion.Tables.Count > 0)
            //{
            //    dtgMov.DataSource = dsReservacion.Tables[0];
            //    dtgMov.AllowUserToAddRows = false;
            //    dtgMov.Columns[1].Visible = false;
            //}
            //consultarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            documento.DefaultPageSettings.Landscape = true; 
            if (pdImpresion.ShowDialog() == DialogResult.OK)
            {
                pdImpresion.Document = documento;
                pdImpresion.PrinterSettings.Copies = 1;

            }
            documento.Print();

            MessageBox.Show("Se imprimieron los datos");
            //
            //    try
            //    {
            //        ReservacionBL menu = new ReservacionBL();

            //        menu.Insertar(Convert.ToInt32(txtIdReservacion.Text), Convert.ToInt32(cmbCliente.SelectedValue.ToString()), dtpFecha.Value, cmbEstado.Text);
            //        this.ReservacionUI_Load(sender, e);

            //    }
            //    catch (Exception ex)
            //    {
            //        if (ex.Message.Contains("Infracción"))
            //        {
            //            MessageBox.Show("Clave Repetida");
            //        }
            //        else
            //        {
            //            MessageBox.Show("ERROR:" + ex.Message);
            //        }
            //    }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerDatos();
        }

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            t = new ImpresionEstandar();
            t.PrintPage = ev;
            Bitmap bm = new Bitmap(this.dtgMov.Width, this.dtgMov.Height);
            dtgMov.DrawToBitmap(bm, new Rectangle(0, 0, this.dtgMov.Width, this.dtgMov.Height));
            ev.Graphics.DrawImage(bm, 0, 0);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            String line = null;


            Int32 margenIzquierdo = 100; //MAVB 50;
            Int32 margenSuperior = 38;
            double cantidadLineaDetalle = 0; //HECL               
            //t.EscribeTexto("REPORTE DE FLUJO DE CAJA ", margenIzquierdo + 250, margenSuperior);//RMAB
            t.PrintPage.Graphics.DrawString("REPORTE DE FLUJO DE CAJA", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo +250, margenSuperior));
            t.Fuente("Arial", 10, FontStyle.Regular);
            //t.EscribeTexto(txtruc.Text.ToString().Trim() + " " + txtproveedor.Text.ToString().Trim(), margenIzquierdo + 350, margenSuperior + 20);
            //t.EscribeTexto("Proveedor " + txtproveedor.Text.ToString().Trim(), margenIzquierdo + 350, margenSuperior + 20);
            //t.EscribeTexto("RUC " + txtruc.Text.ToString().Trim(), margenIzquierdo + 350, margenSuperior + 40);
    
            //DOrdenCompra.Nro_empresa = VariablesEntorno.idEmpresa.ToString().Trim();
            //DOrdenCompra.Nro_Folio = txtFolio.Text.ToString().Trim();
            //DOrdenCompra.Nro_Rut = txtruc.Text.ToString().Trim();
            //t.EscribeTexto(ProxyGlobal.ProxyRemoting.ObtenerDireccionProveedor(DOrdenCompra).ToString().Trim(), margenIzquierdo + 350, margenSuperior + 40);
            //t.EscribeTexto(ProxyGlobal.ProxyRemoting.ObtenerDireccionProveedor(DOrdenCompra).ToString().Trim(), margenIzquierdo + 350, margenSuperior + 60);
            //t.EscribeTexto(ProxyGlobal.ProxyRemoting.ObtenerDireccionProveedor(DOrdenCompra).ToString().Trim(), margenIzquierdo + 250, margenSuperior + 60);
            t.Fuente("Arial", 10, FontStyle.Regular);
            //MAVB t.EscribeTexto(lblFechaEmision.Text.ToString().Trim(), margenIzquierdo + 800, margenSuperior + 20);
            //t.EscribeTexto(lblFechaEmision.Text.ToString().Trim(), margenIzquierdo + 852, margenSuperior + 20);

            t.Fuente("Arial", 10, FontStyle.Regular);
            //MAVB t.EscribeTexto(Pagina + " de " + PaginaTotales, margenIzquierdo + 800, margenSuperior);
            //t.EscribeTexto(Pagina + " de " + PaginaTotales, margenIzquierdo + 852, margenSuperior);

            //MAVB margenSuperior = margenSuperior + 100;
            margenSuperior = margenSuperior + 115;

            Int32 contadorFila = 0;
            String Serie = "";
            String Matricula = "", MatriculaConca = "";
            //String Descripcion = "";
            String Plazo_Entrega = "";
            String Cantidad = "";
            String Unidad = "";
            String PrecioUnitario = "";
            String Importe = "";
            Double ImporteTotal = 0;



            t.PrintPage.Graphics.DrawString("N°", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo - 3, margenSuperior));
            t.PrintPage.Graphics.DrawString("Folio", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 25, margenSuperior));
            t.PrintPage.Graphics.DrawString("Descripción", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 95, margenSuperior));
            t.PrintPage.Graphics.DrawString("Fecha", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 526, margenSuperior));
            t.PrintPage.Graphics.DrawString("P.Unitario", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 780, margenSuperior));
            t.PrintPage.Graphics.DrawString("Unidad", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 712, margenSuperior));
            t.PrintPage.Graphics.DrawString("Cantidad", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 620, margenSuperior));
            t.PrintPage.Graphics.DrawString("Importe", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(margenIzquierdo + 870, margenSuperior));
            t.PrintPage.Graphics.FillRectangle(Brushes.Black, margenIzquierdo - 3, 900, 900, 3);
            t.PrintPage.Graphics.DrawLine(Pens.Black, margenIzquierdo - 3, margenSuperior, margenIzquierdo + 968, margenSuperior);//MS021002_20200328_RMAB


            margenSuperior = margenSuperior + 25;//RMAB desplazamos los detalles más abajo para que apareciera la cabecera del cuadro
            t.PrintPage.Graphics.DrawLine(Pens.Black, margenIzquierdo - 3, margenSuperior, margenIzquierdo + 968, margenSuperior);//MS021002_20200328_RMAB
            int ALTO_LINEASHORIZONTALES = 0;//espacio entra lineas horizontales 
                                            //t.EscribeTexto(String.Format(nfi, "{0:N}", Convert.ToDouble(PrecioUnitario)).PadLeft(13, (char)32), margenIzquierdo + 540, margenSuperior);
            DataTable dt = new DataTable();
            //dt = ProxyGlobal.ProxyRemoting.CargarDetalleOC(DOrdenCompra);
            Int32 lineaRegistros = dt.Rows.Count;
            Int32 lineaPorFormato = 26;
            Int32 lineasFaltantes = (lineaPorFormato - lineaRegistros);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;


            // Calculate the number of lines per page.
            //linesPerPage = ev.MarginBounds.Height /
            //   printFont.GetHeight(ev.Graphics);

            //Iterate over the file, printing each line.
            //while (count < linesPerPage &&
            //   ((line = streamToPrint.ReadLine()) != null))
            //{
            //    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            //    ev.Graphics.DrawString(line, printFont, Brushes.Black,
            //       leftMargin, yPos, new StringFormat());
            //    count++;
            //}

            //If more lines exist, print another page.
            //if (line != null)
            //    ev.HasMorePages = true;
            //else
            //    ev.HasMorePages = false;

        }




    }
}
