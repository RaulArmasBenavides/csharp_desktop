﻿using appcongreso.Controller;
using appcongreso.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.View
{
    public partial class FrmSala : Form
    {
        bdcongresoEntities c = new bdcongresoEntities();

        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        SalaBll obj = new SalaBll();
        public FrmSala()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar esta sala ?", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(1);
                listaSalas();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }


        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.SalaAdicionar(leerSala());
                        msg = "Sala registrado con éxito";
                        break;
                    case 2:
                        obj.SalaActualizar(leerSala());
                        msg = "Sala actualizado con éxito";
                        break;
                    case 3:
                        obj.SalaEliminar(leerSala());
                        msg = "Sala eliminado con éxito";
                        break;
                    case 4:
                        consultarSala();
                        return;
                }
                MessageBox.Show(msg, "exito");
                //listaSalas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private usp_sala_listar_all_Result leerSala()
        {
            var pro = new usp_sala_listar_all_Result();
            if(!txtidsala.Text.Equals(""))
            pro.idsala = Convert.ToInt32(txtidsala.Text.ToString());
            pro.nombre = txtdescrip.Text;
            pro.tipo_sala = cboTipoSala.Text;
            pro.capacidad = (int)npdCapacidad.Value;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            pro.rol_creacion = "SGIT";
            //pro.ap_paterno = txtappat.Text;
            //pro.ap_materno = txtapmat.Text;
            //pro.telefono = txtTelefono.Text;
            //pro.correo = txtCorreo.Text;
            //pro.DNI = txtDNI.Text;
            //pro.sexo = cmbSexo.Text;
            //pro.carrera = txtCarrera.Text;
            //pro.direccion = txtDireccion.Text;
            //pro.tipo_participante = cmbTipo.Text;
            return pro;
        }
        


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea desactivar esta sala?", "",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(3);
               
            }
        }

 

        private void listaSalas()
        {
            dgvSalas.DataSource = obj.SalaListar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar esta sala?", "",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                procesar(2);
                listaSalas();
            }
        }

        private void dgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }


        private void consultarSala()
        {
            var pro = obj.SalaBuscar(leerNombreSalaBuscar());
            if (pro != null)
            {
                txtdescrip.Text = pro.nombre;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;
            }
            else
            {
                MessageBox.Show("Esta sala no se encuentra registrada o no existe", "Aviso");
                txtfiltro.SelectAll();
                txtfiltro.Focus();
            }
        }

        usp_sala_listar_all_Result leerNombreSalaBuscar()
        {
            usp_sala_listar_all_Result pro = new usp_sala_listar_all_Result();
            pro.nombre = txtfiltro.Text;
            return pro;
        }
    }
}