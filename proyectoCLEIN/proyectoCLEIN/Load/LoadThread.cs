using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Casting.Load
{
    public partial class LoadThread : Form
    {
        public LoadThread()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ini = new Inicio();
            ini.Show();
            timer1.Stop();   
        }
    }
}
