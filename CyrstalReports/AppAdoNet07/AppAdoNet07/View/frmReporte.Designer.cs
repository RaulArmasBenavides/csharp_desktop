namespace AppAdoNet07.View
{
    partial class frmReporte
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
            this.crvFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFactura
            // 
            this.crvFactura.ActiveViewIndex = -1;
            this.crvFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFactura.Location = new System.Drawing.Point(0, 0);
            this.crvFactura.Name = "crvFactura";
            this.crvFactura.Size = new System.Drawing.Size(816, 512);
            this.crvFactura.TabIndex = 0;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 512);
            this.Controls.Add(this.crvFactura);
            this.Name = "frmReporte";
            this.Text = " FACTURA DE VENTA";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFactura;
    }
}