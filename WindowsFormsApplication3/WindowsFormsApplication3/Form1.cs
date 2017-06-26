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
    public partial class Form1 : Form
    {
      
        string correcto = "1";
       // Form1 form = new Form1();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pcb1_MouseDown(object sender, MouseEventArgs e)
        {
           /* pcbpos1.AllowDrop = true;
            PictureBox pcb1 = (PictureBox)sender;
            pcb1.Select();
            pcb1.DoDragDrop(pcb1.Image, DragDropEffects.Copy);
            if (!(pcbpos1.Image == null) )
            {
                pcb1.Visible = false;
            }*/
                
        }
        private void pcb1_DragEnter(object sender, DragEventArgs e)
        {/*
            if(e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }*/
        }

        private void pcb1_DragDrop(object sender, DragEventArgs e)
        {
            //PictureBox pcb1 = (PictureBox)sender;
            //pcb1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /*
            pcbpos1.MouseDown += new MouseEventHandler(pcb1_MouseDown);
            pcbpos1.DragEnter += new DragEventHandler(pcb1_DragEnter);
            pcbpos1.DragDrop += new DragEventHandler(pcb1_DragDrop);
            pcbpos2.MouseDown += new MouseEventHandler(pcb3_MouseDown);
            pcbpos2.DragEnter += new DragEventHandler(pcb3_DragEnter);
            pcbpos2.DragDrop += new DragEventHandler(pcb3_DragDrop);

            PictureBox[] vec1 = new PictureBox[2] { pcb1, pcb2 };
            PictureBox[] vecpos = new PictureBox[2] { pcbpos1, pcbpos2 };*/

        }

        private void pcb3_MouseDown(object sender, MouseEventArgs e)
        {
           /* pcbpos2.AllowDrop = true;
            PictureBox pcb3 = (PictureBox)sender;
            pcb3.Select();
            pcb3.DoDragDrop(pcb3.Image, DragDropEffects.Copy);
            if (!(pcbpos2.Image == null))
            {
                pcb3.Visible = false;
            }*/
        }

        private void pcb3_DragEnter(object sender, DragEventArgs e)
        {/*
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;

            }*/
        }
        private void pcb3_DragDrop(object sender, DragEventArgs e)
        {
            /*PictureBox pcb3 = (PictureBox)sender;
            pcb3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);*/
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flechas flechas = new flechas();
            flechas.Tag = this;
            flechas.Show(this);
            Hide();
        }
    }
}
