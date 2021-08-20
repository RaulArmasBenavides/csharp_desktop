namespace HospitalmanagementSystem
{
    partial class Main
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStuffAttandanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inpatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outpatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inpatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outpatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAppoinmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AmPm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(371, 195);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(165, 225);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(96, 26);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.toolStripTextBox1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorRegistrationToolStripMenuItem,
            this.stuffToolStripMenuItem3,
            this.allStuffAttandanceToolStripMenuItem});
            this.doctorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(201, 25);
            this.doctorToolStripMenuItem.Text = "Employee Management";
            // 
            // doctorRegistrationToolStripMenuItem
            // 
            this.doctorRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInformationToolStripMenuItem,
            this.checkAttendanceToolStripMenuItem});
            this.doctorRegistrationToolStripMenuItem.Name = "doctorRegistrationToolStripMenuItem";
            this.doctorRegistrationToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.doctorRegistrationToolStripMenuItem.Text = "Doctor";
            // 
            // checkInformationToolStripMenuItem
            // 
            this.checkInformationToolStripMenuItem.Name = "checkInformationToolStripMenuItem";
            this.checkInformationToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.checkInformationToolStripMenuItem.Text = "Check information";
            this.checkInformationToolStripMenuItem.Click += new System.EventHandler(this.checkInformationToolStripMenuItem_Click);
            // 
            // checkAttendanceToolStripMenuItem
            // 
            this.checkAttendanceToolStripMenuItem.Name = "checkAttendanceToolStripMenuItem";
            this.checkAttendanceToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.checkAttendanceToolStripMenuItem.Text = "Check attendance";
            this.checkAttendanceToolStripMenuItem.Click += new System.EventHandler(this.checkAttendanceToolStripMenuItem_Click);
            // 
            // stuffToolStripMenuItem3
            // 
            this.stuffToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInformationsToolStripMenuItem});
            this.stuffToolStripMenuItem3.Name = "stuffToolStripMenuItem3";
            this.stuffToolStripMenuItem3.Size = new System.Drawing.Size(243, 26);
            this.stuffToolStripMenuItem3.Text = "Stuff";
            this.stuffToolStripMenuItem3.Click += new System.EventHandler(this.stuffToolStripMenuItem3_Click);
            // 
            // checkInformationsToolStripMenuItem
            // 
            this.checkInformationsToolStripMenuItem.Name = "checkInformationsToolStripMenuItem";
            this.checkInformationsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.checkInformationsToolStripMenuItem.Text = "Check Informations";
            this.checkInformationsToolStripMenuItem.Click += new System.EventHandler(this.checkInformationsToolStripMenuItem_Click);
            // 
            // allStuffAttandanceToolStripMenuItem
            // 
            this.allStuffAttandanceToolStripMenuItem.Name = "allStuffAttandanceToolStripMenuItem";
            this.allStuffAttandanceToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.allStuffAttandanceToolStripMenuItem.Text = "All Stuff Attandance";
            this.allStuffAttandanceToolStripMenuItem.Click += new System.EventHandler(this.allStuffAttandanceToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inpatientToolStripMenuItem,
            this.outpatientToolStripMenuItem});
            this.patientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(182, 25);
            this.patientToolStripMenuItem.Text = "Patient Management";
            // 
            // inpatientToolStripMenuItem
            // 
            this.inpatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem1});
            this.inpatientToolStripMenuItem.Name = "inpatientToolStripMenuItem";
            this.inpatientToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.inpatientToolStripMenuItem.Text = "Inpatient";
            // 
            // managementToolStripMenuItem1
            // 
            this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            this.managementToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.managementToolStripMenuItem1.Text = "Check Informations";
            this.managementToolStripMenuItem1.Click += new System.EventHandler(this.managementToolStripMenuItem1_Click);
            // 
            // outpatientToolStripMenuItem
            // 
            this.outpatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem1});
            this.outpatientToolStripMenuItem.Name = "outpatientToolStripMenuItem";
            this.outpatientToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.outpatientToolStripMenuItem.Text = "Outpatient";
            // 
            // registrationToolStripMenuItem1
            // 
            this.registrationToolStripMenuItem1.Name = "registrationToolStripMenuItem1";
            this.registrationToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.registrationToolStripMenuItem1.Text = "Check Information";
            this.registrationToolStripMenuItem1.Click += new System.EventHandler(this.registrationToolStripMenuItem1_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem1});
            this.billingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(178, 25);
            this.billingToolStripMenuItem.Text = "Billing Information";
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inpatientToolStripMenuItem1,
            this.outpatientToolStripMenuItem1});
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.patientToolStripMenuItem1.Text = "Patient";
            // 
            // inpatientToolStripMenuItem1
            // 
            this.inpatientToolStripMenuItem1.Name = "inpatientToolStripMenuItem1";
            this.inpatientToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.inpatientToolStripMenuItem1.Text = "Inpatient";
            this.inpatientToolStripMenuItem1.Click += new System.EventHandler(this.inpatientToolStripMenuItem1_Click);
            // 
            // outpatientToolStripMenuItem1
            // 
            this.outpatientToolStripMenuItem1.Name = "outpatientToolStripMenuItem1";
            this.outpatientToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.outpatientToolStripMenuItem1.Text = "Outpatient";
            this.outpatientToolStripMenuItem1.Click += new System.EventHandler(this.outpatientToolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(12, 25);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsToolStripMenuItem.Image = global::HospitalmanagementSystem.Properties.Resources._1460582765_SEO_cogwheels_setting;
            this.settingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // loToolStripMenuItem
            // 
            this.loToolStripMenuItem.Name = "loToolStripMenuItem";
            this.loToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.loToolStripMenuItem.Text = "Log Out";
            this.loToolStripMenuItem.Click += new System.EventHandler(this.loToolStripMenuItem_Click);
            // 
            // checkAppoinmentsToolStripMenuItem
            // 
            this.checkAppoinmentsToolStripMenuItem.Name = "checkAppoinmentsToolStripMenuItem";
            this.checkAppoinmentsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.checkAppoinmentsToolStripMenuItem.Text = "Check appoinments";
            // 
            // checkAttendenceToolStripMenuItem
            // 
            this.checkAttendenceToolStripMenuItem.Name = "checkAttendenceToolStripMenuItem";
            this.checkAttendenceToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.checkAttendenceToolStripMenuItem.Text = "Check Attendence";
            // 
            // AmPm
            // 
            this.AmPm.AutoSize = true;
            this.AmPm.BackColor = System.Drawing.Color.DarkCyan;
            this.AmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AmPm.Location = new System.Drawing.Point(263, 225);
            this.AmPm.Name = "AmPm";
            this.AmPm.Size = new System.Drawing.Size(0, 26);
            this.AmPm.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.Scene_031;
            this.ClientSize = new System.Drawing.Size(874, 469);
            this.Controls.Add(this.AmPm);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inpatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outpatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inpatientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outpatientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAppoinmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem checkAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem allStuffAttandanceToolStripMenuItem;
        private System.Windows.Forms.Label AmPm;
        private System.Windows.Forms.ToolStripMenuItem checkInformationsToolStripMenuItem;
    }
}