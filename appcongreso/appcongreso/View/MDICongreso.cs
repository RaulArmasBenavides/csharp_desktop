using System;
using System.Windows.Forms;

namespace appcongreso.View
{
    public partial class MDICongreso : Form
    {
        public MDICongreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParticipanteView p = new ParticipanteView();
            p.MdiParent = this;
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActividadView p = new ActividadView();
            p.MdiParent = this;
            p.Show();
        }
    }
}
