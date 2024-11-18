using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Festival
    { 
        public int FestivalId { get; set; }
        public int capacity {  get; set; }
        public string Label { get; set; }
        public string ville {  get; set; }
        public ICollection<Concert> Concerts { get; set; }


    }
}
