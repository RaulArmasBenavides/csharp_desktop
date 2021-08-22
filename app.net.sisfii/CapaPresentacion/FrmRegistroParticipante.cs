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

namespace CapaPresentacion
{
    public partial class FrmRegistroParticipante : Form
    {
        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        ParticipanteBll obj = new ParticipanteBll();
        public FrmRegistroParticipante()
        {
            InitializeComponent();
        }

        private void listaParticipantes()
        {
            dgvParticipantes.DataSource = obj.ParticipanteListar();

        }

        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.ParticipanteAdicionar(leerParticipante());
                        msg = "Participante registrado con éxito";
                        break;
                    case 2:
                        obj.ParticipanteActualizar(leerParticipante());
                        msg = "Participante actualizado con éxito";
                        break;
                    case 3:
                        obj.ParticipanteEliminar(leerParticipante2());
                        msg = "Participante eliminado con éxito";
                        break;
                    case 4:
                        consultarParticipante();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaParticipantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private usp_participantes_listar_all_Result leerParticipante()
        {
            var pro = new usp_participantes_listar_all_Result();
            pro.nombre = txtNombre.Text;
            pro.ap_paterno = txtappat.Text;
            pro.ap_materno = txtapmat.Text;
            pro.telefono = txtTelefono.Text;
            pro.correo = txtCorreo.Text;
            pro.DNI = txtDNI.Text;
            pro.sexo = cmbSexo.Text;
            pro.carrera = txtCarrera.Text;
            pro.direccion = txtDireccion.Text;
            pro.tipo_participante = cmbTipo.Text;
            //pro.idactividad = int.Parse(txtid.Text);
            //pro.descripcion = txtdescrip.Text;
            //pro.fecha = Convert.ToDateTime(dtFecha.Text);
            //pro.IdProveedor = (int)cboProveedor.SelectedValue;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //pro.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            //pro.UnidadesEnExistencia = Convert.ToInt16(numCantidad.Value);
            return pro;
        }


        private usp_participantes_listar_all_Result leerParticipante2()
        {
            //esta funcion sirve para encontrar a un objeto desde la grilla
            var pro2 = new usp_participantes_listar_all_Result();
            pro2.idparticipante = int.Parse(this.dgvParticipantes.CurrentRow.Cells[0].Value.ToString()); // int.Parse(txtid.Text)
            pro2.ap_paterno = this.dgvParticipantes.CurrentRow.Cells[1].Value.ToString();
            pro2.ap_materno = this.dgvParticipantes.CurrentRow.Cells[2].Value.ToString();
            pro2.nombre = this.dgvParticipantes.CurrentRow.Cells[3].Value.ToString();
            pro2.telefono = this.dgvParticipantes.CurrentRow.Cells[4].Value.ToString();
            pro2.sexo = this.dgvParticipantes.CurrentRow.Cells[5].Value.ToString();
            pro2.correo = this.dgvParticipantes.CurrentRow.Cells[6].Value.ToString();
            pro2.DNI = this.dgvParticipantes.CurrentRow.Cells[7].Value.ToString();
            pro2.carrera = this.dgvParticipantes.CurrentRow.Cells[8].Value.ToString();
            pro2.direccion = this.dgvParticipantes.CurrentRow.Cells[9].Value.ToString();
            pro2.tipo_participante = this.dgvParticipantes.CurrentRow.Cells[10].Value.ToString();
            // pro2.descripcion = this.dgvActividades.CurrentRow.Cells[1].Value.ToString(); //txtdescrip.Text;
            //  pro2.fecha = Convert.ToDateTime(this.dgvActividades.CurrentRow.Cells[2].Value.ToString()); //Convert.ToDateTime(txtfecha.Text);
            return pro2;
        }

        private void FrmRegistroParticipante_Load(object sender, EventArgs e)
        {
            listaParticipantes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere agregar este participante?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(1);
                listaParticipantes();
            }
        }

      
    

    private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar este participante?", "",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(2);
                listaParticipantes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea desactivar este participante?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(3);
                listaParticipantes();
            }
        }

        private void dgvParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }



        private void consultarParticipante()
        {
            var pro = obj.ParticipanteBuscar(leerDNIBuscar());
            if (pro != null)
            {
                txtfiltro.Text = pro.DNI;
                txtDNI.Text = pro.DNI;
                txtNombre.Text = pro.nombre;
                txtapmat.Text = pro.ap_materno;
                txtapmat.Text = pro.ap_paterno;
                txtCarrera.Text = pro.carrera;
                txtCorreo.Text = pro.correo;
                txtTelefono.Text = pro.telefono;
                txtDireccion.Text = pro.direccion;
                
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Este participante no se encuentra registrado o no existe", "Aviso");
                txtfiltro.SelectAll();
                txtfiltro.Focus();
            }
        }

        usp_participantes_listar_all_Result leerDNIBuscar()
        {
            usp_participantes_listar_all_Result pro = new usp_participantes_listar_all_Result();
            pro.DNI = txtfiltro.Text;
            return pro;
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }
    }
}
