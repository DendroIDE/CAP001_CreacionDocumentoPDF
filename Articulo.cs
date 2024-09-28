using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP001_CreacionDocumentoPDF
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Existencia { get; set; }
        public decimal Pvp { get; set; }
        public string Ubicacion { get; set; }
        public char Vigente { get; set; }
        public byte[] Imagen { get; set; }

    }
}
