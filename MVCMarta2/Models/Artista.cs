using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCMarta2.Models
{
    public class Artista
    {
        public int ArtistaID { get; set; }
        public string Nombre { get; set; }
        public virtual List<Album> Album { get; set; }
    }
}
