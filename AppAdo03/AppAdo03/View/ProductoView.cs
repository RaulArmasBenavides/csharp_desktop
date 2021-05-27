using AppAdo03.Controller;
using AppAdo03.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo03.View
{
    public partial class ProductoView : Form
    {
        public ProductoView()
        {
            InitializeComponent();
            listaProductos();
        }
        //instanciar objeto de la clase ProductoBLL
        ProductoBLL opro = new ProductoBLL();
        ProductoTO pro;

        private void listaProductos()
        {
            dgvProducto.DataSource = opro.ProductoListar();
        }

        private void ProductoView_Load(object sender, EventArgs e)
        {
            try
            {
                cargaCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargaCombos()
        {
            cboProveedor.DataSource = opro.ProveedorListar();
            cboProveedor.DisplayMember = "NombreCompañía";
            cboProveedor.ValueMember = "IdProveedor";

            cboCategoria.DataSource = opro.CategoriaListar();
            cboCategoria.DisplayMember = "NombreCategoría";
            cboCategoria.ValueMember = "IdCategoría";
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }


        private void procesar(int opcion)
        {
            int ok=0;
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        ok = opro.ProductoAdicionar(leeProducto());
                        msg = "Producto registrado con exito";
                        break;
                    case 2:
                        ok = opro.ProductoActualizar(leeProducto());
                        msg = "Producto actualizado con exito";
                        break;
                    case 3:
                        ok = opro.ProductoEliminar(leeProducto());
                        msg = "Producto eliminado con exito";
                        break;
                    case 4:
                        consultarProducto();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private void consultarProducto()
        {
            pro = opro.ProductoBuscar(txtCodigo.Text);
            if (pro!=null)
            {
                txtNombre.Text = pro.NombreProducto;
                cboProveedor.SelectedValue = pro.IdProveedor;
                cboCategoria.SelectedValue = pro.IdCategoria;
                txtPrecio.Text = pro.Precio.ToString();
                numCantidad.Value = pro.Stock;
            }
            else
            {
                MessageBox.Show("Producto no existe", "aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private ProductoTO leeProducto()
        {
            //crear objeto pro
            pro = new ProductoTO()
            {
                IdProducto=int.Parse(txtCodigo.Text),
                NombreProducto=txtNombre.Text,
                IdProveedor=(int)cboProveedor.SelectedValue,
                IdCategoria=(int)cboCategoria.SelectedValue,
                Precio=decimal.Parse(txtPrecio.Text),
                Stock=(int)numCantidad.Value
            };
            return pro;
        }
    }
}
