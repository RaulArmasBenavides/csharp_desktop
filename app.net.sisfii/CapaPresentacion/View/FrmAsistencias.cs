using appcongreso.Controller;
using appcongreso.EF;
using CapaDatos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmAsistencias : Form
    {

        private DataSet Ds = new DataSet();
        private DataTable dtDetalle;
        private DataRow drw;

        // private decimal total = 0;

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        AsistenciasBll obj = new AsistenciasBll();
        ParticipanteBll partici = new ParticipanteBll();

        public FrmAsistencias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(validarRegistroCelda())
            { 
               AgregarFila();
            }
            else
            {
                MessageBox.Show("Este participante ya ha sido registrado en la grilla");
            }
        }

        public bool validarRegistroCelda()
        {
            if(dgvAsistencias.Rows.Count>0)
            {
                foreach (DataGridViewRow Row in dgvAsistencias.Rows)
                {
                    string Valor = Convert.ToString(Row.Cells["DNI"].Value);

                    if (Valor == cboDNI.Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ConfigurarTabla()
        {
            dtDetalle = Ds.Tables.Add();
            dtDetalle.Columns.Add("DNI");
            dtDetalle.Columns.Add("ap_paterno");
            dtDetalle.Columns.Add("ap_materno");
            dtDetalle.Columns.Add("codigo");
           // dtDetalle.Columns.Add("SubTotal");
            dgvAsistencias.DataSource = dtDetalle;
        }
        private void AgregarFila()
        {
            drw = dtDetalle.NewRow();
            drw["DNI"] = cboDNI.Text;
            drw["ap_paterno"] = txtappaterno.Text;
            drw["ap_materno"] = txtapmaterno.Text;
            drw["codigo"] = txtCodigo.Text;
            dtDetalle.Rows.Add(drw);
            //drw["SubTotal"] = txtSubTotal.Text;
            //total += decimal.Parse(txtSubTotal.Text);
            //txtTotal.Text = total.ToString();
        }



        private void EliminarFila()
        {

            if (dtDetalle.Rows.Count > 0)
            {
               // total -= decimal.Parse((string)dgvAsistencias.Rows[dgvAsistencias.CurrentCell.RowIndex].Cells[4].Value);
                //txtTotal.Text = total.ToString("N2");
                dtDetalle.Rows.RemoveAt(dgvAsistencias.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Usted debe seleccionar una fila");
            }
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();

        }

        private void LimpiaControles()
        {
            txtCodigo.Text = "";
            txtnombres.Text = "";
            txtEstado.Text = "";
            txtapmaterno.Text = "";
            txtappaterno.Text = "";
            dgvAsistencias.DataSource = null;
            dgvAsistencias.Refresh();
        }


        private void procesar(int opcion)
        {
            string msg = "";
            List<usp_asistencias_Result> items = new List<usp_asistencias_Result>();
            try
            {
              
                switch (opcion)
                {
                    case 1:
                        // obj.AsistenciaAdicionar(leerAsistencia());
                      
                        foreach (DataGridViewRow dr in dgvAsistencias.Rows)
                        {
                            usp_asistencias_Result res = new usp_asistencias_Result();
                            res.DNI = Convert.ToString(dr.Cells["DNI"].Value);
                            res.ap_paterno = Convert.ToString(dr.Cells["ap_paterno"].Value);
                            res.ap_materno = Convert.ToString(dr.Cells["ap_materno"].Value);
                            res.codigo = txtCodigo.Text.Trim();
                            items.Add(res);
                        }
                        obj.RegistrarListaAsistentes(txtCodigo.Text.Trim(), items, true);
                        msg = "Lista de Asistencia registrado con éxito";
                        break;
                    case 2:
                        // obj.AsistenciaActualizar(leerAsistencia());
                        // ACTUALIZAR
                        foreach (DataGridViewRow dr in dgvAsistencias.Rows)
                        {
                            usp_asistencias_Result res = new usp_asistencias_Result();
                            res.DNI = Convert.ToString(dr.Cells["DNI"].Value);
                            res.ap_paterno = Convert.ToString(dr.Cells["ap_paterno"].Value);
                            res.ap_materno = Convert.ToString(dr.Cells["ap_materno"].Value);
                            res.codigo = txtCodigo.Text.Trim();
                            items.Add(res);
                        }
                        obj.RegistrarListaAsistentes(txtCodigo.Text.Trim(), items, false);
                        msg = "Lista de Asistencia actualizado con éxito";
                        break;
                    case 3:
                      //  obj.AsistenciaEliminar(leerAsistencia());
                        msg = "Lista de Asistencia anulada con éxito";
                        break;
                    case 4:
                        consultarAsistencia();
                        return;
                }
                MessageBox.Show(msg, "exito");
                //listaAsistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }


        private void consultarAsistencia()
        {

            //cabecera 

            
            //detalle 
            List<usp_asistencias_Result> pro = obj.ListaAsistenciaCodigo(leerListaAsistencia());
            if (pro != null)
            {
                dgvAsistencias.DataSource = pro;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Esta lista de asistencia no se encuentra registrada o no existe. Por favor ingrese un código válido", "Aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private usp_asistencias_Result leerListaAsistencia()
        {
            var pro = new usp_asistencias_Result();
            pro.codigo = txtCodigo.Text.Trim();
            //if (!txtidAsistencia.Text.Equals(""))
            //    pro.idAsistencia = Convert.ToInt32(txtidAsistencia.Text.ToString());
            //pro.nombre = txtdescrip.Text;
            //pro.ubicacion = txtubi.Text;
            //pro.tipo_Asistencia = cboTipoAsistencia.Text;
            //pro.capacidad = (int)npdCapacidad.Value;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //pro.rol_creacion = "SGIT";
            return pro;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //frmReporte f = new frmReporte(nFactura);
            //FrmReporteAsistencia f = new FrmReporteAsistencia(txtCodigo.Text);
            //f.ShowDialog();
        }

        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            //test
            //txtidListaAsistencias.Text = "1";
            ConfigurarTabla();
            CargarCombos();
        }

        void CargarCombos()
        {
            List<usp_participantes_listar_all_Result> lista = partici.ParticipanteListar();
            cboDNI.DataSource = lista;//oVenta.ClienteListar();
            cboDNI.DisplayMember = "DNI";
            cboDNI.ValueMember = "DNI";

            //foreach(usp_participantes_listar_all_Result item in lista)
            //{

            //}
            // cboEmpleado.DataSource = oVenta.EmpleadoListar();
            //cboEmpleado.DisplayMember = "Empleado";
            //cboEmpleado.ValueMember = "IdEmpleado";

            //cboProducto.DataSource = oVenta.ProductoListar();
            //cboProducto.DisplayMember = "NombreProducto";
            //cboProducto.ValueMember = "IdProducto";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                procesar(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error al registrar la lista de asistencia " + ex.Message, "error");
            }

        }

  
    }
}
