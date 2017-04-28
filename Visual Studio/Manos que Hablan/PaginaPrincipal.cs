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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Tag = this;
            index.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbLeccion1_Click(object sender, EventArgs e)
        {
            Leccion1 leccion1 = new Leccion1();
            leccion1.Tag = this;
            leccion1.Show(this);
            Hide();
        }
    }
}
