namespace CapaPresentacion.View
{
    partial class FrmReporteAsistencia
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cvt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Visible = false;
            // 
            // cvt
            // 
            this.cvt.ActiveViewIndex = -1;
            this.cvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvt.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvt.Location = new System.Drawing.Point(-1, -5);
            this.cvt.Name = "cvt";
            this.cvt.Size = new System.Drawing.Size(1163, 522);
            this.cvt.TabIndex = 1;
            // 
            // FrmReporteAsistencia
            // 
            this.ClientSize = new System.Drawing.Size(1159, 514);
            this.Controls.Add(this.cvt);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FrmReporteAsistencia";
            this.Load += new System.EventHandler(this.FrmReporteAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewerAsisntecia;
        private System.Windows.Forms.TextBox txtCodigo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvt;
    }
}