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
    public partial class Escribir : Form
    {
        PaginaPrincipalNueva _PaginaPrincipalNueva;
        String Seleccionado = "";
        String pcbSeleccionado = "";
        int ContSeleccionados = 0;
        String Correcto = "";
        String ElementoSeleccionado = "";
        int ContJugadas = 0;
        int i = 7;
        bool PasarDeEjercicio = false;
        bool EjercicioEmpezado = false;
        string[] Vec = new string[30] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        int[] VecCantABC = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int contador = 9;
        String pathgif;
        SeleccionarCorrecto ObjetoS = new SeleccionarCorrecto();
        public string[] PalabrasObtenidas
        {
            get { return Vec; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    Vec[i] = value[i];
                }
            }
        }
        public Escribir()
        {
            InitializeComponent();
        }
        public void Inicializar(PaginaPrincipalNueva laPaginaQueLoinstancio)
        {
            _PaginaPrincipalNueva = laPaginaQueLoinstancio;
            ElegirLetraCorrecta();
        }

        public void Validartxt()
        {
            string respuesta;
            if (ElementoSeleccionado == "ENIE")
            {
                ElementoSeleccionado = "Ñ";
            }
            respuesta = (txtEscribir.Text).ToUpper();
            if (respuesta == ElementoSeleccionado)
            {
                ContJugadas++;
                contador++;
                if (contador == 19)
                {
                    _PaginaPrincipalNueva.Cont = contador;
                }
                if (ContJugadas < 30)
                {
                    MessageBox.Show("Correcto!");
                    txtEscribir.Text = "";
                    LimpiarLabels();
                    ElegirLetraCorrecta();
                }
                else
                {
                    MessageBox.Show("Correcto!");
                    LimpiarPCBs();
                    txtEscribir.Visible = false;
                    LimpiarLabels();
                    MessageBox.Show("Usted ha terminado la segunda parte :)");
                    EjercicioEmpezado = true;
                    pcb1EL.Visible = false;
                    lblTitulo.Visible = false;
                    btnAceptar.Visible = false;
                }
            }
            else
            {
                if (respuesta != "")
                {
                    MessageBox.Show("La seña que ha escrito es incorrecta");
                    txtEscribir.Text = "";
                }
                else
                {
                    if (respuesta == "")
                    {
                        MessageBox.Show("Escriba una seña!");
                    }
                }
            }
            lblEscribirLetra.Text = "";
            FuncionesUtiles FUtiles = new FuncionesUtiles();
            FUtiles.Progress(lblProgress, contador);
        }

        public void ElegirLetraCorrecta()
        {
            if (contador == 19)
            {
                this.Close();
            }
            else
            {
                Random random = new Random();
                int rnd = random.Next(0, 30);
                if (Vec[rnd] == "*")
                {
                    ElegirLetraCorrecta();
                }
                else
                {
                    ElementoSeleccionado = Vec[rnd];
                    pathgif = FuncionesUtiles.CargarRutas(ElementoSeleccionado);
                    lblTitulo.Text = "Escriba lo que crea correspondiente";
                    LlenarPCBs();
                }
            }
        }
        // ------------- FUNCIONES COMPARTIDAS ---------------------------------
        public void LlenarPCBs()
        {
            pcb1EL.Image = Image.FromFile(pathgif);
        }
        private void LimpiarLabels()
        {
            if (PasarDeEjercicio == true)
            {
                lblEscribirLetra.Text = "";
            }
        }
        private void LimpiarPCBs()
        {
            if (PasarDeEjercicio == true)
            {
                pcb1EL.Image = null;
            }
        }
        //---------------------------------Click-----------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Validartxt();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            _PaginaPrincipalNueva.Salir = true;
            this.Close();
        }

        private void pcbPasar_Click(object sender, EventArgs e)
        {
            contador = 19;
            _PaginaPrincipalNueva.Cont = contador;
            _PaginaPrincipalNueva.ContPasar++;
            Close();
        }

        private void Escribir_Load(object sender, EventArgs e)
        {
            //_PaginaPrincipalNueva.Dispose();
            CargarImagenes();
            lblTitulo.Text = "Escriba la seña correspondiente";
            lblProgress.Text = "9/30";
        }

        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(pcbPista, "pista.png");
            FuncionesUtiles.CargarImagen(btnAceptar, "aceptar.png");
            FuncionesUtiles.CargarImagen(pcbPasar, "Saltear.png");
            FuncionesUtiles.CargarImagen(btnVolver, "volver.png");
        }

        private void pcbPista_Click(object sender, EventArgs e)
        {
            if (ElementoSeleccionado == "ENIE")
            {
                ElementoSeleccionado = "Ñ";
            }
            if (ElementoSeleccionado == "PUNO")
            {
                ElementoSeleccionado = "PUÑO";
            }
            if (ElementoSeleccionado == "MENIQUE")
            {
                ElementoSeleccionado = "MEÑIQUE";
            }
            lblEscribirLetra.Text = ElementoSeleccionado;
        }
        private void txtEscribir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)13)
            {
                Validartxt();
            }
        }
    }
}
