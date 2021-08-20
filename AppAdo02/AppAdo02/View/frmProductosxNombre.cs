using AppAdo02.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo02.View
{
    public partial class frmProductosxNombre : Form
    {
        public frmProductosxNombre()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducto.DataSource = new ProductoBll().ProductoListar(txtNombre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
