using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Artiste
    { 
       //[key]
        public int ArtisteId {  get; set; }
        public string Contact{ get; set; }
        public DateTime DateDeNaissance{ get; set; }
        public string Nationalité {  get; set; }
        public string Nom { get; set; }
        public string prenom {  get; set; }

        
        public int ArtisteFk { get; set; } 
        public Artiste ArtisteFK { get; set; } 

    }
}
