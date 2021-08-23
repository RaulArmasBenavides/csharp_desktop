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
    public partial class FrmListaEquipos : Form
    {

        private DataSet Ds = new DataSet();
        private DataTable dtDetalle;
        private DataRow drw;
        // private decimal total = 0;

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        ListaEquiposBll obj = new ListaEquiposBll();
        EquipoBll eq = new EquipoBll();
        public FrmListaEquipos()
        {
            InitializeComponent();
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        // obj.EquipoAdicionar(leerEquipo());
                        msg = "Equipo registrado con éxito";
                        break;
                    case 2:
                        // obj.EquipoActualizar(leerEquipo());
                        msg = "Equipo actualizado con éxito";
                        break;
                    case 3:
                        //  obj.EquipoEliminar(leerEquipo());
                        msg = "Equipo eliminado con éxito";
                        break;
                    case 4:
                        consultarListaDeEquipos();
                        return;
                }
                MessageBox.Show(msg, "exito");
                //listaEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void LimpiaControles()
        {
            txtCodigo.Text = "";
            txtEstado.Text = "";
            dgvEquipos.DataSource = null;
            dgvEquipos.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(validarRegistroCelda())
            {
                AgregarFila();
               // LimpiaControles();
            }
            else
            {
                MessageBox.Show("Este Equipo ya ha sido registrado en la grilla");
            }
           
        }

        public bool validarRegistroCelda()
        {

            if (dgvEquipos.Rows.Count > 0)
            {
                foreach (DataGridViewRow Row in dgvEquipos.Rows)
                {
                    string Valor = Convert.ToString(Row.Cells["Nombre"].Value);

                    if (Valor == cboDNI.Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void AgregarFila()
        {
            drw = dtDetalle.NewRow();
            drw["Codigo"] = cboDNI.Text;
            //drw["Nombre"] = txtNombre.Text;
            //drw["Precio"] = txtapmaterno.Text;
            //drw["Cantidad"] = txtnombres.Text;
            //drw["SubTotal"] = txtSubTotal.Text;
            //dtDetalle.Rows.Add(drw);
            //total += decimal.Parse(txtSubTotal.Text);
            //txtTotal.Text = total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }

        private void EliminarFila()
        {

            if (dtDetalle.Rows.Count > 0)
            {
                // total -= decimal.Parse((string)dgvEquipos.Rows[dgvEquipos.CurrentCell.RowIndex].Cells[4].Value);
                //txtTotal.Text = total.ToString("N2");
                dtDetalle.Rows.RemoveAt(dgvEquipos.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Usted debe seleccionar una fila de la grilla");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void cboDNI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
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

        private void consultarListaDeEquipos()
        {

            //cabecera 


            //detalle 
            List<usp_lista_equipos_oficial_Result> pro = obj.ListaEquipoCodigo(leerListaEquipos());
            if (pro != null)
            {
                dgvEquipos.DataSource = pro;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Esta lista de equipos no se encuentra registrada o no existe. Por favor ingrese un código válido", "Aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private usp_lista_equipos_oficial_Result leerListaEquipos()
        {
            var pro = new usp_lista_equipos_oficial_Result();
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

        private void FrmListaEquipos_Load(object sender, EventArgs e)
        {
           ConfigurarTabla();
           CargarCombos();
        }

        private void ConfigurarTabla()
        {
            dtDetalle = Ds.Tables.Add();
            dtDetalle.Columns.Add("idlistaeq");
            dtDetalle.Columns.Add("idEquipo");
            dtDetalle.Columns.Add("codigo");
            dtDetalle.Columns.Add("Nombre");
            dtDetalle.Columns.Add("Procesador");
            dtDetalle.Columns.Add("RAM");
            dtDetalle.Columns.Add("SO");
            dtDetalle.Columns.Add("TarjetaMadre");
            // dtDetalle.Columns.Add("SubTotal");
            dgvEquipos.DataSource = dtDetalle;
        }


        void CargarCombos()
        {
            List<usp_equipo_listar_all_Result> lista = eq.EquipoListar();
            cboDNI.DataSource = lista;//oVenta.ClienteListar();
            cboDNI.DisplayMember = "Nombre";
            cboDNI.ValueMember = "idEquipo";

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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel " + ex.Message, "error");
            }

        }
    }
}
