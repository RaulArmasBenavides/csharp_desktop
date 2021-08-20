using AppAdo04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo04.View
{
    public partial class ProductoView : Form
    {
        public ProductoView()
        {
            InitializeComponent();
        }
        //instanciar objeto de la clase constexto
        NeptunoEntities dc = new NeptunoEntities();

        private void ProductoView_Load(object sender, EventArgs e)
        {
            //var sql = from p in dc.Productos select p;
            //var sql = from p in dc.Productos where p.IdCategoría==5 select p;
            // var sql = from p in dc.Productos where p.NombreProducto.StartsWith("Cerveza") select p;

            //var sql = from p in dc.Productos select new { p.IdProducto,p.NombreProducto,p.PrecioUnidad,p.UnidadesEnExistencia };
            //dgvProducto.DataSource = sql.ToList();

            var sql = dc.usp_Productos_Listar();
            dgvProducto.DataSource = sql.ToList();

        }
    }
}
