using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDemoWPF02.Service;
using AppDemoWPF02.Entity;
using System.IO;
using System.Windows;

namespace AppDemoWPF02.Model
{
    public class ProductoDaoFile : ICrudDao<Producto>
    {
        // variables
        private string archivo = @"..\..\Productos.dat";
        private FileStream fs;
        private BinaryReader br;
        private BinaryWriter bw;
        private string datos;

        //constructor
        public ProductoDaoFile()
        {
            if (!File.Exists(archivo))
            {
                //crear objeto de la clase FileStream
                fs = new FileStream(archivo, FileMode.Create, FileAccess.Write);
                fs.Close();
                MessageBox.Show("Archivo creado con exito !");
            }
        }

        //metodos de persistencia de datos en archivo .dat

        public void create(Producto o)
        {
            try
            {
                //abrir archivo para escritura
                fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                //crear objeto para escribir datos en el archivo
                bw = new BinaryWriter(fs);
                //escribir datos en el archivo
                bw.Write(o.ID);
                bw.Write(o.Nombre);
                bw.Write(o.Categoria);
                bw.Write(o.Proveedor);
                bw.Write(o.Precio);
                bw.Write(o.Stock);
                //cerrar archivo
                bw.Close();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            finally
            {
                fs.Close();
            }
        }

        public void delete(Producto o)
        {

        }

        public Producto findForId(int o)
        {
            Producto pro1 = null;
            try
            {
                if (File.Exists(archivo))
                {
                    //abrir archivo para lectura
                    fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                    //crear objeto para leer datos del archivo
                    br = new BinaryReader(fs);
                    do
                    {
                       Producto pro = new Producto()
                        {
                            ID = br.ReadInt32(),
                            Nombre = br.ReadString(),
                            Categoria = br.ReadString(),
                            Precio = br.ReadDecimal(),
                            Stock = br.ReadInt32(),
                            Proveedor = br.ReadString()

                       };
                        if (pro.ID==o)
                        {
                            pro1 = pro;
                        }                       

                    } while (true);
                }
                else
                {
                    MessageBox.Show("Archivo no existe");
                }
            }
            catch (IOException ex)
            {
                //throw ex;
            }
            finally
            {
                br.Close();
                fs.Close();
            }         
            return pro1;
        }

        public List<Producto> readAll()
        {
            List<Producto> lproducto = new List<Producto>();
            try
            {
                if (File.Exists(archivo))
                {
                    //abrir archivo para lectura
                    fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                    //crear objeto para leer datos del archivo
                    br = new BinaryReader(fs);
                    do
                    {
                        Producto pro = new Producto()
                        {
                            ID = br.ReadInt32(),
                            Nombre = br.ReadString(),
                            Categoria = br.ReadString(),     
                            Precio = br.ReadDecimal(),
                            Stock = br.ReadInt32(),
                           Proveedor = br.ReadString()
                        };

                        lproducto.Add(pro);

                    } while (true);
                }
                else
                {
                    MessageBox.Show("Archivo no existe");                    
                }
            }
            catch (IOException ex)
            {
                //throw ex;
            }
            finally
            {
                br.Close();
                fs.Close();
            }
            return lproducto;
        }

        public void update(Producto o)
        {

        }
    }
}
