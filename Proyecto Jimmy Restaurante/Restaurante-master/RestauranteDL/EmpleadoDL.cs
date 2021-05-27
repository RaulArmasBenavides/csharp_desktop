using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RestauranteDL
{
    public class EmpleadoDL
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador; //Obj que permite realizar el puente hacia la bdd
        SqlCommand comando;//parametriza todo el query, o store procedures
        DataSet dsDatos = new DataSet();// dataset sin tipo sirve para colocar todos los registros que traiga de la bdd q consulte
        string sentencia;


        public EmpleadoDL () 
        {
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=RestauranteMicrosoft;Integrated Security=True");
        }

        public void Insertar() 
       
        {
            try
            {
                // sentencia = "insert into Empleado  values (" + idEmp + ",'" + nombreEmp + "','" + generoEmp + "','" + cargoEmp + "','" + fechaNacEmp + "')";
                sentencia = "insert into Empleado values ('"  + nombreEmp + "','" + generoEmp + "','" + cargoEmp + "','" + fechaNacEmp + "')";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
                Console.WriteLine("Exito en la Operacion");
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }

        public void Actualizar() 
        
        {

            try
            {
                sentencia = "update Empleado set nombreEmp ='" + nombreEmp + "', generoEmp = '" + generoEmp + "', cargoEmp ='" + cargoEmp + "',fechaNacEmp ='" + fechaNacEmp + "' WHERE idEmp =" + idEmp;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;

            }

            finally 
            {
                conexion.Close();
            }
        }

        public void Eliminar() 
        
        {

            try
            {
                sentencia = "delete FROM Empleado WHERE idEmp =" + idEmp;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }


            finally
            {
                conexion.Close();
            }

        }

        public DataSet buscarTodo()
        {
            try
            {
                sentencia = " select * from Empleado ";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Empleado");
                return dsDatos;
                //conexion.Dispose();
            }

            catch (Exception ex)

            {
                throw ex;
            }

            finally
            { conexion.Close(); }

        }

        public DataSet buscarId()
        {
            try
            {
                sentencia = "select * from Empleado WHERE idEmp =" + idEmp;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);//para traer los datos
                adaptador.Fill(dsDatos, "Empleado"); // para llenar los datos
                conexion.Dispose();
                return dsDatos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally 
            { 
                conexion.Close(); 
            }

        }

        int idEmp;

        public int IdEmp
        {
            get { return idEmp; }
            set { idEmp = value; }
        }
        string nombreEmp;

        public string NombreEmp
        {
            get { return nombreEmp; }
            set { nombreEmp = value; }
        }
        string generoEmp;

        public string GeneroEmp
        {
            get { return generoEmp; }
            set { generoEmp = value; }
        }
        string cargoEmp;

        public string CargoEmp
        {
            get { return cargoEmp; }
            set { cargoEmp = value; }
        }
        DateTime fechaNacEmp;

        public DateTime FechaNacEmp
        {
            get { return fechaNacEmp; }
            set { fechaNacEmp = value; }
        }







    }
}
