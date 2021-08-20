namespace HospitalmanagementSystem
{
    partial class DoctorForm
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
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inpatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outpaientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientInformationToolStripMenuItem,
            this.appoinmentsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientRecordsToolStripMenuItem,
            this.dischargePatientToolStripMenuItem});
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.patientInformationToolStripMenuItem.Text = "Patient information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // patientRecordsToolStripMenuItem
            // 
            this.patientRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inpatientToolStripMenuItem,
            this.outpaientToolStripMenuItem});
            this.patientRecordsToolStripMenuItem.Name = "patientRecordsToolStripMenuItem";
            this.patientRecordsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.patientRecordsToolStripMenuItem.Text = "Patient records";
            this.patientRecordsToolStripMenuItem.Click += new System.EventHandler(this.patientRecordsToolStripMenuItem_Click);
            // 
            // inpatientToolStripMenuItem
            // 
            this.inpatientToolStripMenuItem.Name = "inpatientToolStripMenuItem";
            this.inpatientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inpatientToolStripMenuItem.Text = "Inpatient";
            this.inpatientToolStripMenuItem.Click += new System.EventHandler(this.inpatientToolStripMenuItem_Click);
            // 
            // outpaientToolStripMenuItem
            // 
            this.outpaientToolStripMenuItem.Name = "outpaientToolStripMenuItem";
            this.outpaientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outpaientToolStripMenuItem.Text = "Outpaient";
            this.outpaientToolStripMenuItem.Click += new System.EventHandler(this.outpaientToolStripMenuItem_Click);
            // 
            // appoinmentsToolStripMenuItem
            // 
            this.appoinmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appoinmentListToolStripMenuItem});
            this.appoinmentsToolStripMenuItem.Name = "appoinmentsToolStripMenuItem";
            this.appoinmentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.appoinmentsToolStripMenuItem.Text = "Appoinments";
            // 
            // appoinmentListToolStripMenuItem
            // 
            this.appoinmentListToolStripMenuItem.Name = "appoinmentListToolStripMenuItem";
            this.appoinmentListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.appoinmentListToolStripMenuItem.Text = "Appoinment List";
            this.appoinmentListToolStripMenuItem.Click += new System.EventHandler(this.appoinmentListToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dischargePatientToolStripMenuItem
            // 
            this.dischargePatientToolStripMenuItem.Name = "dischargePatientToolStripMenuItem";
            this.dischargePatientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dischargePatientToolStripMenuItem.Text = "Discharge Patient";
            this.dischargePatientToolStripMenuItem.Click += new System.EventHandler(this.dischargePatientToolStripMenuItem_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.AttandBaack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 417);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appoinmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appoinmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inpatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outpaientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dischargePatientToolStripMenuItem;
    }
}