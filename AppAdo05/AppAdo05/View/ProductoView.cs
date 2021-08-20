using AppAdo05.Controller;
using AppAdo05.DataBase;
using AppAdo05.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo05.View
{
    public partial class ProductoView : Form
    {
        public ProductoView()
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

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll
        ProductoBll obj = new ProductoBll();

        private void ProductoView_Load(object sender, EventArgs e)
        {
            listaProductos();
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

        //variable de la clase producto
        Producto pro;

        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.ProductoAdicionar(leerProducto());
                       txtCodigo.Text = pro.IdProducto.ToString();
                        msg = "Producto registrado con exito";
                        break;
                    case 2:
                        obj.ProductoActualizar(leerProducto());
                        msg = "Producto actualizado con exito";
                        break;
                    case 3:
                        obj.ProductoEliminar(leerCodigo());
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
                MessageBox.Show(ex.Message,"error");
            }
            
        }

        private void consultarProducto()
        {
            pro = obj.ProductoBuscar(leerCodigo());
            if (pro!=null)
            {
                txtNombre.Text = pro.NombreProducto;
                txtPrecio.Text = pro.PrecioUnidad.ToString();
                cboProveedor.SelectedValue = pro.IdProveedor;
                cboCategoria.SelectedValue = pro.IdCategoría;
                numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Producto no existe", "Aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private void listaProductos()
        {
            dgvProducto.DataSource = obj.ProductoListar();
        }

        private Producto leerProducto()
        {
            pro = new Producto();

            pro.IdProducto = int.Parse(txtCodigo.Text);
            pro.NombreProducto = txtNombre.Text;
            pro.IdProveedor = (int)cboProveedor.SelectedValue;
            pro.IdCategoría = (int)cboCategoria.SelectedValue;
            pro.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            pro.UnidadesEnExistencia = Convert.ToInt16(numCantidad.Value);           
            return pro;
        }

        private Producto leerCodigo()
        {
            pro = new Producto()
            {
                IdProducto = int.Parse(txtCodigo.Text)               
            };
            return pro;
        }

    }
}
