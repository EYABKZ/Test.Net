using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Concert
    { public double Cachet { get; set; }
        public int duree { get; set; }
        public DateTime dateConcert { get; set; }
       
        public int ArtisteFk { get; set; }
        public Artiste Artiste { get; set; } 

        public int FestivalFk { get; set; }
        public Festival Festival { get; set; } // Navigation vers Festival
    }
}
