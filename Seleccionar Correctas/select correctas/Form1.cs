using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace select_correctas
{
    public partial class Form1 : Form
    {
        string[] VecABC = new string[30] { "A", "B", "C", "CH", "D", "E", "F", "G", "H", "I", "J", "K", "L", "LL", "M", "N", "Ñ", "O", "P", "Q", "R", "RR", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] elementos = new string[3];
        int[] numsIncorrectos = new int[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarPCBs();
        }
        private void llenarPCBs()
        {
            string path = "F:/select correctas/Imgs/";
            seleccionarGifs();
            int cantErroneas = cuantosErrores();
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
                    lbl3.Text = VecABC[numsIncorrectos[0]];
                    break;
                case 2:
                    seleccionarIncorrectos(cantErroneas);
                    lbl1.Text = VecABC[numsIncorrectos[0]];
                    lbl2.Text = elementos[1];
                    lbl3.Text = VecABC[numsIncorrectos[1]];
                    break;
                case 3:
                    lbl1.Text = VecABC[numsIncorrectos[0]];
                    lbl2.Text = VecABC[numsIncorrectos[1]];
                    lbl3.Text = VecABC[numsIncorrectos[2]];
                    break;
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
            for (int i = 0; i < cant; i++)
            {
                numsIncorrectos[0] = rnd.Next(0, 29);
            }
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (btnComprobar.Text == "Comprobar")
            {
                comprobar();
            }
            else
            {
                limpiar();
                llenarPCBs();
                btnComprobar.Text = "Comprobar";
            }
        }
        private void comprobar()
        {
            string error = "";
            string[] provicional = new string[3];
            provicional[0] = pcb1.ImageLocation;
            provicional[1] = pcb2.ImageLocation;
            provicional[2] = pcb3.ImageLocation;

            provicional[0] = provicional[0].Substring(provicional[0].Length - 7);
            provicional[1] = provicional[1].Substring(provicional[1].Length - 7);
            provicional[2] = provicional[2].Substring(provicional[2].Length - 7);

            string[] pcbE1 = provicional[0].Split('/');
            pcbE1 = pcbE1[1].Split('.');
            string[] pcbE2 = provicional[1].Split('/');
            pcbE2 = pcbE2[1].Split('.');
            string[] pcbE3 = provicional[2].Split('/');
            pcbE3 = pcbE3[1].Split('.');

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
                limpiar();
                llenarPCBs();
            }
            else
            {
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
                if (lbl1.Text == lblCorrecto1.Text) { lblCorrecto1.Text = "Correcta!";
                    if (lbl1.ForeColor == Color.Red) { lblCorrecto1.Text = "Era correcta"; }
                }
                if (lbl2.Text == lblCorrecto2.Text) { lblCorrecto2.Text = "Correcta!";
                    if (lbl2.ForeColor == Color.Red) { lblCorrecto2.Text = "Era correcta"; }
                }
                if (lbl3.Text == lblCorrecto3.Text) { lblCorrecto3.Text = "Correcta!";
                    if (lbl3.ForeColor == Color.Red) { lblCorrecto3.Text = "Era correcta"; }
                }
                btnComprobar.Text = "Siguiente";
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
    }
}
