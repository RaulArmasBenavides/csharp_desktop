using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Casting.Castings
{
    

    class MetodosNav
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable dt;

        public void Buscar(string query, DataGridView d) {

            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();

                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                /********************************************************************************/
                d.DataSource = dt;
            }
            catch (SqlException sx)
            {
                MessageBox.Show("Problemas en la base de datos: "+sx.ToString(), "Houston...");
            }

            command.Dispose();
            con.Close();
        }//

        public void ResultadosPrueba(int IdPrueba, DataGridView d) {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();

                command = new SqlCommand("ResultadosPrueba", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idPrueba", IdPrueba);
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                d.DataSource = dt;
            }
            catch (SqlException sx) { MessageBox.Show(""+sx.ToString()); }
            command.Dispose();
            con.Close();
        
        }

        public void MostrarDetCasting(int IdCasting, TextBox Nombre, TextBox desc, TextBox costo)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                string query = "Select *From Casting where Pk_casting=" + IdCasting;
                command = new SqlCommand(query, con);

                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                Nombre.Text = dt.Rows[0][2].ToString();
                desc.Text = dt.Rows[0][3].ToString();
                costo.Text = dt.Rows[0][4].ToString();

            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            finally { command.Dispose();
                      con.Close();
            }

        }

        public bool ActualizarCasting(int IdCasting, string Nombre, string desc, double Costo)
        {
            try {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();

                command = new SqlCommand("ActualizarCasting", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                /*******************************************/
                command.Parameters.AddWithValue("@idCasting", IdCasting);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@descrip", desc);
                command.Parameters.AddWithValue("@coste", Costo);
                int f = command.ExecuteNonQuery();

                if (f != 0) { MessageBox.Show("Actualizado con éxito");
                              return true;
                } else {
                    return false;
                }
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            con.Close();
            command.Dispose();
            return false;
        }


    }
}
