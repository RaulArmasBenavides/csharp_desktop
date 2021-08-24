using appcongreso.Controller;
using appcongreso.EF;
using appcongreso.Utils;
using CapaDatos.Controller;
using CapaPresentacion.Properties;
using CapaPresentacion.View;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CapaDatos.View
{
    public partial class FrmActividades : Form
    {
        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        ActividadBll obj = new ActividadBll();
        SalaBll salabll = new SalaBll();
        ListaEquiposBll listeqbll = new ListaEquiposBll();
        AsistenciasBll asisbll = new AsistenciasBll();
        usp_actividades_listar_all2_Result pro;
        //verPruebas v;
        public FrmActividades()
        {
            InitializeComponent();
            /*   this.Id = Id;
               this.v = v;*/
        }
        private void listaActividades()
        {
            //dgvActividades.DataSource = obj.actividadeListar();
            
        }
        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.actividadeAdicionar(leerActividad());
                        msg = "Actividad registrada con éxito";
                        break;
                    case 2:
                        obj.actividadeActualizar(leerActividad());
                        msg = "Actividad actualizada con éxito";
                        break;
                    case 3:
                        obj.actividadeEliminar(leerActividadAEliminar());
                        msg = "Actividad eliminada con éxito";
                        break;
                    case 4:
                       // var pro = new usp_BusquedaActividadforDescripcion_Result();
                        //string s = cboCriterio.SelectedItem.ToString();
                        //if (s == "Descripcion")
                        //{
                           
                        //    consultarActividad(1);
                        //}
                        //else if (s == "Fecha")
                        //{
                        //    //var pro = new usp_BusquedaActividadforDescripcion_Result();
                        //    //obj.actividadeBuscarporDescripcion(pro);
                        //    //consultarActividad(2,s);

                        //}

                        return;
                }
                MessageBox.Show(msg, "exito");
                listaActividades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private usp_BusquedaActividadforDescripcion_Result leerActividadParabuscar()
        {
            var pro = new usp_BusquedaActividadforDescripcion_Result();
            pro.descripcion = txtcodigo.Text;
            return pro;
        }


        private usp_actividades_listar_all2_Result leerIdentificador()
        {
            pro = new usp_actividades_listar_all2_Result()
            {   

               // IdProducto = int.Parse(txtCodigo.Text)
            };
            return pro;
        }


        private void consultarActividad( int num)
        {
            
            if (num == 1)
            {
                pro = new usp_actividades_listar_all2_Result();
                pro = obj.actividadeBuscarporDescripcion(leerIdentificador(num));
                
                {
                    if (obj != null)
                    {
                        txtnombreactividad.Text = pro.descripcion;
                        // txtNombre.Text = pro.NombreProducto;
                        // cboProveedor.SelectedValue = pro.IdProveedor;
                        // cboCategoria.SelectedValue = pro.IdCategoria;
                        // txtPrecio.Text = pro.Precio.ToString();
                        //  numCantidad.Value = pro.Stock;
                    }
                    else
                    {
                        MessageBox.Show("La actividad no se encuentra registrada en el sistema", "aviso");
                        txtcodigo.SelectAll();
                        txtcodigo.Focus();
                    }
                }
            }
            else
            if (num == 2)
            {
                pro = new usp_actividades_listar_all2_Result();
                pro = obj.actividadeBuscarporFecha(leerIdentificador(num));
                // obj = obj.actividadeBuscarporFecha(usp_BusquedaActividadforFecha_Result pro)
                {
                    if (obj != null)
                    {   
                       // dtFecha.Text = pro.fecha.toString();
                        txtnombreactividad.Text = pro.descripcion;
                        
                    }
                    else
                    {
                        MessageBox.Show("La actividad no se encuentra registrada en el sistema", "aviso");
                        txtcodigo.SelectAll();
                        txtcodigo.Focus();
                    }
                }


            }
        }

        private usp_actividades_listar_all2_Result leerIdentificador(int num)
        {
            
            if (num == 1) {
                pro = new usp_actividades_listar_all2_Result()
                {
                    descripcion = txtcodigo.Text
                };
            }
            else  if (num==2)
            {
                pro = new usp_actividades_listar_all2_Result()
                {
                    fecha_creacion = Convert.ToDateTime(txtcodigo.Text)
                };
            }
          
            return pro;
        }


        private usp_actividades_listar_all2_Result leerActividad()
        {
            var pro = new usp_actividades_listar_all2_Result();

            pro.Nombre = txtnombreactividad.Text.Trim();
            pro.descripcion = txtDescripcion.Text.Trim();
            pro.rol_responsable = txtrolresponsable.Text.Trim();
            pro.idsala = (int)cboSala.SelectedValue;
            pro.idasistencias = (int)cboAsistencias.SelectedValue;
            pro.idlistaeq = (int)cboListaEquipos.SelectedValue;
            pro.fec_inicio = dtpicker1.Value;
            pro.fec_Fin = dtpicker2.Value;
            pro.rol_creacion = "SGIT";
            //pro.idactividad = int.Parse(txtid.Text);
           //    pro.
         //   pro.descripcion = txtnombreactividad.Text;
            //pro.fecha_creacion = Convert.ToDateTime(dtFecha.Text);
            //   pro.IdProveedor = (int)cboProveedor.SelectedValue;
            //   pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //    pro.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            //   pro.UnidadesEnExistencia = Convert.ToInt16(numCantidad.Value);
            return pro;
        }
        private usp_actividades_listar_all2_Result leerActividadAEliminar()
        {
            //esta funcion sirve para encontrar a un objeto desde la grilla
            var pro2 = new usp_actividades_listar_all2_Result();
            pro2.idactividad = Convert.ToInt32(txtidActividades.Text);
            //pro2.idactividad = int.Parse(this.dgvActividades.CurrentRow.Cells[0].Value.ToString()); // int.Parse(txtid.Text);
            //pro2.descripcion = this.dgvActividades.CurrentRow.Cells[1].Value.ToString(); //txtdescrip.Text;
            //pro2.fecha_creacion = Convert.ToDateTime(this.dgvActividades.CurrentRow.Cells[2].Value.ToString()); //Convert.ToDateTime(txtfecha.Text);
            return pro2;
        }


        private void FrmActividades_Load(object sender, EventArgs e)
        {
            LimpiaControles();
            FormatearControles();
            CargarCombos();
            listaActividades();
        }

        private void FormatearControles()
        {
            dtpicker1.Format = DateTimePickerFormat.Custom;
            dtpicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpicker2.Format = DateTimePickerFormat.Custom;
            dtpicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpicker1.Value = DateTime.Now;
            dtpicker2.Value = DateTime.Now;
        }

        void CargarCombos()
        {
            List<usp_sala_listar_all_Result> lista = salabll.SalaListar();
            cboSala.DataSource = lista;
            cboSala.DisplayMember = "Nombre";
            cboSala.ValueMember = "idSala";


            List<usp_listaequipos_listar_all_Result> listaequipos = listeqbll.ListarAll2();
            cboListaEquipos.DataSource = listaequipos;
            cboListaEquipos.DisplayMember = "codigo";
            cboListaEquipos.ValueMember = "idlistaeq";

            List<usp_asistencias_listar_all_Result> listaasistencias = asisbll.ListarAll2();
            cboAsistencias.DataSource = listaasistencias;
            cboAsistencias.DisplayMember = "codigo";
            cboAsistencias.ValueMember = "idasistencias";
        }
   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           /* if (txtid.Text.Trim().Equals(""))
            {
                MetodosPerfiles m = new MetodosPerfiles();
                m.MostrarPerfiles(dgvActividades);
                return;
            }
            else
            {
                String Cad = "%" + txtid.Text + "%";
                if (comboBox1.SelectedIndex == 0)
                {
                    String query = " Select *From Candidatos_Perfiles WHERE [Nombre] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Apellido] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Tipo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Sexo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Procedencia] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color del pelo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color de los ojos] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                */
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere agregar esta actividad al sistema?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(1);
                listaActividades();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar esta actividad?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(2);
                listaActividades();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere eliminar esta actividad?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(3);
                listaActividades();
            }
        }

    
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListaEquipos_Click(object sender, EventArgs e)
        {
            //FrmListaEquipos f = new FrmListaEquipos();
            //f.ShowDialog();
            FrmListaEquipos fr = new FrmListaEquipos();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaEquipos);
            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }
            //fr.MdiParent = this;
            fr.ShowDialog();
            //internal
            if (!fr.txtidListaEquipo.Text.Equals(""))
            cboListaEquipos.Text = fr.txtidListaEquipo.Text;

        }

        private void btnListaAsistenci_Click(object sender, EventArgs e)
        {
            //FrmAsistencias f = new FrmAsistencias();
            //f.ShowDialog();
            FrmAsistencias fr = new FrmAsistencias();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmAsistencias);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

           // fr.MdiParent = this;
            fr.ShowDialog();
            //internal
            if (!fr.txtidListaAsistencias.Text.Equals(""))
            {

            }
                //cboText = fr.txtidListaAsistencias.Text;
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar esta Actividad ?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                    //listaEquipos();
                }
            }
        }

        private bool Validaciones(string tipo_accion)
        {
            // string mensaje = "";
            //// Calculate the interval between the two dates.
            //TimeSpan interval = dtpicker2.Value.Date- dtpicker1.Value.Date;

            if (dtpicker1.Value  > dtpicker2.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio de la actividad.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tipo_accion.Equals("C"))
            {
                if (txtcodigo.Text.Equals(""))
                {
                    MessageBox.Show("El campo código de la actividad es obligatorio para su creación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtnombreactividad.Text.Equals(""))
                {
                    MessageBox.Show("El campo nombre de la actividad es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDescripcion.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una descripción de la actividad", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            if (tipo_accion.Equals("U"))
            {
                if (txtnombreactividad.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar la actividad que desea actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else
            if (tipo_accion.Equals("D"))
            {
                if (txtnombreactividad.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar la actividad que desea anular", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void ImprimirActividadGeneral()
            {

                DocumentoElectronico pdf = Imprimir();
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

        public DocumentoElectronico Imprimir()
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                DocumentoElectronico newdoc = new DocumentoElectronico();
                const string TITULO_MENSAJE_ERROR = "Imprimiendo orden de compra";
                string etapa = "INICIAL";
                byte[] archivoFisivo = null;

                pdf = ImprimirContenido();
                string nombre = "ACTIVIDAD" + "" + ".pdf";
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

        private PdfDocument ImprimirContenido()
        {

            #region Declaración de variables

            //Documento a imprimir
            PdfDocument Documento = new PdfDocument();
            //Image logoUNMSM = null;
            //Image logoIcacit = null;
            //Image logoFII = null;
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
            Gfx.DrawString("ACTIVIDAD N° "  , xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior));
            //Gfx.DrawString("ORDEN DE COMPRA N° ", xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior));
            //Gfx.DrawString(" : ", xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior));
            Gfx.DrawString("Nombre de la actividad ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura));
            Gfx.DrawString("Descripción de la actividad ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 2));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 2));
            Gfx.DrawString("Fecha de inicio ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 3));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 3));
            Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 4));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 4));
            Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 5));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 5));
            Gfx.DrawString("Responsable ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 6));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 6));

            return Documento;
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            ImprimirActividadGeneral();
        }

        private void cboAsistencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void LimpiaControles()
        {
            txtnombreactividad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
           
            btnGrabar.Enabled = true;
            btnActualizar.Enabled = false;
            btnAnular.Enabled = false;
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            procesar(3);
        }
    }
    }

   
    
