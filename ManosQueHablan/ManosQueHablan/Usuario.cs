using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ManosQueHablan
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int Progreso { get; set; }

        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand Consulta;
        public OleDbDataReader DrConsulta;

        private void Abrir()
        {
            conn = new OleDbConnection();
            string proveedor;
            proveedor = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ManosQueHablan\Database.mdb";
            conn.ConnectionString = proveedor;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Consulta = conn.CreateCommand();

        }
        public bool IniciarSesion(string nIng, string cIng)
        {
            Abrir();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "IniciarSesion";
            OleDbParameter Para1 = new OleDbParameter("pNombre", nIng);
            Consulta.Parameters.Add(Para1);
            DrConsulta = Consulta.ExecuteReader();
            while (DrConsulta.Read())
            {
                Usuario ouser = new Usuario();
                ouser.Nombre = DrConsulta["Nombre"].ToString();
                ouser.Clave = DrConsulta["Clave"].ToString();

                if (nIng == ouser.Nombre)
                {
                    if (cIng == ouser.Clave)
                    {
                       return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            conn.Close();
            return false;
        }
        public int ConseguirProgreso(string Nombre)
        {
            int prog = 0;
            Abrir();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "TraerProgreso";
            OleDbParameter Para1 = new OleDbParameter("pNombre", Nombre);
            Consulta.Parameters.Add(Para1);
            DrConsulta = Consulta.ExecuteReader();
            while (DrConsulta.Read())
            {
                Usuario oUsu = new Usuario();
                oUsu.Progreso = Convert.ToInt32(DrConsulta["Progreso"]);
                oUsu.Nombre = DrConsulta["Nombre"].ToString();
                prog = oUsu.Progreso;
            }
            conn.Close();
            return prog;
        }
        public void ActualizarProgreso(string nombre, int nuevoProg)
        {
            Abrir();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "UpdateProgreso";
            OleDbParameter Para1 = new OleDbParameter("pProgreso", nuevoProg);
            Consulta.Parameters.Add(Para1);
            OleDbParameter Para2 = new OleDbParameter("pNombre", nombre);
            Consulta.Parameters.Add(Para2);
            Consulta.ExecuteNonQuery();
        }
        public void Registrarse(string nIng, string cIng)
        {
            Abrir();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "Registrarse";
            OleDbParameter Para1 = new OleDbParameter("pNombre", nIng);
            Consulta.Parameters.Add(Para1);
            OleDbParameter Para2 = new OleDbParameter("pClave", cIng);
            Consulta.Parameters.Add(Para2);
            Consulta.ExecuteNonQuery();
            conn.Close();
        }
    }
}