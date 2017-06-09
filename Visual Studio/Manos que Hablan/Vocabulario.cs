using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manos_que_Hablan
{
    public partial class Vocabulario : Form
    {
        string[] Palabras = new string[30];
        string Label = "lbl";
        public string[] PalabrasObtenidas
        {
            get { return Palabras; }
            set
            {
                for (int i = 0; i < 30; i++)
                {
                    Palabras[i] = value[i];
                }
            }
        }
        public Vocabulario()
        {
            InitializeComponent();
        }

        private void Vocabulario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                Label = "lbl";
                Label = Label + (i + 1).ToString();
                switch (Label)
                {
                    case "lbl1":
                        lbl1.Text = Palabras[i];
                        break;
                    case "lbl2":
                        lbl2.Text = Palabras[i];
                        break;
                    case "lbl3":
                        lbl3.Text = Palabras[i];
                        break;
                    case "lbl4":
                        lbl4.Text = Palabras[i];
                        break;
                    case "lbl5":
                        lbl5.Text = Palabras[i];
                        break;
                    case "lbl6":
                        lbl6.Text = Palabras[i];
                        break;
                    case "lbl7":
                        lbl7.Text = Palabras[i];
                        break;
                    case "lbl8":
                        lbl8.Text = Palabras[i];
                        break;
                    case "lbl9":
                        lbl9.Text = Palabras[i];
                        break;
                    case "lbl10":
                        lbl10.Text = Palabras[i];
                        break;
                    case "lbl11":
                        lbl11.Text = Palabras[i];
                        break;
                    case "lbl12":
                        lbl12.Text = Palabras[i];
                        break;
                    case "lbl13":
                        lbl13.Text = Palabras[i];
                        break;
                    case "lbl14":
                        lbl14.Text = Palabras[i];
                        break;
                    case "lbl15":
                        lbl15.Text = Palabras[i];
                        break;
                    case "lbl16":
                        lbl16.Text = Palabras[i];
                        break;
                    case "lbl17":
                        lbl17.Text = Palabras[i];
                        break;
                    case "lbl18":
                        lbl18.Text = Palabras[i];
                        break;
                    case "lbl19":
                        lbl19.Text = Palabras[i];
                        break;
                    case "lbl20":
                        lbl20.Text = Palabras[i];
                        break;
                    case "lbl21":
                        lbl21.Text = Palabras[i];
                        break;
                    case "lbl22":
                        lbl22.Text = Palabras[i];
                        break;
                    case "lbl23":
                        lbl23.Text = Palabras[i];
                        break;
                    case "lbl24":
                        lbl24.Text = Palabras[i];
                        break;
                    case "lbl25":
                        lbl25.Text = Palabras[i];
                        break;
                    case "lbl26":
                        lbl26.Text = Palabras[i];
                        break;
                    case "lbl27":
                        lbl27.Text = Palabras[i];
                        break;
                    case "lbl28":
                        lbl28.Text = Palabras[i];
                        break;
                    case "lbl29":
                        lbl29.Text = Palabras[i];
                        break;
                    case "lbl30":
                        lbl30.Text = Palabras[i];
                        break;

                }
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl1.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }
        public void ocultar()
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl13.Visible = false;
            lbl14.Visible = false;
            lbl15.Visible = false;
            lbl16.Visible = false;
            lbl17.Visible = false;
            lbl18.Visible = false;
            lbl19.Visible = false;
            lbl21.Visible = false;
            lbl22.Visible = false;
            lbl23.Visible = false;
            lbl24.Visible = false;
            lbl25.Visible = false;
            lbl26.Visible = false;
            lbl27.Visible = false;
            lbl28.Visible = false;
            lbl29.Visible = false;
            lbl30.Visible = false;
            pcbGif.Visible = true;
            btnClose.Visible = true;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl2.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl3.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl4.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl5.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl6.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl7.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl8.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl9.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl10.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl11.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl12.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl13.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl14.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl15.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl16.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl17_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl17.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl18.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");

        }

        private void lbl19_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl19.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl20.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl21.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl22.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl23_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl23.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl24_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl24.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl25_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl25.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl26_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl26.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl27_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl27.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl28_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl28.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl29_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl29.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void lbl30_Click(object sender, EventArgs e)
        {
            ocultar();
            lbl20.Text = lbl30.Text;
            pcbGif.Image = Image.FromFile("C:/Manos-Que-Hablan/Visual Studio/Gifs/" + lbl20.Text + ".gif");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;
            lbl10.Visible = true;
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl13.Visible = true;
            lbl14.Visible = true;
            lbl15.Visible = true;
            lbl16.Visible = true;
            lbl17.Visible = true;
            lbl18.Visible = true;
            lbl19.Visible = true;
            lbl21.Visible = true;
            lbl22.Visible = true;
            lbl23.Visible = true;
            lbl24.Visible = true;
            lbl25.Visible = true;
            lbl26.Visible = true;
            lbl27.Visible = true;
            lbl28.Visible = true;
            lbl29.Visible = true;
            lbl30.Visible = true;
            pcbGif.Visible = false;
            btnClose.Visible = false;
            lbl20.Text = "Q";
        }
    }
}
