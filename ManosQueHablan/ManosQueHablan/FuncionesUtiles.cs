using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManosQueHablan
{
    class FuncionesUtiles
    {
        public static string RootFolderRecursos {
            get { return @"ManosQueHablan\Recursos\"; }
        }
        public static void ShowMensaje(System.Drawing.Bitmap bmpMensaje, System.Drawing.Bitmap bmtEmpezarTerminar)
        {
            frmMensaje mensaje = new frmMensaje();
            mensaje.ThepcbMensaje.Image = bmpMensaje;
            mensaje.ThepcbEmTer.Image = bmtEmpezarTerminar;
            mensaje.ShowDialog();
            mensaje.Dispose();
            mensaje = null;
        }
        public static void ShowMensaje(string strFileNameMensaje, string strFileNameEmpezarTerminar)
        {
            frmMensaje mensaje = new frmMensaje();
            mensaje.ThepcbMensaje.Image = Image.FromFile(FuncionesUtiles.RootFolderRecursos + strFileNameMensaje);
            mensaje.ThepcbEmTer.Image = Image.FromFile(FuncionesUtiles.RootFolderRecursos + strFileNameEmpezarTerminar);
            mensaje.ShowDialog();
            mensaje.Dispose();
            mensaje = null;
        }
        public static void CargarImagen(Form frmFormulario, string strFileName)
        {
            frmFormulario.BackgroundImage = Image.FromFile(FuncionesUtiles.RootFolderRecursos + strFileName);
        }
        public static void CargarImagen(PictureBox picPiturebox, string strFileName)
        {
            string strRootFolderRecursos = @"ManosQueHablan\Recursos\";
            Image imgObtenida = null;
            try
            {
                imgObtenida = Image.FromFile(FuncionesUtiles.RootFolderRecursos + strFileName);
            }
            catch (Exception ex)
            {
                imgObtenida = Image.FromFile(FuncionesUtiles.RootFolderRecursos + "FaltaFoto.png");
            }

            picPiturebox.Image = imgObtenida;
        }
        public static string CargarRutas(string Elemento)
        {
            //path
            string gif;
            gif = "ManosQueHablan/RecursosDeGifs/" + Elemento + ".gif";
            return gif;
        }
        public void Progress(Label lbl, int contador)
        {
            lbl.Text = contador.ToString() + "/30";
        }
    }
}