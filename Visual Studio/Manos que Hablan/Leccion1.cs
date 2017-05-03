using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manos_que_Hablan
{
    public partial class Leccion1 : Form
    {
        public Leccion1()
        {
            InitializeComponent();
            progressBar.Minimum = 0;
            progressBar.Maximum = 10;
            progressBar.Step = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            progressBar.PerformStep();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            pagPrincipal.Tag = this;
            pagPrincipal.Show(this);
            Hide();
        }
    }
}
