using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Casting.Castings
{
    class MetodosCasting
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter sda;
        DataTable dt;


        public void MostrarClientes(DataGridView DataGrid)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                command = new SqlCommand("Select *From MostrarClientes", con);

                //Command.CommandType = System.Data.CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                DataGrid.DataSource = dt;
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }

            command.Dispose();
            con.Close();
        }//

        public void ClienteTipo(TextBox text, DataGridView d)
        {
            if (text.Text.Trim().Equals(""))
            {
                MostrarClientes(d);
                return;
            }
            try
            {
                String C = "%" + text.Text + "%";
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String Query = "SELECT *FROM MostrarClientes WHERE [Tipo de Cliente] like'" + C + "'";
                command = new SqlCommand(Query, con);

                command.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                d.DataSource = dt;
                command.Dispose();
                con.Close();
            }
            catch(SqlException sx)
            {
                MessageBox.Show(""+sx.ToString(), "");
            }
            }//


        public void ClienteNombre(TextBox text, DataGridView d)
        {
            if (text.Text.Trim().Equals(""))
            {
                MostrarClientes(d);
                return;
            }
            try
            {
                String C = "%" + text.Text + "%";
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String Query = "SELECT *FROM MostrarClientes WHERE [Nombre del cliente] like'" + C + "'";
                command = new SqlCommand(Query, con);

                command.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                d.DataSource = dt;
                command.Dispose();
                con.Close();
            }
            catch (SqlException sx)
            {
                MessageBox.Show("" + sx.ToString(), "");
            }
        }//


        public void GuardarAgente(string nombre, string apellido, string dir, string ced, string emp)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "GuardarAgente";
                command = new SqlCommand(query, con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NE", emp);
                command.Parameters.AddWithValue("@ced", ced);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dir", dir);
                command.Parameters.AddWithValue("@estado", "Activo");
                /*************************************************************************/
                command.ExecuteNonQuery();
                MessageBox.Show("Agente almacenado con éxito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            con.Close();
            command.Dispose();

        }//

        public void MostrarAgentes(DataGridView dta) {

            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "Select *From MostrarAgentes";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                /****************************************************/
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                /****************************************************/
                dta.DataSource = dt;
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            command.Dispose();
            con.Close();
        }//
        public void MostrarAgentesActivos(DataGridView dta)
        {

            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "Select *From MostrarAgentes where [Estado]='Activo'";
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                /****************************************************/
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                /****************************************************/
                dta.DataSource = dt;
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            command.Dispose();
            con.Close();
        }//


        public void LlenarCliente(int id, TextBox nombre, TextBox dir, TextBox tipo, TextBox tel)
        {
            try{
            con = new SqlConnection(CadCon.Servidor());
            con.Open();
            String query = "Select *From Clientes where Pk_cliente="+id;

                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                dt = new DataTable();
                sda= new SqlDataAdapter(command);
                sda.Fill(dt);

                /************************************************ */
                nombre.Text= dt.Rows[0][2].ToString();
                dir.Text = dt.Rows[0][3].ToString();
                tipo.Text = dt.Rows[0][4].ToString();
                tel.Text = dt.Rows[0][5].ToString();
            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }    
                
            command.Dispose();
            con.Close();
        }//

        public void LlenarAgente(int id, TextBox Nombre, TextBox Apellido, TextBox Emp, TextBox Ced) {

            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "Select *From Agente_casting where Pk_agente=" + id;

                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                /************************************************ */
                Nombre.Text = dt.Rows[0][4].ToString();
                Apellido.Text = dt.Rows[0][3].ToString();
                Emp.Text = dt.Rows[0][1].ToString();
                Ced.Text = dt.Rows[0][2].ToString();
            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }
            command.Dispose();
            con.Close();
        }


        public void GuardarCasting(int idCliente, int idAgente, string nombre, string descrip, double coste, int numper) {

            try{
            con = new SqlConnection(CadCon.Servidor());
            con.Open();
            String query = "GuardarCasting";
            String datosCasting = "Select *From Casting where Nombre ='"+nombre+"' AND Descrip='"+descrip
            +"'AND Coste="+coste+" AND Fk_cliente="+idCliente;

            command = new SqlCommand(query, con);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@fkcliente", idCliente);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@descrip", descrip);
            command.Parameters.AddWithValue("@coste", coste );

            int f=command.ExecuteNonQuery();
            if (f == 0)
            {
                MessageBox.Show("Datos de casting no encontrados", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   command = new SqlCommand(datosCasting, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                int idCasting = Convert.ToInt32(dt.Rows[0][0].ToString());

                command = new SqlCommand("GuardarPresencial", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Fk_casting", idCasting);
                command.Parameters.AddWithValue("@Fk_agente", idAgente);
                command.Parameters.AddWithValue("@num", numper);
                int rows = command.ExecuteNonQuery();

                if (rows !=0)
                {
                    MessageBox.Show("Procesado con éxito", "Operación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problemas con el servidor", "",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }///

            }//
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            con.Close();
            command.Dispose();
        }


        public void VerCastings(DataGridView d)
        {
            try { 
            con= new SqlConnection(CadCon.Servidor());
            con.Open();

            command = new SqlCommand("Select *From VistaCasting", con);
            command.ExecuteNonQuery();

            dt = new DataTable();
            sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            d.DataSource = dt;
            }
            catch (SqlException sx)
            {
                MessageBox.Show(sx.ToString());
            }
            con.Close();
            command.Dispose();
        }


        public void MostrarFase(int id, TextBox fase)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "Select count (*) From Fase where Fk_presencial="+id;
                string query2="Select *From Fase where Fk_presencial="+id+" ORDER BY Pk_fase Desc";
                command = new SqlCommand(query, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);

                int f = Convert.ToInt32(dt.Rows[0][0]);
                
             if (f ==0){ 
                fase.Text = "1";
                
                }else{

                    command = new SqlCommand(query2, con);
                    dt = new DataTable();
                    sda = new SqlDataAdapter(command);
                    sda.Fill(dt);

                    int nfase = Convert.ToInt32(dt.Rows[0][2]);
                    nfase = nfase + 1;
                    fase.Text = nfase.ToString();
                }
              
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            con.Close();
            command.Dispose();
        }//

        public void GuardarFase(int Id, int nfase) {
        try {
            con = new SqlConnection(CadCon.Servidor());
            con.Open();

            command = new SqlCommand("GuardarFase", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Fk_presencial", Id);
            command.Parameters.AddWithValue("@nfase", nfase);
            int rows=command.ExecuteNonQuery();

            if(rows==1){
                MessageBox.Show("Fase agregado la fase "+nfase+" al casting", "", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Si desea agregar pruebas a esta fase dirigirse a:\n"
                + "registro de todas las fases clickeando en el botón 'Todas' ", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Estamos experimentando fallas técnicas", "Mayday"); }

            con.Close();
            command.Dispose();

            }catch(SqlException sx){
              MessageBox.Show(""+sx.ToString());
            }
        }

        public void MostrarFase(int n, DataGridView d) {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                String query = "Select n_fase as 'No. de fase', fecha_inicio as 'Fecha de inicio', Pk_fase as 'Id de fase' "
                               +"from Fase where Fk_presencial="+n;
                
                command = new SqlCommand(query, con);
                int f = command.ExecuteNonQuery();

                dt = new DataTable();
                sda = new SqlDataAdapter(command);
                sda.Fill(dt);
                d.DataSource = dt;

            }
            catch (SqlException sx)
            {
                MessageBox.Show(""+sx.ToString());

            }
            con.Close();
            command.Dispose();
        }

        public void GuardarPrueba(int id, string sala, string descrip, string fecha)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();

                command = new SqlCommand("GuardarPrueba", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@fkfase", id);
                command.Parameters.AddWithValue("@sala", sala);
                command.Parameters.AddWithValue("@descrip", descrip);
                command.Parameters.AddWithValue("@fecha", fecha);
                int nrows = command.ExecuteNonQuery();

                if (nrows == 1)
                {
                    MessageBox.Show("Prueba agregada", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problemas al registrar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sx)
            {
                MessageBox.Show(sx.ToString());
                con.Close();
                command.Dispose();
            }
        }

            public void MostrarDetalles(int Id, TextBox cliente, TextBox dir, TextBox tipo, TextBox tel, TextBox numEmp, TextBox ced, TextBox nombre, TextBox apellido, TextBox dirAgente){
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();

                    String query = "Select *From Casting inner join Casting_presencial"
                    + " on Casting.Pk_casting= Casting_presencial.Fk_casting"
                    + " inner join Clientes on Casting.Fk_cliente= Clientes.Pk_cliente"
                    + " inner join Agente_casting on Agente_casting.Pk_agente= Casting_presencial.Fk_agente"
                    + " where Pk_casting=" + Id;

                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    dt = new DataTable();
                    sda = new SqlDataAdapter(command);
                    sda.Fill(dt);

                    /*******************************************************************/
                    cliente.Text = dt.Rows[0][12].ToString();
                    dir.Text = dt.Rows[0][13].ToString();
                    tipo.Text = dt.Rows[0][14].ToString();
                    tel.Text = dt.Rows[0][15].ToString();
                    numEmp.Text = dt.Rows[0][18].ToString();
                    ced.Text = dt.Rows[0][19].ToString();
                    nombre.Text = dt.Rows[0][20].ToString();
                    apellido.Text = dt.Rows[0][21].ToString();
                    dirAgente.Text = dt.Rows[0][22].ToString();
                }
                catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
                command.Dispose();
                con.Close();
            }

            public void MostrarPruebas(int Id, DataGridView d) {
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();

                    string query = "Select  Pk_prueba as 'Id de prueba', sala as 'Sala', descrip as 'Descripción',"
                      + " fecha as 'Fecha' From Pruebas where Fk_fase=" + Id;
                    command = new SqlCommand(query, con);

                  
                   
                        dt = new DataTable();
                        sda = new SqlDataAdapter(command);
                        sda.Fill(dt);
                        d.DataSource = dt;
                    
                }
                catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
                command.Dispose();
                con.Close();
            }

            public void ResultadoPrueba(int IdPrueba, int IdCandidato, string estado)
            {
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();
                    string query = "GuardarResultado";
                    string queryAct = "ActualizarResultado";
                    string comp = "Select count (*) From prueba_candidato where Fk_cand=" + IdCandidato + " AND fk_prueba="+IdPrueba;
                    command = new SqlCommand(comp, con);
                    dt = new DataTable();
                    sda = new SqlDataAdapter(command);
                    sda.Fill(dt);

                    int f = Convert.ToInt32(dt.Rows[0][0]);
                    
                    if(f==0){
                    command = new SqlCommand(query, con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@fkcand", IdCandidato);
                    command.Parameters.AddWithValue("@fkprueba", IdPrueba);
                    command.Parameters.AddWithValue("@estado", estado);
                    int rows=command.ExecuteNonQuery();
                    if (rows > 0) { 
                        MessageBox.Show("Alamcenado con éxito"); 
                    }
                    else
                    {
                        MessageBox.Show("Problemas al guardar");
                    }//

                    }else if(f>0){
                       if(MessageBox.Show("Ya existen resultados por parte de este candidato, desea actualizar?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){
                        string Id_prueba="Select *From prueba_candidato where Fk_cand=" + IdCandidato + " AND fk_prueba="+IdPrueba;
                        command = new SqlCommand(Id_prueba, con);
                        dt = new DataTable();
                        sda = new SqlDataAdapter(command);
                        sda.Fill(dt);

                        int result = Convert.ToInt32(dt.Rows[0][0]);
/*********************************************************************************************************************/
                        command = new SqlCommand(queryAct, con);
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@id", result);
                        command.Parameters.AddWithValue("@estado", estado);
                      
                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Resultado actualizado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Problemas al Actualizar resultados");
                        }//
                            }
                        else { return; }
                    }
                }
                catch (SqlException s) { MessageBox.Show(s.ToString()); }
                command.Dispose();
                con.Close();
            }

            public void MostrarDetalleAgente(int Id, TextBox Nombre, TextBox Apellido, TextBox nEmp, TextBox Ced, TextBox dir)
            {
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();

                    string query = "Select *From Agente_casting where Pk_agente=" + Id;
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();

                    dt = new DataTable();
                    sda = new SqlDataAdapter(command);
                    sda.Fill(dt);

                    nEmp.Text = dt.Rows[0][1].ToString();
                    Ced.Text = dt.Rows[0][2].ToString();
                    Nombre.Text = dt.Rows[0][3].ToString();
                    Apellido.Text = dt.Rows[0][4].ToString();
                    dir.Text = dt.Rows[0][5].ToString();
                }
                catch (SqlException sx)
                {
                    MessageBox.Show(""+sx.ToString());
                }
                command.Dispose();
                con.Close();

            }

            public void ActualizarAgente(int Id, string nombre, string apellido, string dir, string estado)
            {
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();

                    string query = "ActualizarAgente";
                    command = new SqlCommand(query, con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@dir", dir);
                    command.Parameters.AddWithValue("@estado", estado);
                    int r = command.ExecuteNonQuery();

                    if (r != 0) { MessageBox.Show("Agente actualizado exitosamente", "Información"); }
                
                }catch(SqlException sx){
                    MessageBox.Show(""+sx.ToString());
                }

                command.Dispose();
                con.Close();
            }
            public void InfoTextBox(int Id, TextBox IdContacto, TextBox Nombre, TextBox Apellido, TextBox Ced)
            {
                try
                {
                    con = new SqlConnection(CadCon.Servidor());
                    con.Open();

                    command = new SqlCommand("CargarDatosActualizar", con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Pk_cliente", Id);
                    command.ExecuteNonQuery();

                    dt = new DataTable();
                    sda = new SqlDataAdapter(command);
                    sda.Fill(dt);
                    /************************************************ */
                    IdContacto.Text = dt.Rows[0][5].ToString();
                    Nombre.Text = dt.Rows[0][6].ToString();
                    Apellido.Text = dt.Rows[0][7].ToString();
                    Ced.Text = dt.Rows[0][8].ToString();
                   /************************************************ */
                }
                catch (SqlException sx) { MessageBox.Show(""+sx.ToString()); }
                con.Close();
                command.Dispose();
            }
    }//
}
