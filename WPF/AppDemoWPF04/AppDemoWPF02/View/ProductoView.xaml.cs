using AppDemoWPF02.Controller;
using AppDemoWPF02.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppDemoWPF02.View
{
    /// <summary>
    /// Lógica de interacción para ProductoView.xaml
    /// </summary>
    public partial class ProductoView : Window
    {
        public ProductoView()
        {
            InitializeComponent();
            verProducto();
        }

        //instanciar objeto de la clase ProductoBll
        ProductoBll obj = new ProductoBll();

        //cariable de la clase producto
        Producto pro;

        private void verProducto()
        {
            dgdProducto.ItemsSource = null;
            dgdProducto.ItemsSource = obj.ProductoListar();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            procesar(4);
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            procesar(1);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            procesar(2);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            procesar(3);
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void procesar(int v)
        {
            string msg = "";
            switch (v)
            {
                case 1:
                    obj.ProductoAdicionar(leerDatos());
                    msg = "Producto registrado con exito";
                    break;
                case 2:
                    obj.ProductoActualizar(leerDatos());
                    msg = "Producto actualizado con exito";
                    break;
                case 3:
                    obj.ProductoEliminar(leerDatos());
                    msg = "Producto eliminado con exito";
                    break;
                case 4:
                    mostrarProducto();
                    return;
            }
            MessageBox.Show(msg, "exito");
            verProducto();
        }

        private void mostrarProducto()
        {
            pro = obj.ProductoBuscar(int.Parse(txtCodigo.Text));
            if (pro != null)
            {
                txtNombre.Text = pro.Nombre;
                txtPrecio.Text = pro.Precio.ToString();
                txtCantidad.Text = pro.Stock.ToString();
                cboCategoria.Text = pro.Categoria;
                cboCategoria.Text = pro.Proveedor;
            }
            else
            {
                MessageBox.Show("Producto no existe", "aviso");
            }
        }

        private Producto leerDatos()
        {
            //crear objeto pro
            pro = new Producto();
            //asignar valores al objeto pro
            pro.ID = int.Parse(txtCodigo.Text);
            pro.Nombre = txtNombre.Text;
            pro.Categoria = cboCategoria.Text;
            pro.Precio = decimal.Parse(txtPrecio.Text);
            pro.Stock = int.Parse(txtCantidad.Text);
            pro.Proveedor = cboProveedor.Text;
            return pro;
        }

        
    }

}
