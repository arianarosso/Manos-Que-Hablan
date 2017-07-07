using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnirConFlechas
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
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
                coordenadas1 = 78;
                pcbFondo1.BackColor = Color.Red;
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
                coordenadas1 = 221;
                pcbFondo2.BackColor = Color.Red;
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
                coordenadas1 = 380;
                pcbFondo3.BackColor = Color.Red;
                pcbFondo3.Visible = true;
            }
            //---------------------------
            provicional = elementos[2];
            pcbprovicional = "pcbFondo3";
        }
        private void limpiarFondos()
        {
            if (pcbFondo1.BackColor == Color.Red)
            {
                pcbFondo1.Visible = false;
                pcbFondo1.BackColor = Color.Green;
            }
            if (pcbFondo2.BackColor == Color.Red)
            {
                pcbFondo2.Visible = false;
                pcbFondo2.BackColor = Color.Green;
            }
            if (pcbFondo3.BackColor == Color.Red)
            {
                pcbFondo3.Visible = false;
                pcbFondo3.BackColor = Color.Green;
            }
        }
        private void pcbR1_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 57;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec1[0] = provicional;
            vec1[2] = pcbprovicional;
            cont++;
            limpiarFondos();
        }
        private void pcbR2_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 168;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec2[0] = provicional;
            vec2[2] = pcbprovicional;
            cont++;
            limpiarFondos();
        }
        private void pcbR3_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 285;
                dibujarFlecha(coordenadas1, coordenadas2);
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec3[0] = provicional;
            vec3[2] = pcbprovicional;
            cont++;
            limpiarFondos();
        }
        private void pcbR4_Click(object sender, EventArgs e)
        {
            if (!(dibujar == ""))
            {
                coordenadas2 = 418;
                dibujarFlecha(coordenadas1, coordenadas2);
                dibujarTriangulo();
                invalidate(coordenadas1);
                dibujar = "";
            }
            vec4[0] = provicional;
            vec4[2] = pcbprovicional;
            cont++;
            limpiarFondos();
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
                Pen p = new Pen(Color.Red, 5);
                graphics.DrawLine(p, 165, y1, 707, y2);
                graphics.Dispose();
            }
            else
            {
                MessageBox.Show("No");
            }
        }
        private void dibujarTriangulo()
        {
           /* Graphics graphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            Point[] t = { new Point(500, 50), new Point(550, 50), new Point(525, 100) };
            graphics.FillPolygon(brush, t);
            graphics.Dispose();*/
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
                if (!randomList.Contains(randomgif))
                {
                    randomList.Add(randomgif);
                    contrnd++;
                }
            }
            elementos[0] = VecABC[randomList[0]];
            elementos[1] = VecABC[randomList[1]];
            elementos[2] = VecABC[randomList[2]];
        }
        private void elegirIncorrecta()
        {
            Random r = new Random();
            incorrecta = r.Next(1, 30);
            gifIncorrecto = "C:/UnirConFlechas/Imgs/" + VecABC[incorrecta] + ".gif";
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
            string path = "C:/UnirConFlechas/Imgs/";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarPCBs();
        }
        private void comprobar()
        {
            string error = "";
            vec1[1] = pcbR1.ImageLocation;
            vec2[1] = pcbR2.ImageLocation;
            vec3[1] = pcbR3.ImageLocation;
            vec4[1] = pcbR4.ImageLocation;

            vec1[1] = vec1[1].Substring(vec1[1].Length - 7);
            vec2[1] = vec2[1].Substring(vec2[1].Length - 7);
            vec3[1] = vec3[1].Substring(vec3[1].Length - 7);
            vec4[1] = vec4[1].Substring(vec4[1].Length - 7);

            string[] vecSplit1 = vec1[1].Split('/');
            vecSplit1 = vecSplit1[1].Split('.');
            string[] vecSplit2 = vec2[1].Split('/');
            vecSplit2 = vecSplit2[1].Split('.');
            string[] vecSplit3 = vec3[1].Split('/');
            vecSplit3 = vecSplit3[1].Split('.');
            string[] vecSplit4 = vec4[1].Split('/');
            vecSplit4 = vecSplit4[1].Split('.');

            if (pcbFondoR1.Visible == false)
            {
                if (((vec1[0] != vecSplit1[0]) && (vec1[0] != null)) || ((vec1[0] == null) && (vecSplit1[0] != VecABC[incorrecta])))
                {
                    error += "1/";
                    pcberror[0] = vec1[2];
                }
            }
            if (pcbFondoR2.Visible == false)
            {
                if (((vec2[0] != vecSplit2[0]) && (vec2[0] != null)) || ((vec2[0] == null) && (vecSplit2[0] != VecABC[incorrecta])))
                {
                    error += "2/";
                    pcberror[1] = vec2[2];
                }
            }
            if (pcbFondoR3.Visible == false)
            {
                if (((vec3[0] != vecSplit3[0]) && (vec3[0] != null)) || ((vec3[0] == null) && (vecSplit3[0] != VecABC[incorrecta])))
                {
                    error += "3/";
                    pcberror[2] = vec3[2];
                }
            }
            if (pcbFondoR4.Visible == false)
            {
                if (((vec4[0] != vecSplit4[0]) && (vec4[0] != null)) || ((vec4[0] == null) && (vecSplit4[0] != VecABC[incorrecta])))
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
                llenarPCBs();
            }
            else
            {
                dibujarCorrectos(error);
            }
        }
        private void btnComprobar_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
