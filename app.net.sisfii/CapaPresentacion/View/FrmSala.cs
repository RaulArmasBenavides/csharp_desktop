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
                        obj.SalaEliminar(leerSala2());
                        msg = "Sala eliminado con éxito";
                        break;
                    case 4:
                        //consultarProducto();
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

        private object leerSala()
        {
            throw new NotImplementedException();
        }
    }
}
