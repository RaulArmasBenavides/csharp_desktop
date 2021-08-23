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
                //txtdescrip.Text = pro.nombre;
                //txtidsala.Text = pro.idsala.ToString();
                //txtubi.Text = pro.ubicacion;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
                btnAgregar.Enabled = false;
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

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
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

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            listaEquipos();
        }

       
    }
}
