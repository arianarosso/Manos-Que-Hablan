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
    public partial class UnirConFlechas : Form
    {
        PaginaPrincipalNueva _PaginaPrincipalNueva;
        //--------------DIBUJO------------------------------------
        int coordenadas1;
        int coordenadas2;
        string dibujar = "";
        bool hayFlecha1 = false;
        bool hayFlecha2 = false;
        bool hayFlecha3 = false;
        //--------------LOGICA------------------------------------
        string[] elementos = new string[3];
        string gifIncorrecto;
        string pcbIncorrecto;
        string provicional;
        string pcbprovicional;
        string[] vec1 = new string[3];
        string[] vec2 = new string[3];
        string[] vec3 = new string[3];
        string[] vec4 = new string[3];
        int cont = 0;
        int incorrecta = 0;
        string[] pcberror = new string[4];
        bool juegoEmpezado = false;
        int contador = 19;
        string[] Vec = new string[30] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        //PaginaPrincipalNueva PagPrincipal = new PaginaPrincipalNueva();
        SeleccionarCorrecto ObjetoS = new SeleccionarCorrecto();
        string[] vecSplit1;
        string[] vecSplit2;
            string[] vecSplit3;
            string[] vecSplit4;
        int ContPistas = 0;
        public UnirConFlechas()
        {
            InitializeComponent();
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
        private void limpiarFondos()
        {
            if (pcbFondo1.BackColor == Color.Black)
            {
                pcbFondo1.Visible = false;
                pcbFondo1.BackColor = Color.Green;
            }
            if (pcbFondo2.BackColor == Color.Black)
            {
                pcbFondo2.Visible = false;
                pcbFondo2.BackColor = Color.Green;
            }
            if (pcbFondo3.BackColor == Color.Black)
            {
                pcbFondo3.Visible = false;
                pcbFondo3.BackColor = Color.Green;
            }
        }
        private void invalidate(int coordenadas1)
        {
            if (coordenadas1 == 78)
            {
                hayFlecha1 = true;
            }
            if (coordenadas1 == 221)
            {
                hayFlecha2 = true;
            }
            if (coordenadas1 == 380)
            {
                hayFlecha3 = true;
            }
        }
        private void dibujarFlecha(int y1, int y2)
        {
            if (!(y1 == 0))
            {
                Graphics graphics = CreateGraphics();
                Pen p = new Pen(Color.Black, 5);
                graphics.DrawLine(p, 242, y1, 811, y2);
                graphics.Dispose();
            }
            else
            {
                MessageBox.Show("No");
            }
        }
        //---------------------------------------LOGICA---------------------------------------
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
        private void elegirIncorrecta()
        {
            //path
            Random r = new Random();
            incorrecta = r.Next(1, 30);
            if (Vec[incorrecta] == "*")
            {
                elegirIncorrecta();
            }
            else
            {
                gifIncorrecto = "ManosQueHablan/RecursosDeGifs/" + Vec[incorrecta] + ".gif";
            }
        }
        private string pcbRandom()
        {
            Random random = new Random();
            int randompcb = random.Next(1, 5);
            string pcb;
            pcb = "pcbR" + randompcb.ToString();
            return pcb;
        }
        private void llenarPCBs()
        {
            if (contador == 24)
            {
                this.Close();
            }
            else
            {
                string path = "ManosQueHablan/RecursosDeGifs/";
                pcbIncorrecto = pcbRandom();
                elegirIncorrecta();
                switch (pcbIncorrecto)
                {
                    case "pcbR1":
                        seleccionarGifs();
                        pcbR1.Load(gifIncorrecto);
                        pcbR2.Load(path + elementos[0] + ".gif");
                        pcbR3.Load(path + elementos[1] + ".gif");
                        pcbR4.Load(path + elementos[2] + ".gif");
                        break;
                    case "pcbR2":
                        seleccionarGifs();
                        pcbR2.Load(gifIncorrecto);
                        pcbR1.Load(path + elementos[2] + ".gif");
                        pcbR3.Load(path + elementos[1] + ".gif");
                        pcbR4.Load(path + elementos[0] + ".gif");
                        break;
                    case "pcbR3":
                        seleccionarGifs();
                        pcbR3.Load(gifIncorrecto);
                        pcbR2.Load(path + elementos[0] + ".gif");
                        pcbR1.Load(path + elementos[1] + ".gif");
                        pcbR4.Load(path + elementos[2] + ".gif");
                        break;
                    case "pcbR4":
                        seleccionarGifs();
                        pcbR4.Load(gifIncorrecto);
                        pcbR2.Load(path + elementos[1] + ".gif");
                        pcbR3.Load(path + elementos[0] + ".gif");
                        pcbR1.Load(path + elementos[2] + ".gif");
                        break;
                }
                pcb1.Load(path + elementos[0] + ".png");
                pcb2.Load(path + elementos[1] + ".png");
                pcb3.Load(path + elementos[2] + ".png");
            }
        }
        public void split()
        {
            vec1[1] = pcbR1.ImageLocation;
            vec2[1] = pcbR2.ImageLocation;
            vec3[1] = pcbR3.ImageLocation;
            vec4[1] = pcbR4.ImageLocation;

            vec1[1] = vec1[1].Substring(vec1[1].Length - 19);
            vec2[1] = vec2[1].Substring(vec2[1].Length - 19);
            vec3[1] = vec3[1].Substring(vec3[1].Length - 19);
            vec4[1] = vec4[1].Substring(vec4[1].Length - 19);

            vecSplit1 = vec1[1].Split('/');
            vecSplit1 = vecSplit1[1].Split('.');
            vecSplit2 = vec2[1].Split('/');
            vecSplit2 = vecSplit2[1].Split('.');
            vecSplit3 = vec3[1].Split('/');
            vecSplit3 = vecSplit3[1].Split('.');
            vecSplit4 = vec4[1].Split('/');
            vecSplit4 = vecSplit4[1].Split('.');
        }
        private void comprobar()
        {
            string error = "";
            split();

            if (pcbFondoR1.Visible == false)
            {
                if (((vec1[0] != vecSplit1[0]) && (vec1[0] != null)) || ((vec1[0] == null) && (vecSplit1[0] != Vec[incorrecta])))
                {
                    error += "1/";
                    pcberror[0] = vec1[2];
                }
            }
            if (pcbFondoR2.Visible == false)
            {
                if (((vec2[0] != vecSplit2[0]) && (vec2[0] != null)) || ((vec2[0] == null) && (vecSplit2[0] != Vec[incorrecta])))
                {
                    error += "2/";
                    pcberror[1] = vec2[2];
                }
            }
            if (pcbFondoR3.Visible == false)
            {
                if (((vec3[0] != vecSplit3[0]) && (vec3[0] != null)) || ((vec3[0] == null) && (vecSplit3[0] != Vec[incorrecta])))
                {
                    error += "3/";
                    pcberror[2] = vec3[2];
                }
            }
            if (pcbFondoR4.Visible == false)
            {
                if (((vec4[0] != vecSplit4[0]) && (vec4[0] != null)) || ((vec4[0] == null) && (vecSplit4[0] != Vec[incorrecta])))
                {
                    error += "4/";
                    pcberror[3] = vec4[2];
                }
            }
            if (error == "")
            {
                error = "Bien!";
            }
            limpiar();
            if (error == "Bien!")
            {
                MessageBox.Show(error);
                reiniciar();
                contador++;
                if (contador == 24)
                {
                    _PaginaPrincipalNueva.Cont = contador;
                }
                llenarPCBs();
            }
            else
            {
                dibujarCorrectos(error);
            }
        }
        private void limpiar()
        {
            Invalidate();
            cont = 0;
            vec1[0] = null;
            vec2[0] = null;
            vec3[0] = null;
            vec4[0] = null;
            vec1[1] = null;
            vec2[1] = null;
            vec3[1] = null;
            vec4[1] = null;
            provicional = "";
            hayFlecha1 = false;
            hayFlecha2 = false;
            hayFlecha3 = false;
            vecSplit1[0] = null;
            vecSplit3[0] = null;
            vecSplit2[0] = null;
            vecSplit4[0] = null;
            vecSplit1[1] = null;
            vecSplit3[1] = null;
            vecSplit2[1] = null;
            vecSplit4[1] = null;
        }
        private void reiniciar()
        {
            pcbFondoR1.Visible = false;
            pcbFondoR2.Visible = false;
            pcbFondoR3.Visible = false;
            pcbFondoR4.Visible = false;
            pcbFondo1.Visible = false;
            pcbFondo2.Visible = false;
            pcbFondo3.Visible = false;
            pcbR1.Enabled = true;
            pcbR2.Enabled = true;
            pcbR3.Enabled = true;
            pcbR4.Enabled = true;
            pcb1.Enabled = true;
            pcb2.Enabled = true;
            pcb3.Enabled = true;
        }
        private void dibujarCorrectos(string error)
        {
            string[] splitError = error.Split('/');
            pcbFondoR1.Visible = true;
            pcbFondoR2.Visible = true;
            pcbFondoR3.Visible = true;
            pcbFondoR4.Visible = true;
            pcbFondo1.Visible = true;
            pcbFondo2.Visible = true;
            pcbFondo3.Visible = true;
            pcb1.Enabled = false;
            pcb2.Enabled = false;
            pcb3.Enabled = false;
            foreach (string err in splitError)
            {
                if (err == "1")
                {
                    pcbFondoR1.Visible = false;
                    switch (pcberror[0])
                    {
                        case "pcbFondo1":
                            pcbFondo1.Visible = false;
                            pcb1.Enabled = true;
                            break;
                        case "pcbFondo2":
                            pcbFondo2.Visible = false;
                            pcb2.Enabled = true;
                            break;
                        case "pcbFondo3":
                            pcbFondo3.Visible = false;
                            pcb3.Enabled = true;
                            break;
                    }
                }
                if (err == "2")
                {
                    pcbFondoR2.Visible = false;
                    switch (pcberror[1])
                    {
                        case "pcbFondo1":
                            pcbFondo1.Visible = false;
                            pcb1.Enabled = true;
                            break;
                        case "pcbFondo2":
                            pcbFondo2.Visible = false;
                            pcb2.Enabled = true;
                            break;
                        case "pcbFondo3":
                            pcbFondo3.Visible = false;
                            pcb3.Enabled = true;
                            break;
                    }
                }
                if (err == "3")
                {
                    pcbFondoR3.Visible = false;
                    switch (pcberror[2])
                    {
                        case "pcbFondo1":
                            pcbFondo1.Visible = false;
                            pcb1.Enabled = true;
                            break;
                        case "pcbFondo2":
                            pcbFondo2.Visible = false;
                            pcb2.Enabled = true;
                            break;
                        case "pcbFondo3":
                            pcbFondo3.Visible = false;
                            pcb3.Enabled = true;
                            break;
                    }
                }
                if (err == "4")
                {
                    pcbFondoR4.Visible = false;
                    switch (pcberror[3])
                    {
                        case "pcbFondo1":
                            pcbFondo1.Visible = false;
                            pcb1.Enabled = true;
                            break;
                        case "pcbFondo2":
                            pcbFondo2.Visible = false;
                            pcb2.Enabled = true;
                            break;
                        case "pcbFondo3":
                            pcbFondo3.Visible = false;
                            pcb3.Enabled = true;
                            break;
                    }
                }
                juegoEmpezado = true;
            }
        }

        public void Inicializar(PaginaPrincipalNueva laPaginaQueLoinstancio)
        {
            _PaginaPrincipalNueva = laPaginaQueLoinstancio;
        }
        private void UnirConFlechas_Load_1(object sender, EventArgs e)
        {
            CargarImagenes();
            lblTitulo.Text = "Una con flechas";
            llenarPCBs();
            lblProgress.Text = "19/30";
        }

        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(pcbComprobar, "comprobar.png");
            FuncionesUtiles.CargarImagen(pcbPasar, "Saltear.png");
            FuncionesUtiles.CargarImagen(btnVolver, "volver.png");
            FuncionesUtiles.CargarImagen(pcbPista, "pista.png");
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            if (hayFlecha1 == true)
            {
                coordenadas1 = 0;
            }
            else
            {
                dibujar = "1";
                coordenadas1 = 149;
                pcbFondo1.BackColor = Color.Black;
                pcbFondo1.Visible = true;
            }
            //---------------------------
            provicional = elementos[0];
            pcbprovicional = "pcbFondo1";
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            if (hayFlecha2 == true)
            {
                coordenadas1 = 0;
            }
            else
            {
                dibujar = "2";
                coordenadas1 = 294;
                pcbFondo2.BackColor = Color.Black;
                pcbFondo2.Visible = true;
            }
            //---------------------------
            provicional = elementos[1];
            pcbprovicional = "pcbFondo2";
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            if (hayFlecha3 == true)
            {
                coordenadas1 = 0;
            }
            else
            {
                dibujar = "3";
                coordenadas1 = 430;
                pcbFondo3.BackColor = Color.Black;
                pcbFondo3.Visible = true;
            }
            //---------------------------
            provicional = elementos[2];
            pcbprovicional = "pcbFondo3";
        }

        private void pcbR1_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 71;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec1[0] = provicional;
            vec1[2] = pcbprovicional;
            string provVariable = pcbprovicional;
            switchPcbs(provVariable);
            cont++;
            limpiarFondos();
        }
        public void switchPcbs(string prov)
        {
            switch (prov)
            {
                case "pcbFondo1":
                    pcb1.Enabled = false;
                    break;
                case "pcbFondo2":
                    pcb2.Enabled = false;
                    break;
                case "pcbFondo3":
                    pcb3.Enabled = false;
                    break;
            }
        }
        private void pcbR2_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 215;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec2[0] = provicional;
            vec2[2] = pcbprovicional;
            string provVariable = pcbprovicional;
            switchPcbs(provVariable);
            cont++;
            limpiarFondos();
        }

        private void pcbR3_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 362;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec3[0] = provicional;
            vec3[2] = pcbprovicional;
            string provVariable = pcbprovicional;
            switchPcbs(provVariable);
            cont++;
            limpiarFondos();
        }

        private void pcbR4_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 504;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec4[0] = provicional;
            vec4[2] = pcbprovicional;
            string provVariable = pcbprovicional;
            switchPcbs(provVariable);
            cont++;
            limpiarFondos();
        }

        private void pcbPasar_Click(object sender, EventArgs e)
        {
            contador = 24;
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
            if (cont < 3)
            {
                if (juegoEmpezado == false)
                {
                    MessageBox.Show("Unir con flechas todas las imágenes");
                }
                else
                {
                    comprobar();
                }
            }
            else
            {
                comprobar();
            }
            FuncionesUtiles FUtiles = new FuncionesUtiles();
            FUtiles.Progress(lblProgress, contador);
        }

        private void pcbPista_Click(object sender, EventArgs e)
        {
            if (ContPistas < 4)
            {
                buscarRandom();
            }
        }
        public void buscarRandom()
        {
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            int random = rnd.Next(0, 4);
            split();
            switch (random)
            {
                case 0:
                    if (lblPista1.Text == "")
                    {
                        ContPistas++;
                        lblPista1.Text = vecSplit1[0];
                    }
                    else
                    {
                        buscarRandom();
                    }
                    break;
                case 1:
                    if (lblPista2.Text == "")
                    {
                        ContPistas++;
                        lblPista2.Text = vecSplit2[0];
                    }
                    else
                    {
                        buscarRandom();
                    }
                    break;
                case 2:
                    if (lblPista3.Text == "")
                    {
                        ContPistas++;
                        lblPista3.Text = vecSplit3[0];
                    }
                    else
                    {
                        buscarRandom();
                    }
                    break;
                case 3:
                    if (lblPista4.Text == "")
                    {
                        ContPistas++;
                        lblPista4.Text = vecSplit4[0];
                    }
                    else
                    {
                        buscarRandom();
                    }
                    break;
            }
        }
    }
}