using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemishMusic
{
    internal class LeerImagen
    {
        Stream stream;
        public byte[] buffer;
        public void GuardarImagen(string nombre)
        {
            stream = File.OpenRead(nombre);
            buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);
        }
    }
}
