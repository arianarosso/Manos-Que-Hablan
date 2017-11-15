using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManosQueHablan
{
    public partial class SeleccionarCorrecto : Form
    {
        PaginaPrincipalNueva _PaginaPrincipalNueva;

        String Seleccionado = "";
        String pcbSeleccionado = "";
        int ContSeleccionados = 0;
        String Correcto = "";
        String ElementoSeleccionado = "";
        Random randomElemento1 = new Random();
        int random1;
        String ElementoRandom1 = "";
        String ElementoRandom2 = "";
        String gif2 = "";
        String gif3 = "";
        String pathgif2 = "";
        String pathgif3 = "";
        String picture = "";
        String[] Ayudas = new String[3];
        int ContJugadas = 0;
        public int i = -1;
        bool PasarDeEjercicio = false;
        bool EjercicioEmpezado = false;
        string[] Vec = new string[30] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        int[] VecCantABC = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int contador = 0;
        String pathgif;
        public SeleccionarCorrecto()
        {
            InitializeComponent();
        }

        public void Inicializar(PaginaPrincipalNueva laPaginaQueLoinstancio)
        {
            _PaginaPrincipalNueva = laPaginaQueLoinstancio;
            ElegirLetraCorrecta();
        }

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
        private void pcbPasar_Click(object sender, EventArgs e)
        {
            contador = 9;
            _PaginaPrincipalNueva.Cont = contador;
            _PaginaPrincipalNueva.ContPasar++;
            Close();
        }
        public void ValidarCorrecto()
        {
            if (Seleccionado == Correcto)
            {
                ContJugadas++;
                contador++;
                VecCantABC[i]++;
                if (contador == 9)
                {
                    _PaginaPrincipalNueva.Cont = contador;
                 }
                if (ContJugadas < 30)
                {
                    MessageBox.Show("Correcto!");
                    Seleccionado = "";
                    LimpiarLabels();
                    ActivarSeleccionarCorrecto();
                }
                else
                {
                    MessageBox.Show("Correcto!");
                    LimpiarPCBs();
                    LimpiarLabels();
                    lblTitulo.Text = "";
                    MessageBox.Show("Usted ha terminado la primera parte :)");
                    PasarDeEjercicio = true;
                }
            }
            else
            {
                if (Seleccionado != "")
                {
                    MessageBox.Show("La seña que ha seleccionado es incorrecta");
                    switch (pcbSeleccionado)
                    {
                        case "pcb1SC":
                            pcb1SC.Image = null;
                            lbl1.Text = "";
                            break;
                        case "pcb2SC":
                            pcb2SC.Image = null;
                            lbl2.Text = "";
                            break;
                        case "pcb3SC":
                            pcb3SC.Image = null;
                            lbl3.Text = "";
                            break;
                    }
                }
                else
                {
                    if (Seleccionado == "")
                    {
                        MessageBox.Show("Seleccione una seña!");
                    }
                }
            }
        }
        public void ActivarSeleccionarCorrecto()
        {
            ElegirLetraCorrecta();
        }
        private void FuncionLetraRandom1()
        {
            random1 = randomElemento1.Next(0, 30);
            ValidarRandomLetra1(random1);
            gif2 = random1.ToString();
            pathgif2 = FuncionesUtiles.CargarRutas(/*gif2, */ElementoRandom1);
        }
        public void ValidarRandomLetra1(int random1)
        {
            if (Vec[random1] == ElementoSeleccionado || Vec[random1] == "*")
            {
                FuncionLetraRandom1();
            }
            else
            {
                ElementoRandom1 = Vec[random1];
            }
        }

        private void FuncionLetraRandom2()
        {
            Random randomletra2 = new Random();
            int random2 = randomElemento1.Next(0, 30);
            ValidarRandomLetra2(random1, random2);
            gif3 = random2.ToString();
            pathgif3 = FuncionesUtiles.CargarRutas(/*gif3, */ElementoRandom2);
        }

        public void ValidarRandomLetra2(int random1, int random2)
        {
            if (Vec[random2] == ElementoSeleccionado || Vec[random2] == Vec[random1] || Vec[random2] == "*")
            {
                FuncionLetraRandom2();
            }
            else
            {
                ElementoRandom2 = Vec[random2];
            }
        }
        private string pcbRandom()
        {
            Random random = new Random();
            int randompcb = random.Next(1, 4);
            String pcb;
            pcb = "pcb" + randompcb.ToString() + "SC";
            return pcb;
        }

        // ------------- FUNCIONES COMPARTIDAS ---------------------------------
        public void LlenarPCBs()
        {
            if (PasarDeEjercicio == false)
            {
                picture = pcbRandom();
                switch (picture)
                {
                    case "pcb1SC":
                        pcb1SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb2SC.Image = Image.FromFile(pathgif2);
                        pcb3SC.Image = Image.FromFile(pathgif3);
                        Correcto = "1";
                        Ayudas[0] = ElementoSeleccionado;
                        Ayudas[1] = ElementoRandom1;
                        Ayudas[2] = ElementoRandom2;
                        break;
                    case "pcb2SC":
                        pcb2SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb1SC.Image = Image.FromFile(pathgif2);
                        pcb3SC.Image = Image.FromFile(pathgif3);
                        Correcto = "2";
                        Ayudas[0] = ElementoRandom1;
                        Ayudas[1] = ElementoSeleccionado;
                        Ayudas[2] = ElementoRandom2;
                        break;
                    case "pcb3SC":
                        pcb3SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb1SC.Image = Image.FromFile(pathgif2);
                        pcb2SC.Image = Image.FromFile(pathgif3);
                        Correcto = "3";
                        Ayudas[0] = ElementoRandom1;
                        Ayudas[1] = ElementoRandom2;
                        Ayudas[2] = ElementoSeleccionado;
                        break;
                }
            }
        }
        private void LimpiarLabels()
        {
            if (PasarDeEjercicio == false)
            {
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
            }
        }
        private void LimpiarPCBs()
        {
            if (PasarDeEjercicio == false)
            {
                pcb1SC.Image = null;
                pcb2SC.Image = null;
                pcb3SC.Image = null;
            }
        }
        private void pcbEmTer_Click(object sender, EventArgs e)
        {
            if (EjercicioEmpezado)
            {
                _PaginaPrincipalNueva.Tag = this;
                _PaginaPrincipalNueva.Show(this);
                Hide();
            }
            else
            {
                ActivarSeleccionarCorrecto();
            }

        }
        public void ElegirLetraCorrecta()
        {
            if (contador == 9)
            {
                this.Close();
            }
            else
            {
                i++;
                ElementoSeleccionado = Vec[i];
                pathgif = FuncionesUtiles.CargarRutas(ElementoSeleccionado);
                lblTitulo.Text = "Seleccione la seña " + ElementoSeleccionado;
                LlenarPCBs();
            }
        }

        private void LetraRandom()
        {
            Random randomletra = new Random();
            int randomcorrecto = randomElemento1.Next(0, 30);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarCorrecto();
            pcbMarco1.Visible = false;
            pcbMarco2.Visible = false;
            pcbMarco3.Visible = false;
            FuncionesUtiles fUtiles = new FuncionesUtiles();
            fUtiles.Progress(lblProgress, contador);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _PaginaPrincipalNueva.Salir= true;
            this.Close();
        }

        private void pcb1SC_Click_1(object sender, EventArgs e)
        {
            Seleccionado = "1";
            pcbSeleccionado = "pcb1SC";
            ContSeleccionados++;
            pcbMarco1.Visible = true;
            pcbMarco2.Visible = false;
            pcbMarco3.Visible = false;
        }

        private void pcb2SC_Click_1(object sender, EventArgs e)
        {
            Seleccionado = "2";
            pcbSeleccionado = "pcb2SC";
            ContSeleccionados++;
            pcbMarco1.Visible = false;
            pcbMarco2.Visible = true;
            pcbMarco3.Visible = false;
        }

        private void pcb3SC_Click_1(object sender, EventArgs e)
        {
            Seleccionado = "3";
            pcbSeleccionado = "pcb3SC";
            ContSeleccionados++;
            pcbMarco1.Visible = false;
            pcbMarco2.Visible = false;
            pcbMarco3.Visible = true;
        }
        private void SeleccionarCorrecto_Load(object sender, EventArgs e)
        {
            CargarImagenes();
            lblProgress.Text = "0/30";
        }

        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(pcb1, "pista1.png");
            FuncionesUtiles.CargarImagen(pcb2, "pista2.png");
            FuncionesUtiles.CargarImagen(pcb3, "pista3.png");
            FuncionesUtiles.CargarImagen(btnAceptar, "aceptar.png");
            FuncionesUtiles.CargarImagen(pcbPasar, "Saltear.png");
            FuncionesUtiles.CargarImagen(btnVolver, "volver.png");
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            lbl1.Text = Ayudas[0];
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            lbl2.Text = Ayudas[1];
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            lbl3.Text = Ayudas[2];
        }
    }
}