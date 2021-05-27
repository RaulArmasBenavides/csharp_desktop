using System;
using System.Windows.Forms;

namespace appcongreso.View
{
    public partial class ParticipanteView : Form
    {
        public ParticipanteView()
        {
            InitializeComponent();
        }

        void cargaListas()
        {
            cboProveedor.DataSource = obj.ProveedorListar();
            cboProveedor.DisplayMember = "NombreCompañía";
            cboProveedor.ValueMember = "IdProveedor";

            cboCategoria.DataSource = obj.CategoriaListar();
            cboCategoria.DisplayMember = "NombreCategoría";
            cboCategoria.ValueMember = "IdCategoría";
        }

        // INSTANCIAR OBJETO DE LA CLASE ParticipanteBll
        ParticipanteBll obj = new ParticipanteBll();

        private void ParticipanteView_Load(object sender, EventArgs e)
        {
            listaParticipantes();
            cargaListas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            procesar(1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            procesar(2);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            procesar(3);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //variable de la clase Participante
        usp_Participantes_Listar_Result pro;

        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.ParticipanteAdicionar(leerParticipante());
                       txtappaterno.Text = pro.IdParticipante.ToString();
                        msg = "Participante registrado con exito";
                        break;
                    case 2:
                        obj.ParticipanteActualizar(leerParticipante());
                        msg = "Participante actualizado con exito";
                        break;
                    case 3:
                        obj.ParticipanteEliminar(leerCodigo());
                        msg = "Participante eliminado con exito";
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
                MessageBox.Show(ex.Message,"error");
            }
            
        }

        private void consultarParticipante()
        {
            pro = obj.ParticipanteBuscar(leerCodigo());
            if (pro!=null)
            {
                txtNombre.Text = pro.NombreParticipante;
                txtCorreo.Text = pro.PrecioUnidad.ToString();
                cboProveedor.SelectedValue = pro.IdProveedor;
                cboCategoria.SelectedValue = pro.IdCategoría;
                numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Participante no existe", "Aviso");
                txtappaterno.SelectAll();
                txtappaterno.Focus();
            }
        }

        private void listaParticipantes()
        {
            dgvParticipante.DataSource = obj.ParticipanteListar();
        }

        private usp_Participantes_Listar_Result leerParticipante()
        {
            pro = new usp_Participantes_Listar_Result();

            pro.IdParticipante = int.Parse(txtappaterno.Text);
            pro.NombreParticipante = txtNombre.Text;
            pro.IdProveedor = (int)cboProveedor.SelectedValue;
            pro.IdCategoría = (int)cboCategoria.SelectedValue;
            pro.PrecioUnidad = decimal.Parse(txtCorreo.Text);
            pro.UnidadesEnExistencia = Convert.ToInt16(numCantidad.Value);           
            return pro;
        }

        private usp_Participantes_Listar_Result leerCodigo()
        {
            pro = new usp_Participantes_Listar_Result()
            {
                IdParticipante = int.Parse(txtappaterno.Text)               
            };
            return pro;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
