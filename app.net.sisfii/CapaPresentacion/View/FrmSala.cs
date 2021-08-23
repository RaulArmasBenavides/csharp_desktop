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

namespace CapaDatos.View
{
    public partial class FrmSala : Form
    {
        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        SalaBll obj = new SalaBll();
        public FrmSala()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar esta sala ?", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                    LimpiaControles();
                    listaSalas();
                }
            }
        }

        private bool Validaciones( string tipo_accion)
        {
            //string mensaje = "";

            if (tipo_accion.Equals("C"))
            {
                    if (txtdescrip.Text.Equals(""))
                {
                    MessageBox.Show("El campo Descripción es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtubi.Text.Equals(""))
                {
                    MessageBox.Show("El campo Ubicación es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            if (tipo_accion.Equals("U"))
            {
                if (txtdescrip.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar la sala que desea actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else
            if (tipo_accion.Equals("D"))
            {
                if (txtdescrip.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar la sala que desea desactivar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }


        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.SalaAdicionar(leerSala());
                        msg = "Sala registrado con éxito";
                        break;
                    case 2:
                        obj.SalaActualizar(leerSala());
                        msg = "Sala actualizado con éxito";
                        break;
                    case 3:
                        obj.SalaEliminar(leerSala());
                        msg = "Sala eliminado con éxito";
                        break;
                    case 4:
                        consultarSala();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaSalas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private usp_sala_listar_all_Result leerSala()
        {
            var pro = new usp_sala_listar_all_Result();
            if(!txtidsala.Text.Equals(""))
            pro.idsala = Convert.ToInt32(txtidsala.Text.ToString());
            pro.nombre = txtdescrip.Text;
            pro.ubicacion = txtubi.Text;
            pro.tipo_sala = cboTipoSala.Text;
            pro.capacidad = (int)npdCapacidad.Value;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            pro.rol_creacion = "SGIT";
            //pro.ap_paterno = txtappat.Text;
            //pro.ap_materno = txtapmat.Text;
            //pro.telefono = txtTelefono.Text;
            //pro.correo = txtCorreo.Text;
            //pro.DNI = txtDNI.Text;
            //pro.sexo = cmbSexo.Text;
            //pro.carrera = txtCarrera.Text;
            //pro.direccion = txtDireccion.Text;
            //pro.tipo_participante = cmbTipo.Text;
            return pro;
        }
        


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea desactivar esta sala?", "",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("D"))
                {
                    procesar(3);
                    LimpiaControles();
                    listaSalas();
                }
              
            }
        }

        private void listaSalas()
        {
            dgvSalas.DataSource = obj.SalaListar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar esta sala?", "",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("U"))
                {
                    procesar(2);
                    LimpiaControles();
                    listaSalas();
                 }
            }
        }

        private void dgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void consultarSala()
        {
            var pro = obj.SalaBuscar(leerNombreSalaBuscar());
            if (pro != null)
            {
                txtdescrip.Text = pro.nombre;
                txtidsala.Text = pro.idsala.ToString();
                txtubi.Text = pro.ubicacion;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
                btnAgregar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Esta sala no se encuentra registrada o no existe", "Aviso");
                txtfiltro.SelectAll();
                txtfiltro.Focus();
            }
        }

        usp_sala_listar_all_Result leerNombreSalaBuscar()
        {
            usp_sala_listar_all_Result pro = new usp_sala_listar_all_Result();
            pro.nombre = txtdescrip.Text.Trim();
            return pro;
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            listaSalas();
        }


        private void LimpiaControles()
        {
            txtdescrip.Text = "";
            txtubi.Text = "";
            txtfiltro.Text = "";
            npdCapacidad.Value = 0;
            cboTipoSala.SelectedIndex = -1;
            btnAgregar.Enabled = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSalas.SelectAll();
                DataObject copydata = dgvSalas.GetClipboardContent();
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
