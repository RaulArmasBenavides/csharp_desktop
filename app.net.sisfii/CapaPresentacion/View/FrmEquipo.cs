using appcongreso.Clases;
using appcongreso.Controller;
using appcongreso.EF;
using appcongreso.Utils;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmEquipo : Form
    {

        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        EquipoBll obj = new EquipoBll();
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar este Equipo ?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                    listaEquipos();
                }
            }
        }


        private void listaEquipos()
        {
            dgvEquipos.DataSource = obj.EquipoListar();

        }

        private bool Validaciones(string tipo_accion)
        {
           // string mensaje = "";

            if (tipo_accion.Equals("C"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("El campo Nombre del Equipo es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            if (tipo_accion.Equals("U"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el Equipo que desea actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else
            if (tipo_accion.Equals("D"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el Equipo que desea desactivar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }


        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.EquipoAdicionar(leerEquipo());
                        msg = "Equipo registrado con éxito";
                        break;
                    case 2:
                        obj.EquipoActualizar(leerEquipo());
                        msg = "Equipo actualizado con éxito";
                        break;
                    case 3:
                        obj.EquipoEliminar(leerEquipo());
                        msg = "Equipo eliminado con éxito";
                        break;
                    case 4:
                        consultarEquipo();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }


        private usp_equipo_listar_all_Result leerEquipo()
        {
            var pro = new usp_equipo_listar_all_Result();
            if (!txtidequipo.Text.Equals(""))
                pro.idEquipo = Convert.ToInt32(txtidequipo.Text.ToString());
            pro.Nombre = txtNombre.Text.Trim();
            pro.Procesador = txtProcesador.Text.Trim();
            pro.RAM = txtRAM.Text.Trim();//cboTipoSala.Text;
            pro.SO = txtSO.Text.Trim();//(int)npdCapacidad.Value;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            pro.TarjetaMadre = txtTM.Text.Trim();// "SGIT";

            return pro;
        }

        private void consultarEquipo()
        {
            // var pro = obj.EquipoBuscar(leerNombreEquipoBuscar());
            var pro = obj.EquipoBuscar_Nombre(leerNombreEquipoBuscar());
            if (pro != null)
            {
                
                txtidequipo.Text = pro.idEquipo.ToString();
                txtNombre.Text = pro.Nombre;
                txtProcesador.Text = pro.Procesador;
                txtSO.Text = pro.SO;
                txtTM.Text = pro.TarjetaMadre;
                txtRAM.Text = pro.RAM;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;

                //activan los botones 
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Este Equipo no se encuentra registrada o no existe", "Aviso");
                txtNombre.SelectAll();
                txtNombre.Focus();
            }
        }

        usp_equipo_listar_all_Result leerNombreEquipoBuscar()
        {
            usp_equipo_listar_all_Result pro = new usp_equipo_listar_all_Result();
            pro.Nombre = txtNombre.Text.Trim();
           // pro.idEquipo = Convert.ToInt32(txtidequipo.Text);
            return pro;
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void LimpiaControles()
        {
            txtidequipo.Clear();
            txtNombre.Clear();
            txtProcesador.Clear();
            txtRAM.Clear();
            txtSO.Clear();
            txtTM.Clear();

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;    
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar este Equipo?", "",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("U"))
                {
                    procesar(2);
                    LimpiaControles();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea desactivar este Equipo?", "",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("D"))
                {
                    procesar(3);
                    LimpiaControles();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvEquipos.Rows.Count > 0)
                {
                    ImpresionExcel();
                }
                else
                {
                    MessageBox.Show("No existen detalles para exportar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel " + ex.Message, "error");
            }
        }

        private void ImpresionExcel()
        {
            dgvEquipos.SelectAll();
            DataObject copydata = dgvEquipos.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            LimpiaControles();
            listaEquipos();
        }

        private void LblBuscar_Click_1(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void LblLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirActividadGeneral(ImpresiónEquipo l)
        {

            DocumentoElectronico pdf = Imprimir(l);
            string ruta;
            //openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            //saveFileDialog1.
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtRuta.Text = openFileDialog.FileName;
            //}
            Stream myStream;
            //StreamWriter writer; 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = pdf.nombreArchivo;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllBytes(saveFileDialog1.FileName, pdf.archivoFisico);
                // Code to write the stream goes here.
                //myStream.Close();
                MessageBox.Show("Se imprimió el documento en pdf");
                Process.Start(saveFileDialog1.FileName);

            }
        }

        public DocumentoElectronico Imprimir(ImpresiónEquipo l)
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                DocumentoElectronico newdoc = new DocumentoElectronico();
                const string TITULO_MENSAJE_ERROR = "Imprimiendo orden de compra";
                string etapa = "INICIAL";
                byte[] archivoFisivo = null;

                pdf = ImprimirContenido(l);
                string nombre = "EQUIPO" + l.Nombre + ".pdf";
                string rutaArchivoMuestra = Path.GetTempPath() + nombre;

                pdf.Save(rutaArchivoMuestra);
                archivoFisivo = File.ReadAllBytes(rutaArchivoMuestra);

                //if (File.Exists(rutaArchivoMuestra))
                //{
                //    File.Delete(rutaArchivoMuestra);

                //}


                newdoc.nombreArchivo = nombre;
                newdoc.archivoFisico = archivoFisivo;
                return newdoc;
            }
            catch (Exception ex)
            {
                throw ex; //LogOC.LogErrorEx(ex.Message + "[Business][" + MethodBase.GetCurrentMethod().Name + "]", Tipos.TipoErrorControlado.Grave);
            }

            finally
            {

            }
        }

        private PdfDocument ImprimirContenido(ImpresiónEquipo l)
        {

            #region Declaración de variables

            //Documento a imprimir
            PdfDocument Documento = new PdfDocument();

            //tipo de fuentes 
            XFont xfontregular2 = new XFont("Arial", 11, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularVerdana = new XFont("Arial", 6, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularTahoma = new XFont("Tahoma", 6, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularTimes = new XFont("Times New Roman", 6, XFontStyle.Regular);
            XFont xfontregular = new XFont("Arial", 6.5, XFontStyle.Regular);  /*MS021020_20200521_KAB*/
            XFont xfontCuadroTitulo = new XFont("Tahoma", 8, XFontStyle.BoldItalic);
            XFont xfonttitulo = new XFont("Arial", 14, XFontStyle.Bold); //negrita 
            XFont xfontcabecera = new XFont("Arial", 11, XFontStyle.Bold); //negrita 
            XStringFormat format = new XStringFormat();

            //constantes 
            string Empresa;
            string FirmaLDS = "Firmas autorizadas de Luz del Sur S.A.A. ";
            string FirmaTecsur = "Firmas autorizadas de Tecsur S.A";
            string FirmaInland = "Firmas autorizadas de Inland Energy S.A.C";

            //marco 
            XRect rect = new XRect(40, 120 - 10, 790, 310);
            XUnit _bottomMargin;
            XUnit _topPosition;
            XUnit _currentPosition;

            PdfPage page = new PdfPage();
            PdfPage page2 = new PdfPage();
            XGraphics Gfx;
            XGraphics GfxPiePagina;
            int margenIzquierdo;
            Double ImporteTotal;
            int margenSuperior;
            int margenSuperiorCabeceraDetalle;
            int espaciohorizontal;
            int margenSuperiorPie;
            int ancholineaMotivo;
            int ancholinea;
            int altura;
            double cantidadLineaDetalle;
            string Motivo = string.Empty;
            bool salto = false;
            #endregion

            //configuración de la página 
            page = Documento.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Landscape;
            Gfx = XGraphics.FromPdfPage(page);
            page.Size = PdfSharp.PageSize.A4; // tamaño del papel
            format.LineAlignment = XLineAlignment.Center;

            //ancholinea = 46;//MS021020_20200812_RMAB
            ancholinea = 44;
            ancholineaMotivo = 60; //MS021020_20200502_RMAB
            int posIni = 0, posFin = 0;
            Double TotalGeneral = 0;
            int lineaRegistros = 0;
            margenIzquierdo = 40;
            margenSuperior = 40;
            margenSuperiorCabeceraDetalle = 120;
            margenSuperiorPie = 480;
            espaciohorizontal = 30;
            altura = 22; //MS021020_20200619_RMA


            //logo1
            //logoUNMSM = CapaPresentacion.Properties.Resources.UNMSM;
            //logoIcacit= CapaPresentacion.Properties.Resources.icacit;
            //logoFII = CapaPresentacion.Properties.Resources.fii;
            //MemoryStream strm = new MemoryStream();
            //logoFII.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);

            //XImage xlogo = XImage.FromStream(strm);
            //double x = (250 - xlogo.PixelWidth * 72 / xlogo.HorizontalResolution) / 2;

            //Gfx.DrawImage(xlogo, x, 40);

            //logoFII.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            //xlogo = XImage.FromStream(strm);
            //Gfx.DrawImage(xlogo, x + 40, 40);

            //logoIcacit.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            //xlogo = XImage.FromStream(strm);
            //Gfx.DrawImage(xlogo, x + 40, 40);


            //Gfx.DrawRectangle(XPens.Gray, rect);
            Gfx.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 24 * espaciohorizontal - 40, margenSuperior - 25));
            Gfx.DrawString("REPORTE DE LISTA DE EQUIPOS N° " + l.Nombre, xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior));
            Gfx.DrawString("Facultad de Ingeniería Industrial ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura));
            //Gfx.DrawString("Descripción de la actividad ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 2));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 2));
            //Gfx.DrawString("Fecha de inicio ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 3));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 3));
            //Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 4));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 4));
            //Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 5));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 5));
            //Gfx.DrawString("Responsable ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 6));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 6));

            //foreach (DataRow dr in l.dtListaEquipos.Rows)
            //{
            //    Gfx.DrawString(Convert.ToString(dr["Nombre"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 5, margenSuperiorCabeceraDetalle + altura));


            //    Gfx.DrawString(Convert.ToString(dr["SO"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + espaciohorizontal, margenSuperiorCabeceraDetalle + altura));
            //    Gfx.DrawString(Convert.ToString(dr["Procesador"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 3 * espaciohorizontal, margenSuperiorCabeceraDetalle + altura));

            //    altura = altura + 10;

            //}

            return Documento;
        }
    }
}
