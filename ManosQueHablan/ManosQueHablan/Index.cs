using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManosQueHablan
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
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

        private void Index_Load(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(pcLogo, "logo.png");
            FuncionesUtiles.CargarImagen(btnRegistrarte, "registrarse.png");
            FuncionesUtiles.CargarImagen(btnIniciarSesion, "IniciarSesion.png");
        }
    }
}
