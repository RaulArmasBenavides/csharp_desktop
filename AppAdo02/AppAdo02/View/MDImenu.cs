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
    public partial class MDImenu : Form
    {
        public MDImenu()
        {
            InitializeComponent();
        }

        private void productosTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosTodo f = new frmProductosTodo();
            f.MdiParent = this;
            f.Show();
        }

        private void productosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosxNombre f = new frmProductosxNombre();
            f.MdiParent = this;
            f.Show();
        }

        private void productosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosxCategoria f = new frmProductosxCategoria();
            f.MdiParent = this;
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
