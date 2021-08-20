namespace HospitalmanagementSystem
{
    partial class Out_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Out_Patient));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.appoinmentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pcountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pmobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.proom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pgender = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(58, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID:";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(148, 30);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(179, 20);
            this.pid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name:";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(148, 66);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(179, 20);
            this.pname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age:";
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(148, 138);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(179, 20);
            this.page.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Appoinment No;";
            // 
            // appoinmentNo
            // 
            this.appoinmentNo.Location = new System.Drawing.Point(148, 174);
            this.appoinmentNo.Name = "appoinmentNo";
            this.appoinmentNo.ReadOnly = true;
            this.appoinmentNo.Size = new System.Drawing.Size(179, 20);
            this.appoinmentNo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "City:";
            // 
            // pcity
            // 
            this.pcity.Location = new System.Drawing.Point(148, 210);
            this.pcity.Name = "pcity";
            this.pcity.Size = new System.Drawing.Size(179, 20);
            this.pcity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Country:";
            // 
            // pcountry
            // 
            this.pcountry.Location = new System.Drawing.Point(148, 246);
            this.pcountry.Name = "pcountry";
            this.pcountry.Size = new System.Drawing.Size(179, 20);
            this.pcountry.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mobile No:";
            // 
            // pmobile
            // 
            this.pmobile.Location = new System.Drawing.Point(148, 282);
            this.pmobile.Name = "pmobile";
            this.pmobile.Size = new System.Drawing.Size(179, 20);
            this.pmobile.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Room No:";
            // 
            // proom
            // 
            this.proom.Location = new System.Drawing.Point(148, 318);
            this.proom.Name = "proom";
            this.proom.Size = new System.Drawing.Size(179, 20);
            this.proom.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::HospitalmanagementSystem.Properties.Resources.add1;
            this.button2.Location = new System.Drawing.Point(230, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Register";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pgender
            // 
            this.pgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pgender.FormattingEnabled = true;
            this.pgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.pgender.Location = new System.Drawing.Point(148, 104);
            this.pgender.Name = "pgender";
            this.pgender.Size = new System.Drawing.Size(179, 21);
            this.pgender.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(352, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 56);
            this.button3.TabIndex = 0;
            this.button3.Text = "Fix Appoinment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 192);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(468, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(330, 128);
            this.dataGridView2.TabIndex = 5;
            // 
            // Out_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources.images79UVSEYU;
            this.ClientSize = new System.Drawing.Size(810, 403);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pgender);
            this.Controls.Add(this.proom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pmobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appoinmentNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.page);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Out_Patient";
            this.Text = "Out_Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pcity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pcountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pmobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox proom;
        private System.Windows.Forms.ComboBox pgender;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox appoinmentNo;
    }
}