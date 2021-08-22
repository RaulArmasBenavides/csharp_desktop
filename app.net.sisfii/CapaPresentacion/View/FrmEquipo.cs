using appcongreso.Controller;
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

        // INSTANCIAR OBJETO DE LA CLASE EquipoBll capa de negocio 
        EquipoBll obj = new EquipoBll();
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void equipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdcongresoDataSet);
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdcongresoDataSet.Equipo' table. You can move, or remove it, as needed.
            this.equipoTableAdapter.Fill(this.bdcongresoDataSet.Equipo);
        }

        private void equipoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere agregar este Equipo?", "",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(1);
                //listaEquipos();
            }
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
                      //  obj.EquipoActualizar(leerEquipo());
                        msg = "Equipo actualizado con éxito";
                        break;
                    case 3:
                       // obj.EquipoEliminar(leerEquipo2());
                        msg = "Equipo eliminado con éxito";
                        break;
                    case 4:
                        consultarEquipo();
                        return;
                }
                MessageBox.Show(msg, "éxito");
                //listaEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void consultarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
