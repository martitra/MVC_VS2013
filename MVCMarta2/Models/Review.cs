using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MVCMarta2.Models
{
   public class Review
    {

       public int ReviewID { get; set; }
       [Display(Name="Album")]
       public int AlbumID { get; set; }
       public virtual Album Album { get; set; }
       public string Contenido { get; set; }
       [Required()]
       [Display(Name="Correo Electrónico")]
       [DataType(DataType.EmailAddress)]
       public string ReviewerEmail { get; set; }


    }
}
