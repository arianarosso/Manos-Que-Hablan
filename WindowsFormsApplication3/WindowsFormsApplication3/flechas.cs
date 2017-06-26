using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class flechas : Form
    {
        int[] Val = new int[5];
        string[] VecABC = new string[30] { "A", "B", "C", "CH", "D", "E", "F", "G", "H", "I", "J", "K", "L", "LL", "M", "N", "Ñ", "O", "P", "Q", "R", "RR", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        //--------------DIBUJO------------------------------------
        int coordenadas1;
        int coordenadas2;
        string dibujar = "";
        bool hayFlecha1 = false;
        bool hayFlecha2 = false;
        bool hayFlecha3 = false;
        //--------------LOGICA------------------------------------
        string elemento1;
        string elemento2;
        string elemento3;
        string gifIncorrecto;
        string pcbIncorrecto;
        string provicional;
        string respuesta1;
        string respuesta2;
        string respuesta3;
        string respuesta4;
        public flechas()
        {
            InitializeComponent();
        }
        //--------------DIBUJO------------------------------------
        private void pcb1_Click(object sender, EventArgs e)
        {
            if (hayFlecha1 == true)
            {
                coordenadas1 = 0;
            }
            else
            {
                dibujar = "1";
                coordenadas1 = 136;
            }
            //---------------------------
            provicional = elemento1;
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
                coordenadas1 = 308;
            }
            //---------------------------
            provicional = elemento2;
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
                coordenadas1 = 464;
            }
            //---------------------------
            provicional = elemento3;
        }
        private void pcb1_Paint(object sender, PaintEventArgs e)
        {
            if (dibujar == "1")
            {
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(100, 50, 20, 20));
            }
        }
        private void pcb2_Paint(object sender, PaintEventArgs e)
        {
            if (dibujar == "2")
            {
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(100, 50, 20, 20));
            }
        }
        private void pcb3_Paint(object sender, PaintEventArgs e)
        {
            if (dibujar == "3")
            {
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(100, 50, 20, 20));
            }
        }
        private void pcbR1_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 100;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            respuesta1 = provicional;
        }
        public void dibujarFlecha(int y1, int y2)
        {
            if (!(y1 == 0))
            {
                Graphics graphics = CreateGraphics();
                Pen p = new Pen(Color.Red, 5);
                graphics.DrawLine(p, 210, y1, 731, y2);
                graphics.Dispose();
            }
            else
            {
                MessageBox.Show("djkgsiu");
            }
        }
        private void pcbR2_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 246;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            respuesta2 = provicional;
        }
        private void pcbR3_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 399;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            respuesta3 = provicional;
        }
        private void pcbR4_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 554;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            respuesta4 = provicional;
        }
        public void invalidate(int coordenadas1)
        {
            if (coordenadas1 == 136)
            {
                hayFlecha1 = true;
            }
            if (coordenadas1 == 308)
            {
                hayFlecha2 = true;
            }
            if (coordenadas1 == 464)
            {
                hayFlecha3 = true;
            }
        }
        //--------------LOGICA------------------------------------
        public void seleccionarGifs()
        {
            int randomgif;
            Random rnd = new Random(DateTime.Now.Ticks.GetHashCode());
            /*
             public List<int> randomList = new List<int>();
                int MyNumber = 0;
                private void NewNumber()
                {
                    MyNumber = a.Next(0, 10);
                    if (!randomList.Contains(MyNumber))
                        randomList.Add(MyNumber);
                }
                */
            randomgif = rnd.Next(1, 30);
            elemento1 = VecABC[randomgif];
            randomgif = rnd.Next(1, 30);
            elemento2 = VecABC[randomgif];
            randomgif = rnd.Next(1, 30);
            elemento3 = VecABC[randomgif];
            validarRandoms();
        }
        public void validarRandoms()
        {
            if(elemento1 == elemento2 || elemento1 == elemento3 || elemento1 == gifIncorrecto || elemento2 == elemento1 || elemento2 == elemento3 || elemento2 == gifIncorrecto || elemento3 == elemento1 || elemento3 == elemento2 || elemento3 == gifIncorrecto || gifIncorrecto == elemento1 || gifIncorrecto == elemento2 || gifIncorrecto == elemento3)
            {
                seleccionarGifs();
            }
        }
        public void elegirIncorrecta()
        {
            Random r = new Random();
            int incorrecta = r.Next(1, 31);
            gifIncorrecto = "F:/PROYECTO FINAL/WindowsFormsApplication3/Imgs/" + VecABC[incorrecta] + ".gif";
        }
        public string pcbRandom()
        {
            Random random = new Random();
            int randompcb = random.Next(1, 5);
            string pcb;
            pcb = "pcbR" + randompcb.ToString();
            return pcb;
        }
        public void llenarPCBs()
        {
            string path = "F:/PROYECTO FINAL/WindowsFormsApplication3/Imgs/";
            pcbIncorrecto = pcbRandom();
            elegirIncorrecta();
            switch (pcbIncorrecto)
            {
                case "pcbR1":
                    seleccionarGifs();
                    pcbR1.Image = Image.FromFile(gifIncorrecto);
                    pcbR2.Image = Image.FromFile(path + elemento1 + ".gif");
                    pcbR3.Image = Image.FromFile(path + elemento2 + ".gif");
                    pcbR4.Image = Image.FromFile(path + elemento3 + ".gif");
                    break;
                case "pcbR2":
                    seleccionarGifs();
                    pcbR2.Image = Image.FromFile(gifIncorrecto);
                    pcbR1.Image = Image.FromFile(path + elemento1 + ".gif");
                    pcbR3.Image = Image.FromFile(path + elemento2 + ".gif");
                    pcbR4.Image = Image.FromFile(path + elemento3 + ".gif");
                    break;
                case "pcbR3":
                    seleccionarGifs();
                    pcbR3.Image = Image.FromFile(gifIncorrecto);
                    pcbR2.Image = Image.FromFile(path + elemento1 + ".gif");
                    pcbR1.Image = Image.FromFile(path + elemento2 + ".gif");
                    pcbR4.Image = Image.FromFile(path + elemento3 + ".gif");
                    break;
                case "pcbR4":
                    seleccionarGifs();
                    pcbR4.Image = Image.FromFile(gifIncorrecto);
                    pcbR2.Image = Image.FromFile(path + elemento1 + ".gif");
                    pcbR3.Image = Image.FromFile(path + elemento2 + ".gif");
                    pcbR1.Image = Image.FromFile(path + elemento3 + ".gif");
                    break;
            }
            pcb1.Image = Image.FromFile(path + elemento1 + ".png");
            pcb2.Image = Image.FromFile(path + elemento2 + ".png");
            pcb3.Image = Image.FromFile(path + elemento3 + ".png");
        }
        private void flechas_Load(object sender, EventArgs e)
        {
            llenarPCBs();
        }
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
