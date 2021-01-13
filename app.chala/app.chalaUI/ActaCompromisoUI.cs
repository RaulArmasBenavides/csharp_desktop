using app.chala.negocios;
using com.app.comprobante.entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace proysustiCliente
{
    public partial class ActaCompromisoUI : Form
    {

        #region Declaracion de variables
        ChalaBo _boChala = null;
        ActaComprobanteTO ac = null;

        #endregion

        #region Métodos 
        //Constructor 
        public ActaCompromisoUI()
        {
            InitializeComponent();
            _boChala = new ChalaBo();
        }
        public void LeerDatos()
        {
         
            //actaBL acta = new actaBL();
            DataSet dsacta = new DataSet();
            dsacta = _boChala.LeerTodoActa();//acta.BuscarTodo();
            if (dsacta.Tables.Count > 0)
            {
                dtgacta.DataSource = dsacta.Tables[0];
                dtgacta.AllowUserToAddRows = false;
                // dtgacta.Columns[6].Visible = false;
            }
        }

       


        private void cargaCombos()
        {


            cmbPersonal.DataSource = _boChala.LeerTodoPersonal();//empleado.buscarTodo().Tables[0];//opro.ProveedorListar();
            cmbPersonal.DisplayMember = "ApePat";
            cmbPersonal.ValueMember = "IdPersonal";
            //cboProveedor.DisplayMember = "NombreCompañía";
            //cboProveedor.ValueMember = "IdProveedor";

            //cboCategoria.DataSource = opro.CategoriaListar();
            //cboCategoria.DisplayMember = "NombreCategoría";
            //cboCategoria.ValueMember = "IdCategoría";
        }
        #endregion



        #region Eventos 

        private void btnGurdar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("¿Estás seguro que quiere agregar esta acta de compromiso al sistema?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ac = new ActaComprobanteTO();
                    ac.NumAC = txtAC.Text;
                    ac.RDNum = txtRD.Text;
                    ac.Monto = Convert.ToDecimal(txtMonto.Text);
                    ac.Motivo = txtMotivo.Text;
                    ac.TipoGasto = cmbTipoGasto.Text;
                    ac.idPersonal = (int)cmbPersonal.SelectedValue;

                    _boChala.Insertar(ac);
                    LeerDatos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere actualizar este acta al sistema?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //acta.Actualizar(Convert.ToInt32(this.dtgacta.CurrentRow.Cells[0].Value.ToString()), txtNombre.Text, txtCI.Text, txtDireccion.Text, mtxtTelefono.Text, Convert.ToInt32(npdNumDias.Value), genero);
                    LeerDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro que quiere eliminar este acta del sistema?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //actaBL acta = new actaBL();
                    //acta.Eliminar(Convert.ToInt32(this.dtgacta.CurrentRow.Cells[0].Value.ToString()));
                    LeerDatos();    
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

   

        private void actaUI_Load(object sender, EventArgs e)
        {
            LeerDatos();
            cargaCombos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //actaBL acta = new actaBL();
            //DataSet dsacta = new DataSet();
            //dsacta = acta.BuscarId(Convert.ToInt32(this.dtgacta.CurrentRow.Cells[0].Value.ToString()));
            //if (dsacta.Tables.Count > 0)
            //{
            //    if (dsacta.Tables[0].Rows.Count > 0)
            //    {
            //        txtidentificador.Text = dsacta.Tables[0].Rows[0][0].ToString();
            //        txtNombre.Text = dsacta.Tables[0].Rows[0][1].ToString();
            //        txtCI.Text = dsacta.Tables[0].Rows[0][2].ToString();
            //        txtDireccion.Text = dsacta.Tables[0].Rows[0][3].ToString();
            //        mtxtTelefono.Text = dsacta.Tables[0].Rows[0][4].ToString();
            //        npdNumDias.Value = Convert.ToDecimal(dsacta.Tables[0].Rows[0][5].ToString());
            //        cmbTipoGasto.Text = dsacta.Tables[0].Rows[0][6].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No existe registro");
            //    }
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        #endregion 
    }
}
