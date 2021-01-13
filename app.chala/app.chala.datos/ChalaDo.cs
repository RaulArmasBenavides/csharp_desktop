using app.cochachi.datos.Database;
using app.cochachi.datos.Entidades;
using com.app.comprobante.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.cochachi.datos
{  //ESTA CLASE SE CONECTA CON LA BASE DE DATOS 
    public class ChalaDo
    {
        #region Variables 
        conexion con = new conexion();
        //SqlConnection conexion;
        SqlDataAdapter adaptador; //Obj que permite realizar el puente hacia la bdd
        SqlCommand comando;//parametriza todo el query, o store procedures
        DataSet dsDatos = new DataSet();// dataset sin tipo sirve para colocar todos los registros que traiga de la bdd q consulte
        string sSQL = string.Empty;
        conexion dbcon = new conexion();      
        #endregion

        #region constructor  
        //aqui vamos a poner la cadena de conexion 
        public ChalaDo()
        {
            
            //conexion = new SqlConnection("Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True");
        }
        #endregion

        #region Métodos 
        public void InsertarPersonal(Personal pe)
        {
            SqlConnection cn = null;
            try
            {
                sSQL = "";
                //armamos la sSQL 
                sSQL = "insert into Personal values ('" + pe.ApePat + "','" + pe.ApeMat + "','" + pe.Nombre1 + "','" + pe.Nombre2 + "','";
                sSQL = sSQL + pe.Nombre3 + "','" + pe.Domicilio + "','" + pe.Telf1 + "','" + pe.Telf2 + "','" + pe.Telf3 + "','" + pe.CtaAbono + "','" + pe.Correo + "', CAST('0x1234FFCD5' AS varBinary(MAX)))";
                cn = con.getConexion();
                cn.Open();
                //conexion.Open();
                comando = new SqlCommand(sSQL, cn);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                Console.WriteLine("Exito en la Operacion");
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null)
                    cn.Close();
                cn.Dispose();

                sSQL = "";
                con = null;
            }

        }
        public void InsertarActaComprobante(ActaComprobanteTO act)
        {
            SqlConnection cn = null;
            try
            {
                sSQL = "";
                sSQL = " insert into ActaDeCompromiso values ('" + act.NumAC + "','" + act.RDNum + "',TRY_CONVERT(DATE,'20/09/2020',103),'";
                sSQL = sSQL + act.TipoGasto + "'," + act.Monto.ToString() + ",'" + act.Motivo + "'," + act.NumDias.ToString() + ", TRY_CONVERT(DATE,'20/09/2020',103),TRY_CONVERT(DATE,'20/11/2020',103),TRY_CONVERT(DATE,'20/09/2020',103)," + act.idPersonal.ToString() + ")";
                cn = con.getConexion();
                cn.Open();
                //conexion.Open();
                comando = new SqlCommand(sSQL, cn);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                Console.WriteLine("Exito en la Operacion");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null)
                    cn.Close();
                cn.Dispose();

                sSQL = "";
                con = null;

            }
        }

        public DataSet LeerTodoPersonal()
        {
            //declaración de varaibles 
            SqlConnection cn = null;
            try
            {
                sSQL = "";
                sSQL = " select idPersonal,ApePat,ApeMat,Nombre1,Nombre2,Domicilio,Telf1,CtaAbono,email From Personal ";
                cn = con.getConexion();
                cn.Open();
                comando = new SqlCommand(sSQL, cn);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Personal");
                return dsDatos;

            }

            catch (Exception ex)

            {
                throw ex;
            }

            finally
            {
                if (cn != null)
                    cn.Close();
                cn.Dispose();

                sSQL = "";
                con = null;
            }

        }

        public DataSet LeerTodoActa()
        {  //declaración de varaibles 
            SqlConnection cn = null;
            try
            {
                sSQL = "";
                sSQL = " Select * from ActaDeCompromiso";
                cn = con.getConexion();
                cn.Open();
                comando = new SqlCommand(sSQL, cn);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "ActaDeCompromisos");
                return dsDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (cn != null)
                    cn.Close();
                cn.Dispose();

                sSQL = "";
                con = null;
            }
        }

        /*
        public void Actualizar(int id)
        {

            try
            {
                sSQL = "";
                //sSQL = "update Empleado set nombreEmp ='" + nombreEmp + "', generoEmp = '" + generoEmp + "', cargoEmp ='" + cargoEmp + "',fechaNacEmp ='" + fechaNacEmp + "' WHERE idEmp =" + idEmp;
                conexion.Open();
                comando = new SqlCommand(sSQL, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;

            }

            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public void Eliminar(int id)

        {

            try
            {
                sSQL = "";
                sSQL = "delete FROM Personal WHERE idEmp =" + id.ToString();
                conexion.Open();
                comando = new SqlCommand(sSQL, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }


            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }

        }

     

        public DataSet BuscarId(int id)
        {
            try
            {
                sSQL = "select * from Personal WHERE IdPersonal =" + id.ToString();
                conexion.Open();
                comando = new SqlCommand(sSQL, conexion);
                adaptador = new SqlDataAdapter(comando);//para traer los datos
                adaptador.Fill(dsDatos, "Empleado"); // para llenar los datos
                return dsDatos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }

        }*/
        #endregion

    }
}
