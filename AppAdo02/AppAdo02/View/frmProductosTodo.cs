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
    public partial class frmProductosTodo : Form
    {
        public frmProductosTodo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmProductosTodo_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = new ProductoBll().ProductoListar();
        }
    }
}
