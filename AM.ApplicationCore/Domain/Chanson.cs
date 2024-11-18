using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
 public class Chanson
    {
        public int ChansonId { get; set; }
        public int Duree { get; set; }
        [Display(Name = "DateSortie")]
        public DateTime DateSortie{ get; set; }
        public EnumStyleMusical styleMusical{ get; set; }
        [StringLength(12, MinimumLength = 3)]
        public string Titre { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "la prop VuesYoutube sdoit être un entier positif.")]
        public int VuesYoutube { get; set; }

    }
}
