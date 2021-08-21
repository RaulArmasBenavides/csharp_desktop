using AppAdoNet07.Entity;
using AppAdoNet07.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppAdoNet07.Database;
using System.Transactions;

namespace AppAdoNet07.Model
{
    public class VentaDao : ITransaccion<Venta>
    {
        //instanciar objeto de la clase Conexion
        Conexion oCon = new Conexion();

        public int Registrar(Venta t)
        {
            int nroventa;

            using (TransactionScope trx = new TransactionScope())
            {
                try
                {
                    List<SqlParameter> lista = new List<SqlParameter>();
                    //crear objetos parametros para pasar al sp
                    SqlParameter idcli = new SqlParameter("@IdCliente", t.IdCliente);
                    SqlParameter idemp = new SqlParameter("@IdEmpleado", t.IdEmpleado);
                    SqlParameter fech = new SqlParameter("@Fecha", t.Fecha);
                    SqlParameter monto = new SqlParameter("@Monto", t.Monto);
                    //agregar los objetos parametros a la coleccion list
                    lista.Add(idcli);
                    lista.Add(idemp);
                    lista.Add(fech);
                    lista.Add(monto);
                    //ejecutar el sp
                    int result = oCon.runTransaccionStore("usp_registra_venta", lista);
                    nroventa = NumeroVenta(); //metodo genera idventa
                    //registro detalle
                    foreach (Detalle item in t.Item)
                    {
                        List<SqlParameter> lista1 = new List<SqlParameter>();
                        //objetos parametros del detalle
                        SqlParameter idventa = new SqlParameter("@IdVenta", nroventa);
                        SqlParameter idpro = new SqlParameter("@IdProducto", item.IdProducto);
                        SqlParameter pre = new SqlParameter("@Precio", item.Precio);
                        SqlParameter cant = new SqlParameter("@Cantidad", item.Cantidad);
                        //agregar objetos parametros a la coleccion lista1
                        lista1.Add(idventa);
                        lista1.Add(idpro);
                        lista1.Add(pre);
                        lista1.Add(cant);
                        //ejecuta sp de datalle
                        int x = oCon.runTransaccionStore("usp_registra_detalle", lista1);

                        List<SqlParameter> lista2 = new List<SqlParameter>();
                        //objetos parametros para el sp actualizar producto
                        SqlParameter idpro2 = new SqlParameter("@IdProducto", item.IdProducto);
                        SqlParameter cant2 = new SqlParameter("@Cantidad", item.Cantidad);
                        //agrega parametroa a la coleccion lista2
                        lista2.Add(idpro2);
                        lista2.Add(cant2);
                        //ejecuta sp actualiza producto
                        int z = oCon.runTransaccionStore("usp_actualiza_stock", lista2);
                    }
                    trx.Complete();//confirma que la transaccion se ha realizado correctamente
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            return nroventa;
           
        }

        private int NumeroVenta()
        {
            DataTable tb = oCon.runConsulta("Select Max(idPedido) from Pedidos");
            int nro = (int)tb.Rows[0][0];
            return nro;
        }

        public DataTable ListarCliente()
        {
            return oCon.runConsulta("Select idCliente,NombreCompañía from clientes order by nombrecompañía");
        }

        public DataTable EmpleadoListar()
        {
            return oCon.runConsulta("select idEmpleado,Empleado=apellidos+' ' + nombre from empleados order by Empleado");
        }
        public DataTable ProductoListar()
        {
            return oCon.runConsulta("select idProducto,NombreProducto from Productos order by nombreproducto");
        }

        public SqlDataReader ProductoDatos(int cod)
        {
            List<SqlParameter> lista = new List<SqlParameter>();
            SqlParameter idpro = new SqlParameter("@idproducto", cod);
            lista.Add(idpro);
            return oCon.runCursor("select idProducto,PrecioUnidad,UnidadesEnExistencia from Productos where idProducto=@idproducto", lista);
        }

    }
}
