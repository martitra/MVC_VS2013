using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMarta2.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Titulo { get; set; }
        public Artista Artista { get; set; }
        public virtual List<Review> Review { get; set; }
    }
}