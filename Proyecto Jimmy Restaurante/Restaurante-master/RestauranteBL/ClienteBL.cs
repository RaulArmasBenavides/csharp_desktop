using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestauranteDL;
using System.Data;

namespace RestauranteBL
{
    public class ClienteBL
    {
        ClienteDL cliente = new ClienteDL();

        public void Insertar(string nombre, string cedula, string direccion, string telefono, int edad, string genero)
        {
          //  cliente.IdCliente = id;
            cliente.NombreCliente = nombre;
            cliente.CedulaCliente = cedula;
            cliente.DirCliente = direccion;
            cliente.TelefonoCliente = telefono;
            cliente.EdadCliente = edad;
            cliente.GeneroCliente = genero;
            cliente.Insertar();
        }

        public void Actualizar(int id, string nombre, string cedula, string direccion, string telefono, int edad, string genero)
        {
            cliente.IdCliente = id;
            cliente.NombreCliente = nombre;
            cliente.CedulaCliente = cedula;
            cliente.DirCliente = direccion;
            cliente.TelefonoCliente = telefono;
            cliente.EdadCliente = edad;
            cliente.GeneroCliente = genero;
            cliente.Actualizar();
        }

        public void Eliminar(int id)
        {
            cliente.IdCliente = id;
            cliente.Eliminar();
        }

        public DataSet BuscarTodo()
        {
            return cliente.BuscarTodo();
        }

        public DataSet BuscarId(int id)
        {
            cliente.IdCliente = id;
            return cliente.BuscarId();
        }
    }
}
