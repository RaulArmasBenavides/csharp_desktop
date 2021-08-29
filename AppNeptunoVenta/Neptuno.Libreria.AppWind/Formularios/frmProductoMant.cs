using Neptuno.Libreria.Bussines;
using Neptuno.Libreria.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Neptuno.Libreria.AppWind.Formularios
{
    public partial class frmProductoMant : Form
    {
        public frmProductoMant()
        {
            InitializeComponent();
        }

        #region Metodos
    // instanciar objeto de las clases
        ProductoBll obj = new ProductoBll();

        Producto oProd = new Producto();

        void LlenarListas()
        {
            cboProveedor.DataSource = obj.ListarProveedores();
            cboProveedor.DisplayMember = "NombreCompañía";
            cboProveedor.ValueMember = "IdProveedor";

            cboCategoria.DataSource = obj.ListarCategorias();
            cboCategoria.DisplayMember = "NombreCategoría";
            cboCategoria.ValueMember = "IdCategoría";
        }

        void cargaGrilla()
        {
            dgdProducto.DataSource = obj.Listar();
        }

        #endregion
    
        private void frmProductoMant_Load(object sender, EventArgs e)
        {
            LlenarListas();
            cargaGrilla();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            oProd.NombreProducto = txtNombre.Text;
            oProd.IdProveedor= (int)cboProveedor.SelectedValue;
            oProd.IdCategoria =(int) cboCategoria.SelectedValue;
            oProd.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            oProd.Stock = Int16.Parse(numCantidad.Value.ToString());
            try
            {
                int id = obj.ProductoAdicionar(oProd);
                if (id>0)
                {
                    txtCodigo.Text = id.ToString();
                    MessageBox.Show("Producto registrado con exito", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargaGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oProd.IdProducto= Int32.Parse(txtCodigo.Text);
            oProd.NombreProducto = txtNombre.Text;
            oProd.IdProveedor = (int)cboProveedor.SelectedValue;
            oProd.IdCategoria = (int)cboCategoria.SelectedValue;
            oProd.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            oProd.Stock = Int16.Parse(numCantidad.Value.ToString());
            try
            {
                if (obj.ProductoActualizar(oProd) > 0)
                {
                    MessageBox.Show("Producto actualizado con exito", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargaGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oProd.IdProducto = Int32.Parse(txtCodigo.Text);
            try
            {
                if (obj.ProductoEliminar(oProd) > 0)
                {
                    MessageBox.Show("Producto eliminado con exito", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cargaGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();
            pro.IdProducto = Int32.Parse(txtCodigo.Text);

            pro = obj.ConsultarProductosPorCodigo(pro);
            if (pro!=null)
            {
            txtCodigo.Text = pro.IdProducto.ToString();
            txtNombre.Text = pro.NombreProducto;
            cboProveedor.SelectedValue = pro.IdProveedor;
            cboCategoria.SelectedValue = pro.IdCategoria;
            txtPrecio.Text = pro.PrecioUnidad.ToString();
            numCantidad.Value = Int32.Parse(pro.Stock.ToString());
            }
            else
            {
                MessageBox.Show("Producto no exite", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
