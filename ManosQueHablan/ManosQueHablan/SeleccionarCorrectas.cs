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
    public partial class SeleccionarCorrectas : Form
    {
        PaginaPrincipalNueva _PaginaPrincipalNueva;
        string[] Vec = new string[30] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        string[] elementos = new string[3];
        int[] numsIncorrectos = new int[3];
        int contador = 24;
        int cantErroneas = 0;
        SeleccionarCorrecto ObjetoS = new SeleccionarCorrecto();
        public SeleccionarCorrectas()
        {
            InitializeComponent();
        }

        public void Inicializar(PaginaPrincipalNueva laPaginaQueLoinstancio)
        {
            _PaginaPrincipalNueva = laPaginaQueLoinstancio;
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
        private void llenarPCBs()
        {
            if (contador == 30)
            {
                this.Close();
            }
            else
            {
                string path = "ManosQueHablan/RecursosDeGifs/";
                seleccionarGifs();
                cantErroneas = cuantosErrores();
                pcb1.Load(path + elementos[0] + ".gif");
                pcb2.Load(path + elementos[1] + ".gif");
                pcb3.Load(path + elementos[2] + ".gif");
                switch (cantErroneas)
                {
                    case 0:
                        lbl1.Text = elementos[0];
                        lbl2.Text = elementos[1];
                        lbl3.Text = elementos[2];
                        break;
                    case 1:
                        seleccionarIncorrectos(cantErroneas);
                        lbl1.Text = elementos[0];
                        lbl2.Text = elementos[1];
                        lbl3.Text = Vec[numsIncorrectos[0]];
                        break;
                    case 2:
                        seleccionarIncorrectos(cantErroneas);
                        lbl1.Text = Vec[numsIncorrectos[0]];
                        lbl2.Text = elementos[1];
                        lbl3.Text = Vec[numsIncorrectos[1]];
                        break;
                    case 3:
                        lbl1.Text = Vec[numsIncorrectos[0]];
                        lbl2.Text = Vec[numsIncorrectos[1]];
                        lbl3.Text = Vec[numsIncorrectos[2]];
                        break;
                }
                if (lbl1.Text == "ENIE"){
                    lbl1.Text = "Ñ";}
                if (lbl2.Text == "ENIE"){
                    lbl2.Text = "Ñ";}
                if (lbl3.Text == "ENIE"){
                    lbl3.Text = "Ñ";}
                if (lbl1.Text == "MENIQUE"){
                    lbl1.Text = "MEÑIQUE"; }
                if (lbl2.Text == "MENIQUE"){
                    lbl2.Text = "MEÑIQUE"; }
                if (lbl3.Text == "MENIQUE"){
                    lbl3.Text = "MEÑIQUE";}
                if (lbl1.Text == "PUNO"){
                    lbl1.Text = "PUÑO";}
                if (lbl2.Text == "PUNO"){
                    lbl2.Text = "PUÑO";}
                if (lbl3.Text == "PUNO"){
                    lbl3.Text = "PUÑO";}
            }
        }
        private void seleccionarGifs()
        {
            int contrnd = 0;
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            List<int> randomList = new List<int>();
            int randomgif = 0;
            while (contrnd != 3)
            {
                randomgif = rnd.Next(0, 29);
                if (Vec[randomgif] != "*")
                {
                    if (!randomList.Contains(randomgif))
                    {
                        randomList.Add(randomgif);
                        contrnd++;
                    }
                }
            }
            elementos[0] = Vec[randomList[0]]; 
            elementos[1] = Vec[randomList[1]];
            elementos[2] = Vec[randomList[2]];
        }
        private int cuantosErrores()
        {
            int num = 0;
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            num = rnd.Next(0, 3);
            return num;
        }
        private void seleccionarIncorrectos(int cant)
        {
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            int random = rnd.Next(0, 29);
            if (Vec[random] == "*")
            {
                seleccionarIncorrectos(cantErroneas);
            }
            else
            {
                for (int i = 0; i < cant; i++)
                {
                    numsIncorrectos[0] = random;
                }
            }
        }
        private void comprobar()
        {
            string error = "";
            string[] provicional = new string[3];
            provicional[0] = pcb1.ImageLocation;
            provicional[1] = pcb2.ImageLocation;
            provicional[2] = pcb3.ImageLocation;

            provicional[0] = provicional[0].Substring(provicional[0].Length - 19);
            provicional[1] = provicional[1].Substring(provicional[1].Length - 19);
            provicional[2] = provicional[2].Substring(provicional[2].Length - 19);

            string[] pcbE1 = provicional[0].Split('/');
            pcbE1 = pcbE1[1].Split('.');
            string[] pcbE2 = provicional[1].Split('/');
            pcbE2 = pcbE2[1].Split('.');
            string[] pcbE3 = provicional[2].Split('/');
            pcbE3 = pcbE3[1].Split('.');

            if (pcbE1[0] == "ENIE") { pcbE1[0] = "Ñ"; }
            if (pcbE2[0] == "ENIE") { pcbE2[0] = "Ñ"; }
            if (pcbE3[0] == "ENIE") { pcbE3[0] = "Ñ"; }
            if (pcbE1[0] == "PUNO") { pcbE1[0] = "PUÑO"; }
            if (pcbE2[0] == "PUNO") { pcbE2[0] = "PUÑO"; }
            if (pcbE3[0] == "PUNO") { pcbE3[0] = "PUÑO"; }
            if (pcbE1[0] == "MENIQUE") { pcbE1[0] = "MEÑIQUE"; }
            if (pcbE2[0] == "MENIQUE") { pcbE2[0] = "MEÑIQUE"; }
            if (pcbE3[0] == "MENIQUE") { pcbE3[0] = "MEÑIQUE"; }

            if (lbl1.Text == pcbE1[0])
            {
                if (cb1.Checked == false) { error = "1/"; }
            }
            else { if (cb1.Checked) { error += "1/"; } }
            if (lbl2.Text == pcbE2[0])
            {
                if (cb2.Checked == false) { error = "2/"; }
            }
            else { if (cb2.Checked) { error += "2/"; } }
            if (lbl3.Text == pcbE3[0])
            {
                if (cb3.Checked == false) { error = "3/"; }
            }
            else { if (cb3.Checked) { error += "3/"; } }

            if (error == "")
            {
                MessageBox.Show("Bien!");
                contador++;
                if (contador == 30)
                {
                    _PaginaPrincipalNueva.Cont = contador;
                }
                limpiar();
                llenarPCBs();
            }
            else
            {
                contador++;
                if (contador == 30)
                {
                    _PaginaPrincipalNueva.Cont = contador;
                }
                string[] splitError = error.Split('/');
                lbl1.ForeColor = Color.Green;
                lbl2.ForeColor = Color.Green;
                lbl3.ForeColor = Color.Green;
                lblCorrecto1.Visible = true;
                lblCorrecto2.Visible = true;
                lblCorrecto3.Visible = true;
                lblCorrecto1.Text = pcbE1[0];
                lblCorrecto2.Text = pcbE2[0];
                lblCorrecto3.Text = pcbE3[0];
                foreach (string err in splitError)
                {
                    switch (err)
                    {
                        case "1":
                            lbl1.ForeColor = Color.Red;
                            break;
                        case "2":
                            lbl2.ForeColor = Color.Red;
                            break;
                        case "3":
                            lbl3.ForeColor = Color.Red;
                            break;
                    }
                }
                if (lbl1.Text == lblCorrecto1.Text)
                {
                    lblCorrecto1.Text = "Correcta!";
                    if (lbl1.ForeColor == Color.Red) { lblCorrecto1.Text = "Era correcta"; }
                }
                if (lbl2.Text == lblCorrecto2.Text)
                {
                    lblCorrecto2.Text = "Correcta!";
                    if (lbl2.ForeColor == Color.Red) { lblCorrecto2.Text = "Era correcta"; }
                }
                if (lbl3.Text == lblCorrecto3.Text)
                {
                    lblCorrecto3.Text = "Correcta!";
                    if (lbl3.ForeColor == Color.Red) { lblCorrecto3.Text = "Era correcta"; }
                }

                if ((lbl1.Text != lblCorrecto1.Text) && (lbl1.ForeColor == Color.Green) && (lblCorrecto1.Text != "Correcta!"))
                {
                    lblCorrecto1.Text = "Correcto! La seña mostrada era " + lblCorrecto1.Text;
                }
                if ((lbl2.Text != lblCorrecto2.Text) && (lbl2.ForeColor == Color.Green) && (lblCorrecto2.Text != "Correcta!"))
                {
                    lblCorrecto2.Text = "Correcto! La seña mostrada era " + lblCorrecto2.Text;
                }
                if ((lbl3.Text != lblCorrecto3.Text) && (lbl3.ForeColor == Color.Green) && (lblCorrecto3.Text != "Correcta!"))
                {
                    lblCorrecto3.Text = "Correcto! La seña mostrada era " + lblCorrecto3.Text;
                }

                if (lblCorrecto1.Text.Length < 3)
                {
                    lblCorrecto1.Text = "Incorrecto, la seña mostrada era " + lblCorrecto1.Text;
                }
                if (lblCorrecto2.Text.Length < 3)
                {
                    lblCorrecto2.Text = "Incorrecto, la seña mostrada era " + lblCorrecto2.Text;
                }
                if (lblCorrecto3.Text.Length < 3)
                {
                    lblCorrecto3.Text = "Incorrecto, la seña mostrada era " + lblCorrecto3.Text;
                }
                pcbComprobar.Text = "Siguiente";
                FuncionesUtiles.CargarImagen(pcbComprobar, "aceptar.png");
            }
        }
        private void limpiar()
        {
            for (int i = 0; i < 3; i++)
            {
                elementos[i] = null;
                numsIncorrectos[i] = 0;
            }
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lblCorrecto1.Visible = false;
            lblCorrecto2.Visible = false;
            lblCorrecto3.Visible = false;
        }

        private void SeleccionarCorrectas_Load(object sender, EventArgs e)
        {
            pcbComprobar.Text = "Comprobar";
            
            CargarImagenes();
            lblTitulo.Text = "Seleccione la igualdad correcta";
            llenarPCBs();
            lblProgress.Text = "24/30";
        }
        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(pcbComprobar, "comprobar.png");
            FuncionesUtiles.CargarImagen(pcbPasar, "Saltear.png");
            FuncionesUtiles.CargarImagen(btnVolver, "volver.png");
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                cb3.Checked = false;
            }
            else
            {
                cb3.Checked = true;
            }
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                cb2.Checked = false;
            }
            else
            {
                cb2.Checked = true;
            }
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                cb1.Checked = false;
            }
            else
            {
                cb1.Checked = true;
            }
        }

        private void pcbPasar_Click(object sender, EventArgs e)
        {
            contador = 30;
           _PaginaPrincipalNueva.Cont = contador;
            _PaginaPrincipalNueva.ContPasar++;
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _PaginaPrincipalNueva.Salir = true;
            this.Close();
        }

        private void pcbComprobar_Click(object sender, EventArgs e)
        {
            if (pcbComprobar.Text == "Comprobar")
            {
                comprobar();
            }
            else
            {
                limpiar();
                llenarPCBs();
                pcbComprobar.Text = "Comprobar";
                FuncionesUtiles.CargarImagen(pcbComprobar, "comprobar.png");
            }
            FuncionesUtiles FUtiles = new FuncionesUtiles();
            FUtiles.Progress(lblProgress, contador);
        }
    }
}
