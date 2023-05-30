using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemishMusic
{
    public class verArtista
    {

        // Atributos para poder ver los datos de un usuario que no sea el que haya iniciado sesion
        public static string id { get; set; }
        public static string usuario { get; set; }
        public static byte[] foto { get; set; }

        public static byte[] fotoPortada { get; set; }

        public static string descripcion { get; set; }

        public static string nombreArtistico { get; set; }
    }
}
