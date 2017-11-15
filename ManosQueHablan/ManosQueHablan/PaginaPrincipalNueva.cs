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
    public partial class PaginaPrincipalNueva : Form
    {
        /*
         
             
             
             ARREGLAR PAGINAS NUEVAS, ARREGLAR PISTA DE UNIR CON FLECHAS Y LLAMAR MANEJO LECCION 2
             
             
             
             
             */
        public string Progress { get; set; }
        public int Cont = 1;
        public bool Salir = false;
        int Leccion = 1;
        //---------------- VOCABULARIO -------------------------------------
        int[] VecCantABC = new int[30] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        String[] VecABC = new String[30] { "A", "B", "C", "CH", "D", "E", "F", "G", "H", "I", "J", "K", "L", "LL", "M", "N", "ENIE", "O", "P", "Q", "R", "RR", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        String[] VecConfManual = new String[30] { "ANGULO", "BE", "CINCO", "CUATRO", "CUERNOS", "CURVA", "DEDOS JUNTOS", "DUO", "GANCHO", "GARRA", "INDICE", "ELE", "L CURVA", "L PLEGADA", "LLAVE", "MANO PLANA", "MAYOR", "MAYOR PULGAR", "MENIQUE", "MITON", "OVALO", "PICO", "PINZA PICO", "PINZA OVALO", "PULGAR", "PUNO", "TELEFONO", "TRES", "VE", "*" };
        String[] VecPresentaciones = new String[30] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public int ContPasar;
        string nombreUsuario;
        //static string recordar;
        public PaginaPrincipalNueva()
        {
            InitializeComponent();
        }
        public void EmpezarPcb(string leccion)
        {
            switch (leccion)
            {
                case "ABC":
                    FuncionesUtiles.ShowMensaje("ABCEmpezar.png", "Empezar.png");
                    Cont = 1;
                    Salir = false;
                    if (VariablesUtiles.GetLeccion() == 1)
                    {
                        this.ManejoLeccion1();
                    }
                    if (VariablesUtiles.GetLeccion() == 2)
                    {
                        this.ManejoLeccion2();
                    }
                    break;
                case "Configuracion":
                    Cont = 1;
                    Salir = false;
                    FuncionesUtiles.ShowMensaje("ConfManualEmpezar.png", "Empezar.png");
                    if (VariablesUtiles.GetLeccion() == 1)
                    {
                        this.ManejoLeccion1();
                    }
                    if (VariablesUtiles.GetLeccion() == 2)
                    {
                        this.ManejoLeccion2();
                    }
                    break;
                case "VidaCotidiana":
                    FuncionesUtiles.ShowMensaje("VidaCotEmpezar.png", "Volver.png");
                    break;
            }
        }
        //-----------------------------Click---------------------------------------
        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Tag = this;
            index.Show(this);
            Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbLeccion1_Click(object sender, EventArgs e)
        {
            VariablesUtiles.SetLeccion(1);
            EmpezarPcb("ABC");
        }
        public void ManejoLeccion1()
        {
            SeleccionarCorrecto ObjetoS2;
            Escribir ObjetoE;
            UnirConFlechas ObjetoU;
            SeleccionarCorrectas ObjetoSCorrectas;
            if (Salir == false)
            {
                if (Cont == 1)
                {
                    ObjetoS2 = new SeleccionarCorrecto();
                    ObjetoS2.PalabrasObtenidas = VecABC;
                    ObjetoS2.Text = "Seleccionar Correcta";
                    ObjetoS2.Inicializar(this);
                    ObjetoS2.ShowDialog();
                    ObjetoS2.Dispose();
                    ObjetoS2 = null;

                }
                if (Cont == 9)
                {
                    ObjetoE = new Escribir();
                    ObjetoE.PalabrasObtenidas = VecABC;
                    ObjetoE.Text = "Escribir";
                    ObjetoE.Inicializar(this);
                    ObjetoE.ShowDialog();
                    ObjetoE.Dispose();
                    ObjetoE = null;
                }
                if (Cont == 19)
                {
                    ObjetoU = new UnirConFlechas();
                    ObjetoU.PalabrasObtenidas = VecABC;
                    ObjetoU.Text = "Unir Con Flechas";
                    ObjetoU.Inicializar(this);
                    ObjetoU.ShowDialog();
                    ObjetoU.Dispose();
                    ObjetoU = null;
                }
                if (Cont == 24)
                {
                    ObjetoSCorrectas = new SeleccionarCorrectas();
                    ObjetoSCorrectas.PalabrasObtenidas = VecABC;
                    ObjetoSCorrectas.Text = "Seleccionar Correctas";
                    ObjetoSCorrectas.Inicializar(this);
                    ObjetoSCorrectas.ShowDialog();
                    ObjetoSCorrectas.Dispose();
                    ObjetoSCorrectas = null;
                }
                if (Cont == 30)
                {
                    if (ContPasar == 4)
                    {
                        MessageBox.Show("Usted ha pasado de ejercicio 4 veces, complete al menos una actividad para desbloquear el siguiente nivel");
                        Usuario oUsu = new Usuario();
                        Iniciar();
                        //PaginaPrincipalNueva pagprincipal = new PaginaPrincipalNueva();
                        //pagprincipal.Tag = this;
                        //pagprincipal.Show();
                    }
                    else
                    {
                        Usuario oUsu = new Usuario();
                        int prog = oUsu.ConseguirProgreso(VariablesUtiles.GetRecordar());
                        if (prog == 0)
                        {
                            oUsu.ActualizarProgreso(VariablesUtiles.GetRecordar(), prog + 1);
                            MessageBox.Show("Terminaste la lección de Abecedario! Desbloqueaste la siguiente lección.");
                        }
                        else
                        {
                            MessageBox.Show("Terminaste la lección de Abecedario!");
                        }
                        //PaginaPrincipalNueva pagnueva = new PaginaPrincipalNueva();
                        //pagnueva.Show();
                        //Iniciar();
                        Iniciar();
                        //Progreso();
                        //Show();
                    }
                }
            }
            else
            {
                Iniciar();
                //PaginaPrincipalNueva pagprincipal = new PaginaPrincipalNueva();
                //pagprincipal.Show();
            }
        }

        public void ManejoLeccion2()
        {
            if (Salir == false)
            {
                if (Cont == 1)
                {
                    SeleccionarCorrecto ObjetoS2 = new SeleccionarCorrecto();
                    ObjetoS2.PalabrasObtenidas = VecConfManual;
                    ObjetoS2.Text = "Configuracion Manual";
                    ObjetoS2.Inicializar(this);
                    ObjetoS2.ShowDialog();
                    ObjetoS2.Dispose();
                    ObjetoS2 = null;
                }
                if (Cont == 9)
                {
                    Escribir ObjetoE = new Escribir();
                    ObjetoE.PalabrasObtenidas = VecConfManual;
                    ObjetoE.Text = "Escribir";
                    ObjetoE.Inicializar(this);
                    ObjetoE.ShowDialog();
                    ObjetoE.Dispose();
                    ObjetoE = null;
                }
                if (Cont == 19)
                {
                    UnirConFlechas ObjetoU = new UnirConFlechas();
                    ObjetoU.PalabrasObtenidas = VecConfManual;
                    ObjetoU.Text = "UnirConFlechas";
                    ObjetoU.Inicializar(this);
                    ObjetoU.ShowDialog();
                    ObjetoU.Dispose();
                    ObjetoU = null;
                }
                if (Cont == 24)
                {
                    SeleccionarCorrectas ObjetoSCorrectas = new SeleccionarCorrectas();
                    ObjetoSCorrectas.PalabrasObtenidas = VecConfManual;
                    ObjetoSCorrectas.Text = "Seleccionar Correctas";
                    ObjetoSCorrectas.Inicializar(this);
                    ObjetoSCorrectas.ShowDialog();
                    ObjetoSCorrectas.Dispose();
                    ObjetoSCorrectas = null;
                }
                if (Cont == 30)
                {
                    if (ContPasar == 4)
                    {
                        MessageBox.Show("Usted ha pasado de ejercicio 4 veces, complete al menos una actividad para desbloquear el siguiente nivel");
                        Usuario oUsu = new Usuario();
                        Iniciar();
                        //PaginaPrincipalNueva pagprincipal = new PaginaPrincipalNueva();
                        //pagprincipal.Tag = this;
                        //pagprincipal.Show();
                    }
                    else
                    {
                        Usuario oUsu = new Usuario();
                        int prog = oUsu.ConseguirProgreso(VariablesUtiles.GetRecordar());
                        if (prog == 1)
                        {
                            oUsu.ActualizarProgreso(VariablesUtiles.GetRecordar(), prog + 1);
                            MessageBox.Show("Terminaste la lección de Configuración Manual! Desbloqueaste la siguiente lección.");
                        }
                        else
                        {
                            MessageBox.Show("Terminaste la lección de Configuración Manual!");
                        }
                        Iniciar();
                    }
                }

            }
            else
            {
                Iniciar();
            }
        }
        private void PaginaPrincipalNueva_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        public void Iniciar()
        {
            nombreUsuario = VariablesUtiles.GetRecordar();
            //using (IniciarSesion iniciar = new IniciarSesion())
            //{
            //    nombreUsuario = VariablesUtiles.GetRecordar();
            //}
            //if (nombreUsuario == VariablesUtiles.GetRecordar())
            //{
            //    using (Registrarse regis = new Registrarse())
            //    {
            //        nombreUsuario = Registrarse.nombreUs;
            //    }
            //}
            lblNombreUsuario.Text = "Hola, " + VariablesUtiles.GetRecordar() + "!";
            CargarImagenes();
            Progreso();
        }
        private void CargarImagenes()
        {
            FuncionesUtiles.CargarImagen(this, "Background.png");
            FuncionesUtiles.CargarImagen(btnSalir, "salir.png");
            FuncionesUtiles.CargarImagen(pcbLeccion1, "LeccionABC.png");
            FuncionesUtiles.CargarImagen(pcbLeccion2, "LeccionConfManual.png");
            FuncionesUtiles.CargarImagen(pcbLeccion3, "LeccionVidaCot.png");
            FuncionesUtiles.CargarImagen(pcbLeccion4, "LeccionPresent.png");
            FuncionesUtiles.CargarImagen(pcbLeccion5, "LeccionCalendarioBN.png");
            FuncionesUtiles.CargarImagen(pcbLeccion6, "LeccionCuerpoBN.png");
        }
        public void Progreso()
        {
            if (nombreUsuario == null)
            {
                nombreUsuario = VariablesUtiles.GetRecordar();
            }
            Usuario ousu = new Usuario();
            int progreso = ousu.ConseguirProgreso(nombreUsuario);
            switchP(progreso);
        }
        public void switchP(int progreso)
        {
            switch (progreso)
            {
                case 0:
                    FuncionesUtiles.CargarImagen(pcbLeccion2, "LeccionConfManualBN.png");
                    FuncionesUtiles.CargarImagen(pcbLeccion3, "LeccionVidaCotBN.png");
                    FuncionesUtiles.CargarImagen(pcbLeccion4, "LeccionPresentBN.png");
                    pcbLeccion1.Enabled = true;
                    pcbLeccion2.Enabled = false;
                    pcbLeccion3.Enabled = false;
                    pcbLeccion4.Enabled = false;
                    break;
                case 1:
                    FuncionesUtiles.CargarImagen(pcbLeccion3, "LeccionVidaCotBN.png");
                    FuncionesUtiles.CargarImagen(pcbLeccion4, "LeccionPresentBN.png");
                    pcbLeccion1.Enabled = true;
                    pcbLeccion2.Enabled = true;
                    pcbLeccion3.Enabled = false;
                    pcbLeccion4.Enabled = false;
                    break;
                case 2:
                    FuncionesUtiles.CargarImagen(pcbLeccion4, "LeccionPresentBN.png");
                    pcbLeccion1.Enabled = true;
                    pcbLeccion2.Enabled = true;
                    pcbLeccion3.Enabled = true;
                    pcbLeccion4.Enabled = true;
                    break;
                default:
                    pcbLeccion1.Enabled = true;
                    pcbLeccion2.Enabled = true;
                    pcbLeccion3.Enabled = true;
                    pcbLeccion4.Enabled = true;
                    break;
            }
        }
        private void pcbLeccion2_Click(object sender, EventArgs e)
        {
            VariablesUtiles.SetLeccion(2);
            EmpezarPcb("Configuracion");
        }

        private void pcbLeccion3_Click(object sender, EventArgs e)
        {
            VariablesUtiles.SetLeccion(3);
            EmpezarPcb("VidaCotidiana");
        }
    }
}