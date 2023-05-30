using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemishMusic
{
    public class Usuario
    {

        // Atributos correspondientes del usuario que inicie sesion en la app
        public static string id { get; set; }
        public static string usuario { get; set; }

        public static string contra { get; set; }

        public static string nombre { get; set; }
        public static string apellidop { get; set; }
        public static string apellidom { get; set; }

        public static string correo { get; set; }

        public static DateTime fechaNacimiento { get; set; }

        public static byte[] foto { get; set; }

        public static byte[] fotoPortada { get; set; }

        public static string descripcion { get; set; }

        public static string nombreArtistico { get; set; }


    }
}
