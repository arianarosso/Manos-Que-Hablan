using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Manos_que_Hablan
{
    public partial class Leccion1 : Form
    {
        int[] VecCantABC = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        String[] VecABC = new String[30] { "A", "B", "C", "CH", "D", "E", "F", "G", "H", "I", "J", "K", "L", "LL", "M", "N", "Ñ", "O", "P", "Q", "R", "RR", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        String Correcto = "";
        String Seleccionado = "";
        String LetraSeleccionada = "";
        String pcbSeleccionado = "";
        Random randomletra1 = new Random();
        int random1;
        String LetraRandom1 = "";
        String LetraRandom2 = "";
        String gif2 = "";
        String gif3 = "";
        String picture = "";
        String pathEscribirLetra = "";
        String[] Ayudas = new String[3];
        int posLetra;
        int ContSeleccionados = 0;
        int ContJugadas = 0;
        int ContJugadasEscribir = 0;
        int i = -1;
        bool PasarDeEjercicio = false;
        bool EjercicioEmpezado = false;

        public Leccion1()
        {
            InitializeComponent();
            progressBar.Minimum = 0;
            progressBar.Maximum = 30;
            progressBar.Step = 1;
            pcb1EL.Visible = false;
            pcb1SC.Visible = false;
            pcb2SC.Visible = false;
            pcb3SC.Visible = false;
            progressBar.Visible = false;
            lblTitulo.Visible = false;
            btnAceptar.Visible = false;
            ElegirImagenes();
        }
        
        private void pcb1SC_Click(object sender, EventArgs e)
        {
            Seleccionado = "1";
            pcbSeleccionado = "pcb1SC";
            ContSeleccionados++;
            lbl1.Text = Ayudas[0];
        }

        private void pcb2SC_Click(object sender, EventArgs e)
        {
            Seleccionado = "2";
            pcbSeleccionado = "pcb2SC";
            ContSeleccionados++;
            lbl2.Text = Ayudas[1];
        }

        private void pcb3SC_Click(object sender, EventArgs e)
        {
            Seleccionado = "3";
            pcbSeleccionado = "pcb3SC";
            ContSeleccionados++;
            lbl3.Text = Ayudas[2];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (PasarDeEjercicio == false)
            {
                ValidarCorrecto();
            }
            else
            {
                Validartxt();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            pagPrincipal.Tag = this;
            pagPrincipal.Show(this);
            Hide();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ValidarCorrecto()
        {
            if (Seleccionado == Correcto)
            {
                ContJugadas++;
                if (ContJugadas < 30 )
                {
                    MessageBox.Show("Correcto!");
                    Seleccionado = "";
                    progressBar.Increment(1);
                    LimpiarLabels();
                    ActivarSeleccionarCorrecto();
                    /*LlenarPCBs();
                    ActivarSeleccionarCorrecto();*/
                }
                else
                {
                    progressBar.Increment(1);
                    MessageBox.Show("Correcto!");
                    LimpiarPCBs();
                    LimpiarLabels();
                    lblTitulo.Text = "";
                    MessageBox.Show("Usted ha terminado la primera parte :)");
                    PasarDeEjercicio = true;
                    progressBar.Value = 0;
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
            if (PasarDeEjercicio)
            {
                ActivarEscribirLetra();
            }
        }

        public void ActivarSeleccionarCorrecto()
        {
            ElegirLetraCorrecta();
            lblTitulo.Text = "Seleccione la letra " + LetraSeleccionada;
            pcb1SC.Visible = true;
            pcb2SC.Visible = true;
            pcb3SC.Visible = true;
            btnAceptar.Visible = true;
            pcb1EL.Visible = false;
            txtEscribir.Visible = false;
            pcbMensaje.Visible = false;
            pcbEmTer.Visible = false;
            progressBar.Visible = true;
            lblTitulo.Visible = true;
            LlenarPCBs();
        }

        public void ActivarEscribirLetra()
        {
            ElegirLetraCorrecta();
            lblTitulo.Text = "Escriba la letra...";
            pcb1SC.Visible = false;
            pcb2SC.Visible = false;
            pcb3SC.Visible = false;
            btnAceptar.Visible = true;
            pcb1EL.Visible = true;
            txtEscribir.Visible = true;
            pcbMensaje.Visible = false;
            pcbEmTer.Visible = false;
            progressBar.Visible = true;
            lblTitulo.Visible = true;
            LlenarPCBs();
        }

        public void Validartxt()
        {
            if (txtEscribir.Text == LetraSeleccionada)
            {
                ContJugadasEscribir++;
                if (ContJugadasEscribir < 30)
                {
                    MessageBox.Show("Correcto!");
                    progressBar.Increment(1);
                    txtEscribir.Text = "";
                    LimpiarLabels();
                    ActivarEscribirLetra();
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
                    pcb1SC.Visible = false;
                    pcb2SC.Visible = false;
                    pcb3SC.Visible = false;
                    progressBar.Visible = false;
                    lblTitulo.Visible = false;
                    btnAceptar.Visible = false;

                    ElegirImagenes();

                }
            }
            else
            {
                if (txtEscribir.Text != "")
                {
                    MessageBox.Show("La letra que ha escrito es incorrecta");
                    txtEscribir.Text = "";
                }
                else
                {
                    if (txtEscribir.Text == "")
                    {
                        MessageBox.Show("Escriba una letra!");
                    }
                }
            }
        }

        public void ElegirLetraCorrecta()
        {
            if (i == 29)
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 30;
                progressBar.Step = 1;
                i = -1;
                i++;
                LetraSeleccionada = VecABC[i];
            }
            else
            {
                i++;
                LetraSeleccionada = VecABC[i];
            }
        }

        public void LlenarPCBs()
        {
            String pathgif = "C:/Manos-Que-Hablan/Visual Studio/Gifs/" + LetraSeleccionada + ".gif";
            if (PasarDeEjercicio == false)
            {
                picture = pcbRandom();
                switch (picture)
                {
                    case "pcb1SC":
                        pcb1SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb2SC.Image = Image.FromFile(gif2);
                        pcb3SC.Image = Image.FromFile(gif3);
                        Correcto = "1";
                        Ayudas[0] = LetraSeleccionada;
                        Ayudas[1] = LetraRandom1;
                        Ayudas[2] = LetraRandom2;
                        //Para ver si funca:
                        //MessageBox.Show(VecProvABC[posLetra], picture);
                        break;
                    case "pcb2SC":
                        pcb2SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb1SC.Image = Image.FromFile(gif2);
                        pcb3SC.Image = Image.FromFile(gif3);
                        Correcto = "2";
                        Ayudas[0] = LetraRandom1;
                        Ayudas[1] = LetraSeleccionada;
                        Ayudas[2] = LetraRandom2;
                        //MessageBox.Show(VecProvABC[posLetra], picture);
                        break;
                    case "pcb3SC":
                        pcb3SC.Image = Image.FromFile(pathgif);
                        FuncionLetraRandom1();
                        FuncionLetraRandom2();
                        pcb1SC.Image = Image.FromFile(gif2);
                        pcb2SC.Image = Image.FromFile(gif3);
                        Correcto = "3";
                        Ayudas[0] = LetraRandom1;
                        Ayudas[1] = LetraRandom2;
                        Ayudas[2] = LetraSeleccionada;
                        //MessageBox.Show(VecProvABC[posLetra], picture);
                        break;
                    }
            }
            else
            {
                pcb1EL.Image = Image.FromFile(pathgif);
            }
        }

        private void FuncionLetraRandom1()
        {
            random1 = randomletra1.Next(0, 30);
            ValidarRandomLetra1(random1);
            gif2 = "C:/Manos-Que-Hablan/Visual Studio/Gifs/" + LetraRandom1 + ".gif";
        }

        public void ValidarRandomLetra1(int random1)
        {
            if (VecABC[random1] == LetraSeleccionada)
            {
                FuncionLetraRandom1();
            }
            else
            {
                LetraRandom1 = VecABC[random1];
            }
        }

        private void FuncionLetraRandom2()
        {
            Random randomletra2 = new Random();
            int random2 = randomletra1.Next(0, 30);
            ValidarRandomLetra2(random1, random2);
            gif3 = "C:/Manos-Que-Hablan/Visual Studio/Gifs/" + LetraRandom2 + ".gif";
        }

        public void ValidarRandomLetra2(int random1, int random2)
        {
            if (VecABC[random2] == LetraSeleccionada || VecABC[random2] == VecABC[random1])
            {
                FuncionLetraRandom2();
            }
            else
            {
                LetraRandom2 = VecABC[random2];
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

        private void LimpiarLabels()
        {
            if (PasarDeEjercicio == false)
            {
                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
            }
            else
            {
                lblEscribirLetra.Text = "";
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
            else
            {
                pcb1EL.Image = null;
            }
        }
        public void ElegirImagenes()
        {

            pcbMensaje.Visible = true;
            pcbEmTer.Visible = true;
            if (EjercicioEmpezado)
            {
                pcbMensaje.Image = Manos_que_Hablan.Properties.Resources.ABCTerminar;
                pcbEmTer.Image = Manos_que_Hablan.Properties.Resources.Terminar;
            }
            else
            {
                pcbMensaje.Image = Manos_que_Hablan.Properties.Resources.ABCEmpezar;
                pcbEmTer.Image = Manos_que_Hablan.Properties.Resources.Empezar;
            }
        }

        private void pcb1EL_Click(object sender, EventArgs e)
        {
            lblEscribirLetra.Text = LetraSeleccionada;
        }
        private void pcbEmTer_Click(object sender, EventArgs e)
        {
            if (EjercicioEmpezado)
            {
                PaginaPrincipal pagPrincipal = new PaginaPrincipal();
                pagPrincipal.Tag = this;
                pagPrincipal.Show(this);
                Hide();
            }
            else
            {
                ActivarSeleccionarCorrecto();
            }
            
        }

        private void btnVocabulario_Click(object sender, EventArgs e)
        {
            Vocabulario vocab = new Vocabulario();
            vocab.Text = "Abecedario";
            vocab.PalabrasObtenidas = VecABC;
            vocab.ShowDialog();
        }
    }
}