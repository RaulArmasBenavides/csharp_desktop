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
    public partial class frmProductosxCategoria : Form
    {
        public frmProductosxCategoria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmProductosxCategoria_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = new ProductoBll().CategoriaListar();
            cboCategoria.DisplayMember = "NombreCategoría";
            cboCategoria.ValueMember = "IdCategoría";
            cboCategoria_SelectedIndexChanged(sender,e);
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducto.DataSource = new ProductoBll().ProductoListar((int)cboCategoria.SelectedValue);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
