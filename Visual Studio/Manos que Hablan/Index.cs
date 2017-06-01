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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

       private void pcLogo_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Tag = this;
            paginaPrincipal.Show(this);
            Hide();
        }

      /*  private void btnIraKinect_Click(object sender, EventArgs e)
        {
            KinectStream kinect = new KinectStream();
            kinect.Show();
        }*/

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Tag = this;
            iniciarSesion.Show(this);
            Hide();
        }

        private void btnRegistrarte_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Tag = this;
            registrarse.Show(this);
            Hide();
        }
    }
}
