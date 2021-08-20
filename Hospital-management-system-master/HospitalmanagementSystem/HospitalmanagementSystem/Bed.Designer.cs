namespace HospitalmanagementSystem
{
    partial class BedSelection
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RoonNoLVL = new System.Windows.Forms.Label();
            this.BedNoLvl = new System.Windows.Forms.Label();
            this.BedNo = new System.Windows.Forms.TextBox();
            this.WordNo = new System.Windows.Forms.ComboBox();
            this.RoomNo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(379, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word No:";
            // 
            // RoonNoLVL
            // 
            this.RoonNoLVL.AutoSize = true;
            this.RoonNoLVL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RoonNoLVL.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoonNoLVL.Location = new System.Drawing.Point(18, 66);
            this.RoonNoLVL.Name = "RoonNoLVL";
            this.RoonNoLVL.Size = new System.Drawing.Size(72, 18);
            this.RoonNoLVL.TabIndex = 3;
            this.RoonNoLVL.Text = "Room No:";
            // 
            // BedNoLvl
            // 
            this.BedNoLvl.AutoSize = true;
            this.BedNoLvl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNoLvl.Location = new System.Drawing.Point(313, 38);
            this.BedNoLvl.Name = "BedNoLvl";
            this.BedNoLvl.Size = new System.Drawing.Size(60, 18);
            this.BedNoLvl.TabIndex = 3;
            this.BedNoLvl.Text = "Bed No:";
            // 
            // BedNo
            // 
            this.BedNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNo.Location = new System.Drawing.Point(379, 36);
            this.BedNo.Name = "BedNo";
            this.BedNo.Size = new System.Drawing.Size(104, 25);
            this.BedNo.TabIndex = 4;
            // 
            // WordNo
            // 
            this.WordNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordNo.FormattingEnabled = true;
            this.WordNo.Location = new System.Drawing.Point(104, 39);
            this.WordNo.Name = "WordNo";
            this.WordNo.Size = new System.Drawing.Size(138, 21);
            this.WordNo.TabIndex = 5;
            this.WordNo.SelectedIndexChanged += new System.EventHandler(this.WordNo_SelectedIndexChanged);
            // 
            // RoomNo
            // 
            this.RoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNo.FormattingEnabled = true;
            this.RoomNo.Location = new System.Drawing.Point(104, 65);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(138, 21);
            this.RoomNo.TabIndex = 5;
            this.RoomNo.SelectedIndexChanged += new System.EventHandler(this.RoomNo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(354, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 263);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bed no";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(533, 37);
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Size = new System.Drawing.Size(100, 20);
            this.pid.TabIndex = 8;
            // 
            // BedSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalmanagementSystem.Properties.Resources._20121206231502_0___LG_ISIS_Beleura_Hospital_68811;
            this.ClientSize = new System.Drawing.Size(701, 374);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RoomNo);
            this.Controls.Add(this.WordNo);
            this.Controls.Add(this.BedNo);
            this.Controls.Add(this.BedNoLvl);
            this.Controls.Add(this.RoonNoLVL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 413);
            this.MinimumSize = new System.Drawing.Size(717, 413);
            this.Name = "BedSelection";
            this.Text = "Bed No:";
            this.Load += new System.EventHandler(this.BedSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoonNoLVL;
        private System.Windows.Forms.Label BedNoLvl;
        private System.Windows.Forms.TextBox BedNo;
        public System.Windows.Forms.ComboBox WordNo;
        public System.Windows.Forms.ComboBox RoomNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.TextBox pid;

    }
}