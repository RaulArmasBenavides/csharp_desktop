using appcongreso.Controller;
using appcongreso.EF;
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
        private decimal total = 0;

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        AsistenciasBll obj = new AsistenciasBll();

        public FrmAsistencias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFila();
            LimpiaControles();
        }


        private void AgregarFila()
        {
            drw = dtDetalle.NewRow();
            drw["Codigo"] = cboDNI.Text;
            drw["Nombre"] = txtappaterno.Text;
            drw["Precio"] = txtapmaterno.Text;
            drw["Cantidad"] = txtnombres.Text;
            //drw["SubTotal"] = txtSubTotal.Text;
            //dtDetalle.Rows.Add(drw);
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
            try
            {
                switch (opcion)
                {
                    case 1:
                       // obj.AsistenciaAdicionar(leerAsistencia());
                        msg = "Asistencia registrado con éxito";
                        break;
                    case 2:
                       // obj.AsistenciaActualizar(leerAsistencia());
                        msg = "Asistencia actualizado con éxito";
                        break;
                    case 3:
                      //  obj.AsistenciaEliminar(leerAsistencia());
                        msg = "Asistencia eliminado con éxito";
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
            FrmReporteAsistencia f = new FrmReporteAsistencia(txtCodigo.Text);
            f.ShowDialog();
        }
    }
}
