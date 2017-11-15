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
    public partial class IniciarSesion : Form
    {
        static string nom;
        public IniciarSesion()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
        public void Iniciar()
        {
            Usuario oUsu = new Usuario();
            oUsu.Nombre = txtUsuario.Text;
            oUsu.Clave = txtContraseña.Text;
            Iniciar(oUsu);
        }
        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(btnIniciarSesion, "IniciarSesion.png");
        }
        public static string nombreUs
        {
            get { return nom; }
        }
        public static string vieneDe
        {
            get { return "iniciar"; }
        }
        public void Iniciar(Usuario usu)
        {
            bool Inicio = usu.IniciarSesion(usu.Nombre, usu.Clave);

            if (Inicio == true)
            {
                VariablesUtiles.SetRecordar(usu.Nombre);

                PaginaPrincipalNueva pagPrincipal = new PaginaPrincipalNueva();
                pagPrincipal.Show();
                Close();
             }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                Iniciar();
            }
        }
    }
}
