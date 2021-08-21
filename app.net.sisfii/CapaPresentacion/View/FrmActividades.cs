using appcongreso.EF;
using CapaDatos.Controller;
using System;
using System.Windows.Forms;

namespace CapaDatos.View
{
    public partial class FrmActividades : Form
    {
        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        ActividadBll obj = new ActividadBll();
        usp_actividades_listar_all_Result pro;
        //verPruebas v;
        public FrmActividades()
        {
            InitializeComponent();
            /*   this.Id = Id;
               this.v = v;*/
        }
        private void listaActividades()
        {
            dgvActividades.DataSource = obj.actividadeListar();
            
        }
        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.actividadeAdicionar(leerActividad());
                        msg = "Actividad registrada con éxito";
                        break;
                    case 2:
                        obj.actividadeActualizar(leerActividad());
                        msg = "Actividad actualizada con éxito";
                        break;
                    case 3:
                        obj.actividadeEliminar(leerActividad2());
                        msg = "Actividad eliminada con éxito";
                        break;
                    case 4:
                       // var pro = new usp_BusquedaActividadforDescripcion_Result();
                        string s = cboCriterio.SelectedItem.ToString();
                        if (s == "Descripcion")
                        {
                           
                            consultarActividad(1);
                        }
                        else if (s == "Fecha")
                        {
                            //var pro = new usp_BusquedaActividadforDescripcion_Result();
                            //obj.actividadeBuscarporDescripcion(pro);
                            //consultarActividad(2,s);

                        }

                        return;
                }
                MessageBox.Show(msg, "exito");
                listaActividades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private usp_BusquedaActividadforDescripcion_Result leerActividadParabuscar()
        {
            var pro = new usp_BusquedaActividadforDescripcion_Result();
            pro.descripcion = txtidentificador.Text;
            return pro;
        }


        private usp_actividades_listar_all_Result leerIdentificador()
        {
            pro = new usp_actividades_listar_all_Result()
            {   

               // IdProducto = int.Parse(txtCodigo.Text)
            };
            return pro;
        }


        private void consultarActividad( int num)
        {
            
            if (num == 1)
            {
                pro = new usp_actividades_listar_all_Result();
                pro = obj.actividadeBuscarporDescripcion(leerIdentificador(num));
                
                {
                    if (obj != null)
                    {
                        txtdescrip.Text = pro.descripcion;
                        // txtNombre.Text = pro.NombreProducto;
                        // cboProveedor.SelectedValue = pro.IdProveedor;
                        // cboCategoria.SelectedValue = pro.IdCategoria;
                        // txtPrecio.Text = pro.Precio.ToString();
                        //  numCantidad.Value = pro.Stock;
                    }
                    else
                    {
                        MessageBox.Show("La actividad no se encuentra registrada en el sistema", "aviso");
                        txtidentificador.SelectAll();
                        txtidentificador.Focus();
                    }
                }
            }
            else
            if (num == 2)
            {
                pro = new usp_actividades_listar_all_Result();
                pro = obj.actividadeBuscarporFecha(leerIdentificador(num));
                // obj = obj.actividadeBuscarporFecha(usp_BusquedaActividadforFecha_Result pro)
                {
                    if (obj != null)
                    {   
                       // dtFecha.Text = pro.fecha.toString();
                        txtdescrip.Text = pro.descripcion;
                        
                    }
                    else
                    {
                        MessageBox.Show("La actividad no se encuentra registrada en el sistema", "aviso");
                        txtidentificador.SelectAll();
                        txtidentificador.Focus();
                    }
                }


            }
        }

        private usp_actividades_listar_all_Result leerIdentificador(int num)
        {
            
            if (num == 1) {
                pro = new usp_actividades_listar_all_Result()
                {
                    descripcion = txtidentificador.Text
                };
            }
            else  if (num==2)
            {
                pro = new usp_actividades_listar_all_Result()
                {
                    fecha_creacion = Convert.ToDateTime(txtidentificador.Text)
                };
            }
          
            return pro;
        }


        private usp_actividades_listar_all_Result leerActividad()
        {
            var pro = new usp_actividades_listar_all_Result();
            //pro.idactividad = int.Parse(txtid.Text);
            pro.descripcion = txtdescrip.Text;
            pro.fecha_creacion = Convert.ToDateTime(dtFecha.Text);
            //   pro.IdProveedor = (int)cboProveedor.SelectedValue;
            //   pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //    pro.PrecioUnidad = decimal.Parse(txtPrecio.Text);
            //   pro.UnidadesEnExistencia = Convert.ToInt16(numCantidad.Value);
            return pro;
        }
        private usp_actividades_listar_all_Result leerActividad2()
        {
            //esta funcion sirve para encontrar a un objeto desde la grilla
            var pro2 = new usp_actividades_listar_all_Result();
            pro2.idactividad = int.Parse(this.dgvActividades.CurrentRow.Cells[0].Value.ToString()); // int.Parse(txtid.Text);
            pro2.descripcion = this.dgvActividades.CurrentRow.Cells[1].Value.ToString(); //txtdescrip.Text;
            pro2.fecha_creacion = Convert.ToDateTime(this.dgvActividades.CurrentRow.Cells[2].Value.ToString()); //Convert.ToDateTime(txtfecha.Text);
            return pro2;
        }


        private void FrmActividades_Load(object sender, EventArgs e)
        {
            /*  MetodosPerfiles m = new MetodosPerfiles();
              m.MostrarPerfiles(dataGridView1);
              toolStripStatusLabel1.Text = "Id de prueba: "+Id;
              comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
              comboBox1.SelectedIndex = 0;*/
            listaActividades();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           /* if (txtid.Text.Trim().Equals(""))
            {
                MetodosPerfiles m = new MetodosPerfiles();
                m.MostrarPerfiles(dgvActividades);
                return;
            }
            else
            {
                String Cad = "%" + txtid.Text + "%";
                if (comboBox1.SelectedIndex == 0)
                {
                    String query = " Select *From Candidatos_Perfiles WHERE [Nombre] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Apellido] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Tipo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Sexo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Procedencia] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color del pelo] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    String query = "Select *From Candidatos_Perfiles WHERE [Color de los ojos] like '" + Cad + "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dgvActividades);
                }
                */
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere agregar esta actividad al sistema?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(1);
                listaActividades();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar esta actividad?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(2);
                listaActividades();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere eliminar esta actividad?", "",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(3);
                listaActividades();
            }
        }

    
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }

  
       
    }
