using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManosQueHablan
{
    public static class VariablesUtiles
    {
        public static int Leccion = 0;
        public static string recordar;

        public static int GetLeccion()
        {
            return Leccion;
        }

        public static void SetLeccion(int NuevaLeccion)
        {
            Leccion = NuevaLeccion;
        }

        public static string GetRecordar()
        {
            return recordar;
        }

        public static void SetRecordar(string NuevoRecordar)
        {
            recordar = NuevoRecordar;
        }


    }
}
