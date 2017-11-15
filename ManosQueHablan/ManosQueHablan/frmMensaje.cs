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
    public partial class frmMensaje : Form
    {
        public PictureBox ThepcbMensaje {
             get {return pcbMensaje; }
        }
        public PictureBox ThepcbEmTer
        {
            get { return pcbEmTer; }
        }

        public frmMensaje()
        {
            InitializeComponent();
        }
        private void pcbEmTer_Click(object sender, EventArgs e)
        {
            //PaginaPrincipalNueva pagNueva = new PaginaPrincipalNueva();
            //Hide();
            Close();

            //if (VariablesUtiles.GetLeccion() == 1)
            //{
            //    pagNueva.ManejoLeccion1();
            //}
            //if (VariablesUtiles.GetLeccion() == 2)
            //{
            //    pagNueva.ManejoLeccion2();
            //}
        }
    }
}
