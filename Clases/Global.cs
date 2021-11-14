using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterianriaWinForms.Clases
{
    static class Global
    {
        private static int _IdVeterinaria;

        private static string _NombreVeterinaria;

        public static int IdVeterinaria
        {
            get { return _IdVeterinaria; }
            set { _IdVeterinaria = value; }
        }

        public static string NombreVeterinaria
        {
            get { return _NombreVeterinaria; }
            set { _NombreVeterinaria = value; }
        }

    }
}
