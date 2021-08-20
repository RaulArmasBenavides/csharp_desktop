namespace CapaPresentacion
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.userNo = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.weak = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.PictureBox();
            this.err1 = new System.Windows.Forms.PictureBox();
            this.ico2 = new System.Windows.Forms.PictureBox();
            this.ico1 = new System.Windows.Forms.PictureBox();
            this.pwd2 = new System.Windows.Forms.TextBox();
            this.pwd1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.userNo);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.weak);
            this.groupBox1.Controls.Add(this.err2);
            this.groupBox1.Controls.Add(this.err1);
            this.groupBox1.Controls.Add(this.ico2);
            this.groupBox1.Controls.Add(this.ico1);
            this.groupBox1.Controls.Add(this.pwd2);
            this.groupBox1.Controls.Add(this.pwd1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(280, 44);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(26, 26);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.user.TabIndex = 13;
            this.user.TabStop = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // userNo
            // 
            this.userNo.Image = ((System.Drawing.Image)(resources.GetObject("userNo.Image")));
            this.userNo.Location = new System.Drawing.Point(280, 44);
            this.userNo.Name = "userNo";
            this.userNo.Size = new System.Drawing.Size(26, 26);
            this.userNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userNo.TabIndex = 12;
            this.userNo.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(306, 125);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(70, 12);
            this.status.TabIndex = 11;
            this.status.Text = "No coinciden";
            // 
            // weak
            // 
            this.weak.AutoSize = true;
            this.weak.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weak.ForeColor = System.Drawing.Color.Yellow;
            this.weak.Location = new System.Drawing.Point(302, 89);
            this.weak.Name = "weak";
            this.weak.Size = new System.Drawing.Size(90, 12);
            this.weak.TabIndex = 10;
            this.weak.Text = "Contraseña débil";
            // 
            // err2
            // 
            this.err2.Image = ((System.Drawing.Image)(resources.GetObject("err2.Image")));
            this.err2.Location = new System.Drawing.Point(283, 121);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(16, 16);
            this.err2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.err2.TabIndex = 9;
            this.err2.TabStop = false;
            // 
            // err1
            // 
            this.err1.Image = ((System.Drawing.Image)(resources.GetObject("err1.Image")));
            this.err1.Location = new System.Drawing.Point(280, 88);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(16, 16);
            this.err1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.err1.TabIndex = 8;
            this.err1.TabStop = false;
            // 
            // ico2
            // 
            this.ico2.Image = ((System.Drawing.Image)(resources.GetObject("ico2.Image")));
            this.ico2.Location = new System.Drawing.Point(280, 121);
            this.ico2.Name = "ico2";
            this.ico2.Size = new System.Drawing.Size(19, 20);
            this.ico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico2.TabIndex = 7;
            this.ico2.TabStop = false;
            // 
            // ico1
            // 
            this.ico1.Image = ((System.Drawing.Image)(resources.GetObject("ico1.Image")));
            this.ico1.Location = new System.Drawing.Point(280, 85);
            this.ico1.Name = "ico1";
            this.ico1.Size = new System.Drawing.Size(19, 20);
            this.ico1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico1.TabIndex = 6;
            this.ico1.TabStop = false;
            // 
            // pwd2
            // 
            this.pwd2.Location = new System.Drawing.Point(139, 121);
            this.pwd2.Name = "pwd2";
            this.pwd2.Size = new System.Drawing.Size(135, 20);
            this.pwd2.TabIndex = 5;
            this.pwd2.UseSystemPasswordChar = true;
            this.pwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwd2_KeyPress);
            this.pwd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwd2_KeyUp);
            // 
            // pwd1
            // 
            this.pwd1.Location = new System.Drawing.Point(139, 85);
            this.pwd1.Name = "pwd1";
            this.pwd1.Size = new System.Drawing.Size(135, 20);
            this.pwd1.TabIndex = 4;
            this.pwd1.UseSystemPasswordChar = true;
            this.pwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwd1_KeyPress);
            this.pwd1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwd1_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seguridad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Respuesta";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cómo se llamaba tu primera mascota?",
            "El nombre de tu tío preferido",
            "A qué edad te graduaste de primaria?",
            "A qué edad te graduaste de secundaria?",
            "Tu primera cita",
            "Tu alias en la primaria"});
            this.comboBox1.Location = new System.Drawing.Point(150, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pregunta de seguridad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(21, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(629, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(453, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 340);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Examinar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 517);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Editar";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pwd2;
        private System.Windows.Forms.TextBox pwd1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ico2;
        private System.Windows.Forms.PictureBox ico1;
        private System.Windows.Forms.PictureBox err2;
        private System.Windows.Forms.PictureBox err1;
        private System.Windows.Forms.Label weak;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.PictureBox userNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}