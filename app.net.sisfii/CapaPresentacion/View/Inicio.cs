using CapaDatos.View;
using CapaPresentacion.View;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();          
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditUsuarioView exd = new EditUsuarioView();
            exd.MdiParent = this;
            exd.Show();
            /*  Clientes f = new Clientes();
            f.MdiParent = this;
            f.Show();*/
        }

        //private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //   //   Clientes f = new Clientes();
        //   // DataCliente dc = new DataCliente();
        //   // dc.MdiParent = this;
        //   // f.Dispose();
        //   // dc.Show();


        //}

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  Image Foto;
            Candidato cand = new Candidato();
            Camara cam = new Camara("", "" , "", "", "", "", "", 0, "", "", "", "", "", cand);
            
            Foto = cam.Captura.Image;
            Candidato c = new Candidato(Foto, cam, "", "", "", "", "", "", "", -1, "radio4", "", "", "", "");
            c.MdiParent = this;
            c.Show();*/ 
        }

        private void castingToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //  if (Application.Current.Windows.OfType<FrmPonencias>().Count() == 0)
            //  {
            //    Agregar_Vendedor ventana_agregar_vendedor = new Agregar_Vendedor();
            //     ventana_agregar_vendedor.Show();
            //  }

            //EditUsuarioView exd = new EditUsuarioView();
            //exd.MdiParent = this;
            //exd.Show();
        }

        private void verTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //VerCandidatos v = new VerCandidatos();
           // v.MdiParent = this;
           // v.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VerPerfiles vp = new VerPerfiles();
            //vp.MdiParent = this;
            //vp.Show();
        }



        //Mantenedor de Salas
        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSala fr = new FrmSala();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmSala);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
            /*  EditarUsuario ed = new EditarUsuario();
              ed.MdiParent = this;
              ed.Show();
          */
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ContratarCasting c = new ContratarCasting();
            c.MdiParent = this;
            c.Show();*/
        }

        private void agenteDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Agente a = new Agente();
           // a.MdiParent = this;
           // a.Show();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
            //verCastings v = new verCastings();
           // v.MdiParent = this;
           // v.Show();
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroParticipante f = new FrmRegistroParticipante();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmRegistroParticipante);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void clientesActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesActivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//MostrarClienteReport m = new MostrarClienteReport();
  //          m.MdiParent = this;
    //        m.Show();
        }

        private void clientesInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MostrarClienteInactivoRep m = new MostrarClienteInactivoRep();
           // m.MdiParent = this;
           // m.Show();

        }

        private void candidatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // MostrarCandidatosRep m = new MostrarCandidatosRep();
           // m.MdiParent = this;
           // m.Show();
        }

        private void helpCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C://Users//Blutharsch//Documents//Visual Studio 2013//Projects//Casting//AyudaCasting.chm");
            Help.ShowHelp(this, "https://www.icacit.org.pe/web/es/");


        }

        private void agentesDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReporteAgente r = new ReporteAgente();
            r.MdiParent = this;
            r.Show();*/
        }

        private void castingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // CastingRepViewer crv = new CastingRepViewer();
          //  crv.MdiParent = this;
          //  crv.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades f = new FrmActividades();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmActividades);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stpVer_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(1);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void ponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(2);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void invitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(3);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void visitaNuestraWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "https://campusindustrial.unmsm.edu.pe/moodle/login/index.php");
     
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void mantenedorDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo fr = new FrmEquipo();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmEquipo);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsistencias fr = new FrmAsistencias();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmAsistencias);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEquipos fr = new FrmListaEquipos();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaEquipos);
            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }
            fr.MdiParent = this;
            fr.Show();

        }
    }
}
