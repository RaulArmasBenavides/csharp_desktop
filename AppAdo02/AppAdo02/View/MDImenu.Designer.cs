namespace AppAdo02.View
{
    partial class MDImenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosTodoToolStripMenuItem,
            this.productosPorNombreToolStripMenuItem,
            this.productosPorCategoriaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // productosTodoToolStripMenuItem
            // 
            this.productosTodoToolStripMenuItem.Name = "productosTodoToolStripMenuItem";
            this.productosTodoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosTodoToolStripMenuItem.Text = "Productos Todo";
            this.productosTodoToolStripMenuItem.Click += new System.EventHandler(this.productosTodoToolStripMenuItem_Click);
            // 
            // productosPorNombreToolStripMenuItem
            // 
            this.productosPorNombreToolStripMenuItem.Name = "productosPorNombreToolStripMenuItem";
            this.productosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosPorNombreToolStripMenuItem.Text = "Productos Por Nombre";
            this.productosPorNombreToolStripMenuItem.Click += new System.EventHandler(this.productosPorNombreToolStripMenuItem_Click);
            // 
            // productosPorCategoriaToolStripMenuItem
            // 
            this.productosPorCategoriaToolStripMenuItem.Name = "productosPorCategoriaToolStripMenuItem";
            this.productosPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosPorCategoriaToolStripMenuItem.Text = "Productos Por Categoria";
            this.productosPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.productosPorCategoriaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MDImenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDImenu";
            this.Text = "CONSULTAS NEPTUNO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}