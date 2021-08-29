namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stpVer = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaNuestraWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.castingToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1186, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripSeparator4,
            this.CerrarSesionToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShowShortcutKeys = false;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.clientesToolStripMenuItem.Text = "Usuarios";
            this.clientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Checked = true;
            this.agregarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.agregarToolStripMenuItem.Text = "&Modificar Cuenta";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
            this.toolStripSeparator4.Click += new System.EventHandler(this.toolStripSeparator4_Click);
            // 
            // CerrarSesionToolStripMenuItem
            // 
            this.CerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem";
            this.CerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.CerrarSesionToolStripMenuItem.Text = "&Cerrar Sesión";
            this.CerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // castingToolStripMenuItem
            // 
            this.castingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentesToolStripMenuItem,
            this.stpVer,
            this.toolStripSeparator3});
            this.castingToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("castingToolStripMenuItem.Image")));
            this.castingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.castingToolStripMenuItem.Name = "castingToolStripMenuItem";
            this.castingToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.castingToolStripMenuItem.Text = "Participantes";
            this.castingToolStripMenuItem.Click += new System.EventHandler(this.castingToolStripMenuItem_Click);
            // 
            // agentesToolStripMenuItem
            // 
            this.agentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.agentesToolStripMenuItem.Name = "agentesToolStripMenuItem";
            this.agentesToolStripMenuItem.Size = new System.Drawing.Size(358, 28);
            this.agentesToolStripMenuItem.Text = "Mantenedor de Participantes";
            this.agentesToolStripMenuItem.Click += new System.EventHandler(this.agentesToolStripMenuItem_Click);
            // 
            // stpVer
            // 
            this.stpVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem});
            this.stpVer.Name = "stpVer";
            this.stpVer.Size = new System.Drawing.Size(358, 28);
            this.stpVer.Text = "Listar";
            this.stpVer.Click += new System.EventHandler(this.stpVer_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(198, 28);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(355, 6);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.AsistenciaToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.reportesToolStripMenuItem.Text = "Actividades";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.actividadesToolStripMenuItem.Text = "Consulta Individual";
            this.actividadesToolStripMenuItem.Click += new System.EventHandler(this.actividadesToolStripMenuItem_Click);
            // 
            // AsistenciaToolStripMenuItem
            // 
            this.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem";
            this.AsistenciaToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.AsistenciaToolStripMenuItem.Text = "Lista de Asistencias";
            this.AsistenciaToolStripMenuItem.Click += new System.EventHandler(this.AsistenciaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalaToolStripMenuItem,
            this.mantenedorDeEquiposToolStripMenuItem,
            this.toolStripSeparator2,
            this.listaDeEquiposToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Billboard;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.usuariosToolStripMenuItem.Text = "Instalaciones";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // SalaToolStripMenuItem
            // 
            this.SalaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalaToolStripMenuItem.Name = "SalaToolStripMenuItem";
            this.SalaToolStripMenuItem.Size = new System.Drawing.Size(311, 28);
            this.SalaToolStripMenuItem.Text = "Mantenedor de Salas";
            this.SalaToolStripMenuItem.Click += new System.EventHandler(this.cuentaToolStripMenuItem_Click);
            // 
            // mantenedorDeEquiposToolStripMenuItem
            // 
            this.mantenedorDeEquiposToolStripMenuItem.Name = "mantenedorDeEquiposToolStripMenuItem";
            this.mantenedorDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(311, 28);
            this.mantenedorDeEquiposToolStripMenuItem.Text = "Mantenedor de Equipos";
            this.mantenedorDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.mantenedorDeEquiposToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(308, 6);
            // 
            // listaDeEquiposToolStripMenuItem
            // 
            this.listaDeEquiposToolStripMenuItem.Name = "listaDeEquiposToolStripMenuItem";
            this.listaDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(311, 28);
            this.listaDeEquiposToolStripMenuItem.Text = "Lista de Equipos";
            this.listaDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.listaDeEquiposToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpCenterToolStripMenuItem,
            this.visitaNuestraWebToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.ayudaToolStripMenuItem.Text = "Información";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // helpCenterToolStripMenuItem
            // 
            this.helpCenterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpCenterToolStripMenuItem.Name = "helpCenterToolStripMenuItem";
            this.helpCenterToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.helpCenterToolStripMenuItem.Text = "Contacto ICACIC";
            this.helpCenterToolStripMenuItem.Click += new System.EventHandler(this.helpCenterToolStripMenuItem_Click);
            // 
            // visitaNuestraWebToolStripMenuItem
            // 
            this.visitaNuestraWebToolStripMenuItem.Name = "visitaNuestraWebToolStripMenuItem";
            this.visitaNuestraWebToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.visitaNuestraWebToolStripMenuItem.Text = "Campus Virtual FII";
            this.visitaNuestraWebToolStripMenuItem.Click += new System.EventHandler(this.visitaNuestraWebToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 577);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "::ERP FII 1.0.0 ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem castingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem agentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stpVer;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitaNuestraWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
    }
}