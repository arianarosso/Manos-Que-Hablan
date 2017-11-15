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
    public partial class Registrarse : Form
    {
        static string nom;
        public Registrarse()
        {
            InitializeComponent();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            enter();
        }
        public void enter()
        {
            if (txtComprobar.Text == txtContraseña.Text)
            {
                Usuario oUsu = new Usuario();
                oUsu.Nombre = txtUsuario.Text;
                oUsu.Clave = txtContraseña.Text;
                Registro(oUsu);
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Registrarse_Load(object sender, EventArgs e)
        {
            CargarImagenes();
        }
        public static string nombreUs
        {
            get { return nom; }
        }
        public void Registro(Usuario usu)
        {
            usu.Registrarse(usu.Nombre, usu.Clave);
            nom = usu.Nombre;
            VariablesUtiles.SetRecordar(usu.Nombre);
            PaginaPrincipalNueva pagPrincipal = new PaginaPrincipalNueva();
            pagPrincipal.Show();
            Close();
        }
        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(btnRegistrarse, "registrarse.png");
        }
        private void txtComprobar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                enter();
            }
        }
    }
}
